using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class MainWindowViewModel : BindableBase
    {
        private LoggedInViewModel loggedInViewModel = new LoggedInViewModel();
        private RegisteredViewModel registeredViewModel = new RegisteredViewModel();
        private HomeViewModel homeViewModel = new HomeViewModel();
        private ObservableCollection<User> users;
        private DataIO dataIO = new DataIO();

        public MainWindowViewModel()
        {   
            LoadUsers();
            CurrentViewModel = homeViewModel;
            NavigationService.Instance.MainWindowViewModel = this;
        }

        private void SaveUsers()
        {
            dataIO.SerializeObject<ObservableCollection<User>>(Users, "..\\..\\Data\\users.xml");
        }

        private void LoadUsers()
        {
            Users = dataIO.DeSerializeObject<ObservableCollection<User>>("..\\..\\Data\\users.xml");
            if (Users == null)
                Users = new ObservableCollection<User>();
        }

        public void AddUser(User newUser)
        {
            users.Add(newUser);
            SaveUsers();
        }

        public void ImageAdded()
        {
            SaveUsers();
        }

        public void UserDataChanged()
        {
            SaveUsers();
        }

        public BindableBase CurrentViewModel
        {
            get { return NavigationService.Instance.CurrentViewModel; }
            set
            {
                NavigationService.Instance.CurrentViewModel = value;
            }
        }

        public ObservableCollection<User> Users { get => users; set => users = value; }

    }
}
