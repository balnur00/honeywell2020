   M S B A M L   `   `   `  ����F  BFirstWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FirstWpfApp.ViewsFirstWpfApp.Views  5      !    FirstWpfApp.Views.Converter   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FirstWpfApp.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ fromNum��5      $��0��6#   $��3��63   6B   �� 5   
   -   5         ��Name$
 from��5      $��1��6!   $��3��61   .@�5      �� .��6   Millimeters6(   �� 5      .��6   Centimeters6(   �� 5      .��6   Meters6#   �� 5      .��6   
Kilometers6'   �� 5      .��6   Miles6"   �� 5       .��6   Feet6!   5!      �� 5"   
   -   5        $ to��5"      $��3��6   $��3��6/   .@�5#      �� .��6   Millimeters6(   �� 5$      .��6   Centimeters6(   �� 5%      .��6   Meters6#   �� 5&      .��6   
Kilometers6'   �� 5'      .��6   Miles6"   �� 5(      .��6   Feet6!   5)      �� 5*   
   -   5         ��Name$ answer��5*      $��2��6$   $��3��64   
�������6Z   �� 5+   
   -   5         ��Name$ 
convertBtn��5+   .   $��2��6B   $��5��6R   $��3��6_   $��Convert��6s   6�   5,      5.      