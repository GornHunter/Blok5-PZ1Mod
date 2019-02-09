using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class AccountDetailsViewModel : BindableBase
    {
        public MyICommand ApplyCommand { get; set; }
        private User currentUser = new User();

        public AccountDetailsViewModel()
        {
            ApplyCommand = new MyICommand(OnApply);
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

        public void SetCurrentUser()
        {
            CurrentUser = NavigationService.Instance.LoggedUser;
            OnPropertyChanged("CurrentUser");
        }

        private void OnApply()
        {
            CurrentUser.Validate();
            if (CurrentUser.IsValid)
            {
                if (NavigationService.Instance.MainWindowViewModel.Users.Any(user => user.Username.Equals(CurrentUser.Username)) && !NavigationService.Instance.LoggedUser.Username.Equals(CurrentUser.Username))
                {
                    CurrentUser.ValidationErrors.Clear();
                    CurrentUser.ValidationErrors["Username"] = "Username already taken";
                    CurrentUser.IsValid = CurrentUser.ValidationErrors.IsValid;
                    RaisePropertyChanged(CurrentUser, "IsValid");
                    RaisePropertyChanged(CurrentUser, "ValidationErrors");
                }
                else
                {
                    NavigationService.Instance.LoggedUser.Username = CurrentUser.Username;
                    NavigationService.Instance.LoggedUser.Password = CurrentUser.Password;
                    NavigationService.Instance.MainWindowViewModel.UserDataChanged();
                    CurrentUser = new User();
                    RaisePropertyChanged(NavigationService.Instance.MainWindowViewModel, "Users");
                    OnPropertyChanged("CurrentUser");
                }
            }
        }

    }
}
