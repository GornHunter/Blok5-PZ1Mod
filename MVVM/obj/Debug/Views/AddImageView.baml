   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5          MVVM.Views.AddImageView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MVVM.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $	��240 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $	��120 �6   �� 5      $��60 �6   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6'    �� Orientation$ Vertical=�64   .+�5      �� $	��120��6   $	��100��6!   
�������
���������6U   �� *SelectImgCommand+.��5      �� ��6   �� *SelectedImage+5      �� 5      $��Center=�6   
���  ����65   �� *$"CurrentImage.ValidationErrors[Uri]+6i   5      �� 5   
   $��1��6   $��2��6'   $ Vertical=�64   .+�5      �� $��Center=�6   $��Title:��65   $��16(�6C   $��Regular"�6Q   
����� �6f   �� 5      $��Stretch=�6   $��14(�64   ��6B   �� *CurrentImage.Title+ �� Mode$ TwoWay=��� 5       $��Center=�6   
���  ����65   �� *&$CurrentImage.ValidationErrors[Title]+6k   5!      �� 5"   
   $��1��6   $��3��6'   $ Vertical=�64   .+�5#      �� $��Center=�6   $��Description:��65   $��16(�6I   $��Regular"�6W   
����� �6l   �� 5$       �� TextWrapping$
 Wrap=�6   $��45��6*   $��Stretch=�66   $��14(�6T   ��6b   �� *CurrentImage.Description+$ TwoWay=�5%      �� 5&   
   $��1��6   $��4��6'   $ Vertical=�66   .+�5'      �� $��	Add Image��6   $��30��5(      $��Stretch=�5)      
����� �
���������5,      �� *AddImgCommand+5-      5.      5/      