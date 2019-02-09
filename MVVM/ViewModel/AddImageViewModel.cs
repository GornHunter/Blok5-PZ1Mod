using MVVM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class AddImageViewModel : BindableBase
    {
        private string addIcon = "..\\..\\Data\\Images\\add.png";
        private string selectedImage = "..\\..\\Data\\Images\\add.png";
        public MyICommand SelectImgCommand { get; set; }
        public MyICommand AddImgCommand { get; set; }
        private Image currentImage = new Image();


        public AddImageViewModel()
        {
            SelectImgCommand = new MyICommand(OnSelectImg);
            AddImgCommand = new MyICommand(OnAddImg);
        }

        public string SelectedImage
        {
            get { return selectedImage; }
            set
            {
                selectedImage = value;
                OnPropertyChanged("SelectedImage");
            }
        }

        public Image CurrentImage
        {
            get { return currentImage; }
            set
            {
                currentImage = value;
                OnPropertyChanged("CurrentImage");
            }
        }

        private void OnSelectImg()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                SelectedImage = dlg.FileName;
                CurrentImage.Uri = SelectedImage;
            }
        }

        private void OnAddImg()
        {
            CurrentImage.Validate();
            if (CurrentImage.IsValid)
            {
                CurrentImage.Time = DateTime.Now;
                NavigationService.Instance.LoggedUser.Images.Add(CurrentImage);
                NavigationService.Instance.MainWindowViewModel.ImageAdded();
                SelectedImage = addIcon;
                CurrentImage = new Image();
                RaisePropertyChanged(NavigationService.Instance.MainWindowViewModel, "Users");
                OnPropertyChanged("SelectedImage");
                OnPropertyChanged("CurrentImage");
            }
        }
    }
}
