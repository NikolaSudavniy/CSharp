   M S B A M L   `   `   `  ����F  BFaceBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FaceBuilder.ViewModelFaceBuilder.ViewModel  5   	       FaceBuilder.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   /local#clr-namespace:FaceBuilder.ViewModel  5   	     � Title$  	Identikit��5	   	   $��343.719��6   $��553.721��6,    � DataContext 5      )   #FaceBuilder.ViewModel.MainViewModel  5   
   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Closing��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *WindowClosing+5      .��5      � 
�������$��0,0,11,2q�6"    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��272 �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5$      ��  �� SelectedIndex 6   �� 	 �� Path$	 ComboBoxIndexOfEyeBrows� 5%        5&      $ SelectionChanged��6%   . 5'        
   CommandParameter$
 Brows��60    5(   0   �� $	 SelectedImageChange�5)      .@�5+      �� $��Brows 1��6   �� 5,      $��Brows 2��6   �� 5-      $��Brows 3��6   5.      �� 50      $��1��6    6$   �� $	 ComboBoxIndexOfEyes� 51        52      $ SelectionChanged��6%   . 53        $	
 Eye��60    54   0   �� $	 SelectedImageChange�55      .@�57      �� $��Eye 1��6   �� 58      $��Eye 2��6   �� 59      $��Eye 3��6   �� 5:      $��Eye 4��6   �� 5;      $��Eye 5��6   �� 5<      $��Eye 6��6   5=      �� 5?      $��2��6    6$   �� $	 ComboBoxIndexOfNose� 5@        5A      $ SelectionChanged��6%   . 5B        $

 Nose��60    5C   0   �� $	 SelectedImageChange�5D      .@�5F      �� $��Nose 1��6   �� 5G      $��Nose 2��6   �� 5H      $��Nose 3��6   �� 5I      $��Nose 4��6   5J      �� 5L      $��3��6    6$   �� $	 ComboBoxIndexOfLips� 5M        5N      $ SelectionChanged��6%   . 5O        $

 Lips��60    5P   0   �� $	 SelectedImageChange�5Q      .@�5S      �� $��Lips 1��6   �� 5T      $��Lips 2��6   �� 5U      $��Lips 3��6   �� 5V      $��Lips 4��6   �� 5W      $��Lips 5��6   �� 5X      $��Lips 6��6   �� 5Y      $��Lips 7��6   5Z      �� 5\      $��4��6   $��	0,20,0,20q�6'   .+�5]      �� $��Saved faces:��6   �� 5^      ��6   �� $	 TemplateFaceNames� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5_      �� $	 SelectedFaceToLoad�$ PropertyChanged=� 5`        5a      $ SelectionChanged��6)   . 5b         64   �� $	 LoadTemplateFace�5c      5e      �� 5f      $��20��6   �� 5g      $,��&Enter face's template name to save it:��6   �� 5h      ��6   �� *NewTemplateFaceName+$ PropertyChanged=��� 5i      $
��Save��6   ��6(   �� *SaveNewFace+5j      5k      � 5m   
   $��1��6   $��
0,-18,0,18q�6    5n      �� 5o      $
��Auto �6    �� 5p      $
��Auto �6    �� 5q      $
��Auto �6    �� 5r      $
��Auto �6    .+�5u      �� $��0��6   $��
21,0,-21,0q�6r   ��6!   �� $	 ImagePathOfEyebrows�$ PropertyChanged=�6r   �� 5v      $��21,70,-21,46q�6a   $��3��6w   ��6   �� $	 ImagePathOfEyes�$ PropertyChanged=�6w   �� 5w      $��1��6   $��21,31,-21,42.667q�6n   $��3��6�   ��6!   �� $	 ImagePathOfNose�$ PropertyChanged=�6�   �� 5x      $��2��6   $��21,55,-21,-3.333q�6n   $��2��6�   ��6!   �� $	 ImagePathOfLips�$ PropertyChanged=�6�   5y      5z      5{      