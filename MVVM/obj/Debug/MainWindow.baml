   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MVVMMVVM  5   	   'clr-namespace:MVVM.Views
MVVM.Views  5   	   /clr-namespace:MVVM.ViewModelMVVM.ViewModel  5   	       MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MVVM     5   	   *viewsclr-namespace:MVVM.Views     5   	   2	viewModelclr-namespace:MVVM.ViewModel     5   	     � Title$  Image Collector��5
   	   $	��400��6!   $	��350��6.    � DataContext 5         MVVM.MainWindowViewModel  5   
    � 	Resources 5       �� DataType"   MVVM.ViewModel.HomeViewModel   MVVM.Views.HomeView&    MVVM.ViewModel.LoggedInViewModel   MVVM.Views.LoggedInView(   "MVVM.ViewModel.RegisteredViewModel   MVVM.Views.RegisteredView&    MVVM.ViewModel.AddImageViewModel	   MVVM.Views.AddImageView&
    MVVM.ViewModel.MyImagesViewModel   MVVM.Views.MyImagesView,   &MVVM.ViewModel.AccountDetailsViewModel#   MVVM.Views.AccountDetailsView��%�  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)(�� �     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5   
   " 
 6   .R�5        5      �� 5   
   "  6   .R�5        5       5!      .��5"      � .+�5#   
   �� ��6   �� *CurrentViewModel+5$      5%      