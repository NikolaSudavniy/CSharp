   M S B A M L   `   `   `  ����F  BImageEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ImageEditor.ViewModelImageEditor.ViewModel  5   	       ImageEditor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ImageEditor.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5
      )   #ImageEditor.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ CurImage��5   >   $��0��6   $��2��6   $��0��6.   $
��Fill=�5       J� RenderTransformOrigin$ 0.5,0.5&�5      ��5      ��  �� Path$ ImageForEditing� �� UpdateSourceTrigger$ PropertyChanged=���5      �� $ ImageHeight�$ PropertyChanged=���5      �� $ 
ImageWidth�$ PropertyChanged=�z�5      V� 5      .~�5       ��  �� Angle 6&   �� $ ImageRotate�$ PropertyChanged=��� 5!      	 �� AngleX	 6$   �� $ ImageXaxisTilt�$ PropertyChanged=�
 �� AngleY
 5"   $   �� $ ImageYaxisTilt�$ PropertyChanged=�T� 5#       T� X 6)   �� $ ImageXaxisShift�$ PropertyChanged=� T� Y 5$   )   �� $ ImageYaxisShift�$ PropertyChanged=�5%      5'      9� 5)   
   $��0��6   $��1��6    $��Pictures��60   .��5*      �� $
��Left=�6   $	��100��66   .��5+      �� .+�5,      	� -   5         	�Name$ Image1��5,   "    	� 	GroupName$ Images��62   $��1��6E   $��0��6Q   ��6f   �� *
SetImage+	� 5-      -   5        $ Image2��5-   "   $ Images��62   $��2��6E   $��1��6Q   ��6f   �� *
SetImage+	� 5.      -   5        $ Image3��5.   "   $ Images��62   $��3��6E   $��2��6Q   ��6f   �� *
SetImage+	� 5/      -   5        $ Image4��5/   "   $ Images��62   $��4��6E   $��3��6Q   ��6f   �� *
SetImage+	� 50      -   5        $ Image5��50   "   $ Images��62   $��5��6E   $��4��6Q   ��6f   �� *
SetImage+	� 51      -   5        $ Image6��51   "   $ Images��62   $��6��6E   $��5��6Q   ��6f   �� *
SetImage+52      53      54      9� 55   
   $��1��6   $��1��6    $��Options��60   .��56      �� $
��Left=�6   $	��100��66   .��57      �� .+�58      �� $��Height��6    �� 59      -   5         ��Name$ ResizingByHeight��59       � Minimum$	 100Q�67    � Maximum$
 1000Q�6E    � Value 5:      �� $ ResizingByHeight�$ PropertyChanged=��� 5;      $��Width��6    �� 5<      -	   5        $ ResizingByWidth��5<      $	 100Q�66   $
 1000Q�6D    5=      �� $ ResizingByWidth�$ PropertyChanged=��� 5>      $��X-axis shift��6    �� 5?      -
   5        $ 
XaxisShift��5?      $ 0Q�61   $	 300Q�6=    5@      �� $ 
XaxisShift�$ PropertyChanged=��� 5A      $��Y-axis shift��6    �� 5B      -   5        $ 
YaxisShift��5B      $ 0Q�61   $	 300Q�6=    5C      �� $ 
YaxisShift�$ PropertyChanged=��� 5D      $��X-axis tilt��6    �� 5E      -   5        $ 	XaxisTilt��5E      $ 0Q�60   $ 50Q�6<    5F      �� $ 	XaxisTilt�$ PropertyChanged=��� 5G      $��Y-axis tilt��6    �� 5H      -   5        $ 	YaxisTilt��5H      $ 0Q�60   $ 50Q�6<    5I      �� $ 	YaxisTilt�$ PropertyChanged=��� 5J      $��Rotation��6    �� 5K      -   5        $ Rotate��5K      $ 0Q�6-   $	 360Q�69    5L      �� $ Rotate�$ PropertyChanged=�5M      5N      5O      5Q      5R      