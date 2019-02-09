using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class LoggedInViewModel : BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }
        private MyImagesViewModel myImagesViewModel = new MyImagesViewModel();
        private AddImageViewModel addImageViewModel = new AddImageViewModel();
        private AccountDetailsViewModel accountDetailsViewModel = new AccountDetailsViewModel();
        private BindableBase localCurrentViewModel;

        public LoggedInViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
            LocalCurrentViewModel = myImagesViewModel;
        }

        public void LoadMyImagesViewModel()
        {
            LocalCurrentViewModel = myImagesViewModel;
        }

        public BindableBase LocalCurrentViewModel
        {
            get { return localCurrentViewModel; }
            set
            {
                if (NavigationService.Instance.LoggedUser != null)
                    myImagesViewModel.LoadImageCollection();
                SetProperty(ref localCurrentViewModel, value);
            }
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "myImages":
                    myImagesViewModel.LoadImageCollection();
                    LocalCurrentViewModel = myImagesViewModel;
                    break;
                case "addImage":
                    LocalCurrentViewModel = addImageViewModel;
                    break;
                case "account":
                    accountDetailsViewModel.SetCurrentUser();
                    LocalCurrentViewModel = accountDetailsViewModel;
                    break;
            }
        }
    }
}
