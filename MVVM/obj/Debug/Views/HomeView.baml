   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5      'clr-namespace:MVVM.Model
MVVM.Model  5      #clr-namespace:MVVM.VMLMVVM.VML  5          MVVM.Views.HomeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MVVM.Views     5      )dataclr-namespace:MVVM.Model     5      &vmlclr-namespace:MVVM.VML     5         MVVM.VML.ViewModelLocator    AutoHookedUpViewModel  . 
������� � 	Resources 5       �� DataType   MVVM.Model.User �� Orientation �� Path �� Mode��%+  (��       5      *, +)�� 6
   "  6   .R�5      �� $ Vertical=�6   .+�5      �� $��16(�5      $
��Wrap=�5      ��5      �� $ Username�$ OneWay=�5      �� 5      $
��Wrap=�5      ��5      �� $ Password�$ OneWay=�5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��10 �6   �� 5      $��58 �6   �� 5      $��62 �6   �� 5      $��0 �6   �� 5       $��50 �6   �� 5!      $��10 �6   �� 5"      $��* �6    � ColumnDefinitions 5%   
   �� 5&      $��* �6   �� 5'      $	��140 �6   �� 5(      $��* �6   .+�5+   
   �� $��1��6   $��1��6'   $ Vertical=�66   .+�5,      �� $��Center=�6   $��Hello there!��65   $��18(�6I   $
��Bold"�6W   
����� �6i   �� 5-      $��Center=�6   $��Please log in��65   $��14(�6J   $
��Bold"�6X   
����� �6j   5.      �� 50   
   $��1��6   $��3��6'   $ Vertical=�66   .+�51      �� $��Center=�6   $��	Username:��65   $��16(�6F   $��Regular"�6T   
����� �6i   �� 52      $��Stretch=�6   $��14(�64   ��6B   �� *CurrentUser.Username+$ TwoWay=��� 53      $��Center=�6   
���  ����65   �� *(&CurrentUser.ValidationErrors[Username]+6m   54      �� 56   
   $��1��6   $��4��6'   $ Vertical=�66   .+�57      �� $��Center=�6   $��	Password:��65   $��16(�6F   $��Regular"�6T   
����� �6i   �� 58      $��Stretch=�6   $��14(�64   ��6B   �� *CurrentUser.Password+$ TwoWay=��� 59      $��Center=�6   
���  ����65   �� *(&CurrentUser.ValidationErrors[Password]+6m   5:      �� 5<   
   $��1��6   $��6��6'   $ Vertical=�66   .+�5=      �� $��Login��6   $��30��5>      $��Stretch=�5?      
����� �
���������5B      �� *LoginCommand+5C      �� 5E   
   $��1��6   $��8��6'   $ Vertical=�66   .+�5F      �� $��Center=�6   $��Don't have an account?��65   $��12(�6S   $��Regular"�6a   
����� �6v   �� 5G      $��Register��6   $��30��5H      $��Stretch=�5I      
����� �
���������5L      �� *RegisterCommand+5M      5N      5O      