   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5      'clr-namespace:MVVM.Model
MVVM.Model  5      #    MVVM.Views.AccountDetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MVVM.Views     5      )dataclr-namespace:MVVM.Model     5        � 	Resources  5
       �� DataType   MVVM.Model.User �� Orientation �� Path �� Mode��%+  (��       5      *, +)�� 6
   "  6   .R�5      �� $ Vertical=�6   .+�5      �� $��16(�5      $
��Wrap=�5      ��5      �� $ Username�$ OneWay=�5      �� 5      $
��Wrap=�5      ��5      �� $ Password�$ OneWay=�5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��20 �6   �� 5      $��10 �6   �� 5      $��58 �6   �� 5      $��62 �6   �� 5      $��0 �6   �� 5      $��50 �6   �� 5      $��10 �6   �� 5      $��* �6    � ColumnDefinitions 5"   
   �� 5#      $��* �6   �� 5$      $	��140 �6   �� 5%      $��* �6   .+�5(   
   �� $��1��6   $��3��6'   $ Vertical=�66   .+�5)      �� $��Center=�6   $��New Username:��65   $��16(�6J   $��Regular"�6X   
����� �6m   �� 5*      $��Stretch=�6   $��14(�64   ��6B   �� *CurrentUser.Username+$ TwoWay=��� 5+      $��Center=�6   
���  ����65   �� *(&CurrentUser.ValidationErrors[Username]+6m   5,      �� 5.   
   $��1��6   $��4��6'   $ Vertical=�66   .+�5/      �� $��Center=�6   $��New Password:��65   $��16(�6J   $��Regular"�6X   
����� �6m   �� 50      $��Stretch=�6   $��14(�64   ��6B   �� *CurrentUser.Password+$ TwoWay=��� 51      $��Center=�6   
���  ����65   �� *(&CurrentUser.ValidationErrors[Password]+6m   52      �� 54   
   $��1��6   $��6��6'   $ Vertical=�66   .+�55      �� $��Apply Changes��6   $��30��56      $��Stretch=�57      
����� �
���������5:      �� *ApplyCommand+5;      5<      5=      