   M S B A M L   `   `   `  ����B  >Plumber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Plumber.ViewModelPlumber.ViewModel  5   	       Plumber.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Plumber.ViewModel     5   	     � Title$  Plumber��5   	   $	��600��6   $	��490��6&    � DataContext 5
      %   Plumber.ViewModel.MainViewModel  5   
   .��5      � $
��auto��6   $
��auto��6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   ��6.   �� *	OpenCrane+.��5      �� $��/Images/Crane.jpg��6   $
��Fill=�6/   5      �� 5!   
   $��0��6   $��1��6   $��3��6-   $��/Images/GameName.jpg��6A   $
��Fill=�6_   �� 5#   
   $��1��6   $��0��6   $��10��6.   ��6D   �� *TurnStraight+.��5$      �� $
��Fill=�6Y   ��6   ��  �� Path$ Image10� �� UpdateSourceTrigger$ PropertyChanged=�6Y   5%      �� 5'   
   $��1��6   $��1��6   $��11��6.   ��6D   �� *
TurnTurned+.��5(      �� $
��Fill=�6Y   ��6   �� $ Image11�$ PropertyChanged=�6Y   5)      �� 5+   
   $��1��6   $��2��6   $��12��6.   ��6D   �� *TurnStraight+.��5,      �� $
��Fill=�6Y   ��6   �� $ Image12�$ PropertyChanged=�6Y   5-      �� 5/   
   $��1��6   $��3��6   $��13��6.   ��6D   �� *
TurnTurned+.��50      �� $
��Fill=�6Y   ��6   �� $ Image13�$ PropertyChanged=�6Y   51      �� 53   
   $��2��6   $��0��6   $��20��6.   ��6D   �� *
TurnTurned+.��54      �� $
��Fill=�6Y   ��6   �� $ Image20�$ PropertyChanged=�6Y   55      �� 57   
   $��2��6   $��1��6   $��21��6.   ��6D   �� *
TurnTurned+.��58      �� $
��Fill=�6Y   ��6   �� $ Image21�$ PropertyChanged=�6Y   59      �� 5;   
   $��2��6   $��2��6   $��22��6.   ��6D   �� *
TurnTurned+.��5<      �� $
��Fill=�6Y   ��6   �� $ Image22�$ PropertyChanged=�6Y   5=      �� 5?   
   $��2��6   $��3��6   $��23��6.   ��6D   �� *TurnStraight+.��5@      �� $
��Fill=�6Y   ��6   �� $ Image23�$ PropertyChanged=�6Y   5A      �� 5C   
   $��3��6   $��0��6   $
��Fill=�6s   ��6.   �� $ Image30�$ PropertyChanged=�6s   �� 5E   
   $��3��6   $��1��6   $��31��6.   ��6D   �� *
TurnTurned+.��5F      �� $
��Fill=�6Y   ��6   �� $ Image31�$ PropertyChanged=�6Y   5G      �� 5I   
   $��3��6   $��2��6   $��32��6.   ��6D   �� *TurnStraight+.��5J      �� $
��Fill=�6Y   ��6   �� $ Image32�$ PropertyChanged=�6Y   5K      �� 5M   
   $��3��6   $��3��6   $��33��6.   ��6D   �� *
TurnTurned+.��5N      �� $
��Fill=�6Y   ��6   �� $ Image33�$ PropertyChanged=�6Y   5O      �� 5Q   
   $��4��6   $��4��6   $
��Fill=�6y   ��61   �� $ 
FooterPipe�$ PropertyChanged=�6y   5R      5S      