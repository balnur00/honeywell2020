   M S B A M L   `   `   `  ����F  BFirstWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FirstWpfApp.ViewsFirstWpfApp.Views  5   	   ?$clr-namespace:FirstWpfApp.ViewModelsFirstWpfApp.ViewModels  5   	       FirstWpfApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1viewsclr-namespace:FirstWpfApp.Views     5   	   ;
viewmodels$clr-namespace:FirstWpfApp.ViewModels     5   	     � Title$  Калькулятор��5   	   $	��450��6   $��477.886��6*    � 	Resources 5       �� DataType'  !FirstWpfApp.ViewModels.Calculator)   #FirstWpfApp.Views.RegularCalculator � DataContext&   FirstWpfApp.ViewModels.Converter!   FirstWpfApp.Views.Converter%  FirstWpfApp.ViewModels.Calendar    FirstWpfApp.Views.Calendar$  FirstWpfApp.ViewModels.AboutUs    FirstWpfApp.Views.About_us��%�  (��       5   :   *, +)(�� ^     5   2   *, +)(�� �     5   1   *, +)(�� 	    5   0   *, +)�� 5   
   regularCalculatorTemplate��"  6:   .R�5	         6&   �� 5
      �� 5   
   converterTemplate��"  62   .R�5         6   �� 5      �� 5   
   calendarTemplate��"  61   .R�5         6   �� 5      �� 5   
   aboutusTemplate��"  60   .R�5         6   �� 5      5      .��5      � $	��402��6   $��10,10,10,10q�6   $	��Top=�6-    � ColumnDefinitions 5   
   �� 5      $
��172* �6   �� 5      $
��281* �6   .+�5   
   �� ���	#FFF4F4F4$
��Left=�6,   $	��382��6G   $��	10,10,0,0q�6T   $	��Top=�6g   $	��152��6   .+�5      �� $��
Calculator��6   $
��Left=�6)   $��	10,40,0,0q�6D   $	��Top=�6W   �� 5      -   5        $��20��5      $��0,0,0,0q�6!   
�������.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Regular��6    5       5!      �� 5"      $��20��6   $��0,5,0,0q�6!   $��Engineer��62   
�������6E   �� 5#      $��20��6   $��0,5,0,0q�6!   $��
Programmer��62   
�������6G   �� 5$      -   5        $��20��5$      $��0,30,0,0q�6!   $��Calendar��63   
�������6]   �� 5%      $��	Converter��6   $
��Left=�6(   $��	10,20,0,0q�6C   $	��Top=�6V   �� 5&      $��20��6   $��0,0,0,0q�6!   $��Currency��62   
�������6E   �� 5'      $��20��6   $��0,5,0,0q�6!   $��Volume��62   
�������6C   �� 5(      -   5        $��20��5(      $��0,5,0,0q�6!   $��Length��62   
�������6Z   �� 5)      $��20��6   $��0,30,0,0q�6!   $��About us��63   
�������6F   5*      �� 5,   
   $��0��6   $��1��6&   ��66   �� 5-      5.      