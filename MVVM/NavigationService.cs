using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class NavigationService : BindableBase
    {
        private static NavigationService instance;
        private BindableBase currentViewModel;
        private MainWindowViewModel mainWindowViewModel;
        private User loggedUser;

        private NavigationService() { }

        public static NavigationService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NavigationService();
                }
                return instance;
            }
        }

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }

        public MainWindowViewModel MainWindowViewModel { get => mainWindowViewModel; set => mainWindowViewModel = value; }
        public User LoggedUser { get => loggedUser; set => loggedUser = value; }
    }
}
