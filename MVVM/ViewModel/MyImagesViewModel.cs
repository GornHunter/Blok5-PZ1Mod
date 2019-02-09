using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class MyImagesViewModel : BindableBase
    {
        public ObservableCollection<Image> Images { get; set; }

        public MyImagesViewModel()
        {
            //LoadImageCollection();
        }

        public void LoadImageCollection()
        {
            Images = new ObservableCollection<Image>(NavigationService.Instance.LoggedUser.Images);
            OnPropertyChanged("Images");
        }
    }
}
