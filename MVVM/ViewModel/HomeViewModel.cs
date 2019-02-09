using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class HomeViewModel : BindableBase
    {
        private LoggedInViewModel loggedInViewModel = new LoggedInViewModel();
        private RegisteredViewModel registeredViewModel = new RegisteredViewModel();
        public MyICommand LoginCommand { get; set; }
        public MyICommand RegisterCommand { get; set; }
        public static ObservableCollection<User> users;
        private User currentUser = new User();

        public HomeViewModel()
        {
            LoginCommand = new MyICommand(OnLogin);
            RegisterCommand = new MyICommand(OnRegister);
        }

        public User CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }

        private void OnLogin()
        {
            CurrentUser.Validate();
            if (CurrentUser.IsValid)
            {
                if (!NavigationService.Instance.MainWindowViewModel.Users.Any(user => user.Username.Equals(CurrentUser.Username)))
                {
                    CurrentUser.ValidationErrors.Clear();
                    CurrentUser.ValidationErrors["Username"] = "User doesn't exist";
                    CurrentUser.IsValid = CurrentUser.ValidationErrors.IsValid;
                    RaisePropertyChanged(CurrentUser, "IsValid");
                    RaisePropertyChanged(CurrentUser, "ValidationErrors");
                }
                else if (!NavigationService.Instance.MainWindowViewModel.Users.Any(user => user.Username.Equals(CurrentUser.Username) && user.Password.Equals(CurrentUser.Password)))
                {
                    CurrentUser.ValidationErrors.Clear();
                    CurrentUser.ValidationErrors["Password"] = "Incorrect password";
                    CurrentUser.IsValid = CurrentUser.ValidationErrors.IsValid;
                    RaisePropertyChanged(CurrentUser, "IsValid");
                    RaisePropertyChanged(CurrentUser, "ValidationErrors");
                }
                else
                {
                    NavigationService.Instance.LoggedUser = NavigationService.Instance.MainWindowViewModel.Users.FirstOrDefault(user => user.Username.Equals(CurrentUser.Username) && user.Password.Equals(CurrentUser.Password));
                    NavigationService.Instance.CurrentViewModel = loggedInViewModel;
                    loggedInViewModel.LoadMyImagesViewModel();
                    RaisePropertyChanged(NavigationService.Instance.MainWindowViewModel, "CurrentViewModel");
                }
            }
        }

        private void OnRegister()
        {
            CurrentUser.Validate();
            if (CurrentUser.IsValid)
            {
                if (NavigationService.Instance.MainWindowViewModel.Users.Any(user => user.Username.Equals(CurrentUser.Username)))
                {
                    CurrentUser.ValidationErrors.Clear();
                    CurrentUser.ValidationErrors["Username"] = "Username already taken";
                    CurrentUser.IsValid = CurrentUser.ValidationErrors.IsValid;
                    RaisePropertyChanged(CurrentUser, "IsValid");
                    RaisePropertyChanged(CurrentUser, "ValidationErrors");
                }
                else
                {
                    NavigationService.Instance.MainWindowViewModel.AddUser(CurrentUser);
                    NavigationService.Instance.CurrentViewModel = registeredViewModel;
                    RaisePropertyChanged(NavigationService.Instance.MainWindowViewModel, "CurrentViewModel");
                }
            }
        }
    }
}
