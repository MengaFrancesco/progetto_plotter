   M S B A M L   `   `   `  ����J  FProgettoPlotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProgettoPlotterProgettoPlotter  5   	        ProgettoPlotter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProgettoPlotter     5   	     � Title$  Arduino Plotter��5   	   $��612.288��6!    � 
ResizeMode$ NoResize=�62   $��1033.556��6H    � WindowStartupLocation$ CenterScreen=�6Y   .��5	      � .+�5   
   ]� .+�5      o� $	��Top=�6   
�������.@�5      m� $
��File��6   $��14(�6)   .@�5      m� -   5        $	��New��5      6,   m� 5      -   5         m�Name$ MenuItemOpen��5      $
��Open��65   6C   m� 5      -   5        $ MenuItemSave��5      $
��Save��65   6C   m� 5      -   5        $��Save as��5      60   �� 5      m� 5      -   5        $��_Exit��5      6.   5      m� 5      $
��Edit��6   $��14(�6)   .@�5      m� -   5        $��Delete all lines��5      69   m� 5      -   5        $��Delete last line��5      69   m� 5      -   5        $��Delete selected line��5      6=   m� 5      -	   5        $��New line��5      61   m� 5      -
   5        $��Print canvas��5      65   5      m� 5      $
��View��6   $��14(�6)   .@�5      m� -   5        $	��Log��5      6,   m� 5       -   5        $ MenuItemShowLines��5       $��Canvas lines��6:   6P   m� 5!      -   5        $��About this project��5!      6;   5"      m� 5$      $
��Help��6   $��14(�6)   .@�5%      m� -   5        $��Function list��5%      66   m� 5&      -   5        $��How to draw lines��5&      6:   m� 5'      -   5        $��How to connect to arduino��5'      6B   m� 5(      -   5        $��About this program��5(      6;   5)      5*       � 5+      
���   ����	#FFE2E2E26'   5,      �� 5-   
   $
��Left=�6   $	��500��6,   $	��Top=�69   $	��500��6Q   
�������$��	95,73,0,0q�6p   ._�5.      �� -   5         ��Name$ PictureCanvas��5.      $
��Left=�6,   $	��500��6G   $	��Top=�6T   $	��500��6l   
������ 6�   5/      �� 52   
   $��1q�6   
���   �$��622,50,7,173q�69   ���	#FFFDFFFF._�54      �� $��0,-1,0,0q�6   .@�55      �� $��Lines��6   .��56      � ���	#FFE5E5E5.+�57      �� -   5         ��Name$ ListBoxLines��57   "   $
��Left=�68   $	��321��6S   $	��Top=�6`   $	��379��6x   58      59      �� 5:      $��Color��6   .��5;      � 
�������.+�5<      �� -   5         ��Name$ LabelColor1��5<       $��Selected color:��65   $
��Left=�6O   $��	43,16,0,0q�6j   $	��Top=�6}   $	��148��6�   $��24��6�   �� 5=      -   5         ��Name$ 
ComboColor��5=   #   $��137,16,54,283q�67   ��5>      �� 5?   "   .R�5@   &   ��  �� Orientation$ 
Horizontal=�61   .+�5A   *   �� $��16��6J   $��16��6U   $��0,2,5,2q�6a   ��64   �� *Name+6a   �� 5B   *   ��64   �� *Name+5C   '   5D   #   5F      	� 5G      -   5        	 	�Name$	 RadioButtonDefaultColor��5G   &   $�� ��6G   $
��Left=�6R   $��	24,22,0,0q�6m   $	��Top=�6�   6�   	� 5H      -   5        $	 RadioButtonCustom��5H   &   $��Custom color:��6A   $
��Left=�6Y   $	��Top=�6t   $��
74,109,0,0q�6�   6�   �� 5I      -   5        
 ��Name$
 SliderR��5I   !    �� AutoToolTipPlacement$ TopLeft=�62    �� AutoToolTipPrecision$ 0��6Q   $
��Left=�6j   $��
74,150,0,0q�6�   $	��Top=�6�   $��70��6�    � Maximum$	 255Q�6�   
�������
�������
�������6  �� 5J      -   5        $
 SliderG��5J   !   $ TopLeft=�62   $ 0��6Q   $
��Left=�6j   $��155,150,0,0q�6�   $	��Top=�6�   $��70��6�   $	 255Q�6�   
�������6�   �� 5K      -   5        $
 SliderB��5K   !   $ TopLeft=�62   $ 0��6Q   $
��Left=�6j   $��235,150,0,0q�6�   $	��Top=�6�   $��70��6�   $	 255Q�6�   
�������6�   �� 5L      $
��Left=�6$   $��
74,173,0,0q�6?   $
��Wrap=�6S   $��R:��6g   $	��Top=�6q   �� 5M      -   5         ��Name$ TextR��5M   $   $
��Left=�63   $��114,173,0,0q�6N   $
��Wrap=�6c   $��0��6w   $	��Top=�6�   $��30��6�   �� 5N      $
��Left=�6$   $��156,173,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   �� 6�   $�G��6�   �� 6�   $�:��6�   6�   �� 5O      -   5        $ TextG��5O   $   $
��Left=�63   $��195,173,0,0q�6N   $
��Wrap=�6c   $��0��6w   $	��Top=�6�   $��30��6�   �� 5P      $
��Left=�6$   $��236,173,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   �� 6�   $�B��6�   �� 6�   $�:��6�   6�   �� 5Q      -   5        $ TextB��5Q   $   $
��Left=�63   $��275,173,0,0q�6N   $
��Wrap=�6c   $��0��6w   $	��Top=�6�   $��30��6�   5R      5S      �� 5T      $��Shape��6   .��5U      � 
�������.+�5V      	� -   5        $	 RadioButtonPen_copy��5V   &   $��Straight line��6C   $
��Left=�6[   $	��Top=�6v   $��5,10,0,0q�6�   6�   	� 5W      -   5        $	 RadioButtonRuler_copy��5W   &   $��Parallel Line��6E   $
��Left=�6]   $	��Top=�6x   $��5,50,0,0q�6�   6�   	� 5X      -    5        $	 RadioButtonRectangle_copy��5X   &   $��	Rectangle��6I   $
��Left=�6]   $	��Top=�6x   $��5,88,0,0q�6�   6�   	� 5Y      -!   5        $	 RadioButtonTriangle_copy��5Y   &   $��Triangle��6H   $
��Left=�6[   $	��Top=�6v   $��	5,121,0,0q�6�   6�    � 5Z      $�� ��6    $��1q�6+   
�������$
��Left=�6S   $��31��6n   $��	91,41,0,0q�6z   $	��Top=�6�   $	��300��6�   
���   �6�   	� 5[      -"   5        $	 RadioButtonUpDown��5[   &   $��Up-Down��6A   $
��Left=�6S   $��	95,50,0,0q�6n   $	��Top=�6�    	� 	GroupName$ Parallel��6�   	� 5\      -#   5        $	 RadioButtonLeftRight��5\   &   $��
Left-Right��6D   $
��Left=�6Y   $��
170,50,0,0q�6t   $	��Top=�6�   $ Parallel��6�   	� 5]      -$   5        $	 RadioButtonUpLeft��5]   &   $��Up-Left��6A   $
��Left=�6S   $��
247,50,0,0q�6n   $	��Top=�6�   $ Parallel��6�   	� 5^      -%   5        $	 RadioButtonUpRight��5^   &   $��Up-Right��6B   $
��Left=�6U   $��
311,50,0,0q�6p   $	��Top=�6�   $ Parallel��6�    � 5_      $�� ��6    $��1q�6+   
�������$
��Left=�6S   $��32��6n   $��
91,112,0,0q�6z   $	��Top=�6�   $	��300��6�   
���   �6�   	� 5`      -&   5        $	 RadioButtonRightTriangle��5`   &   $��Right Triangle��6H   $
��Left=�6a   $��110,121,0,0q�6|   $	��Top=�6�   $ Triangle��6�   	� 5a      -'   5        $"	 RadioButtonIsoscelesTriangle��5a   &   $��Isoscelis Triangle��6L   $
��Left=�6i   $��254,121,0,0q�6�   $	��Top=�6�   $ Triangle��6�   5b      5c      �� 5d      $��Canvas��6   .��5e      � 
�������.+�5f      �� -(   5         ��Name$ CheckBoxRules��5f   #   $��
Show ruler��6:   $
��Left=�6O   $��	10,10,0,0q�6j   $	��Top=�6}   $	��140��6�   $��16(�6�   �� 5g      $��	Show grid��6#   $
��Left=�67   $	��Top=�6R   $��	10,35,0,0q�6j   $��16(�6}   $	��140��6�   5h      5i      5j      5l      �� 5m   
   -)   5         ��Name$ ImageNewFile��5m      $
��Left=�6&   $��25��6A   $��5,23,0,0q�6M   $	��Top=�6_   $��25��6w   $��Images/NewFile.ico��6�   6�   �� 5n   
   -*   5        $ 
ImageRule1��5n      $
��Left=�6$   $��26��6?   $��	95,53,0,0q�6K   $	��Top=�6^   $	��500��6v   $��Images/ruler1.png��6�   �� 5o   
   -+   5        $ 
ImageRule2��5o      $
��Left=�6$   $	��500��6?   $��
595,73,0,0q�6L   $	��Top=�6`   $��27��6x   $��Images/ruler2.png��6�   �� 5p   
   
���   �
�������$��1q�68   $
��Left=�6L   $	��500��6g   $��2,73,0,0q�6t   $	��Top=�6�   $��86��6�   �� 5q   
   
���   �$��1q�6%   $
��Left=�69   $	��156��6T   $��622,415,0,0q�6a   $	��Top=�6v   $	��389��6�   
�������6�   �� 5r   
   $
��Left=�6   $��47��6+   $	��Top=�67   $��47��6O   $��	34,90,0,0q�6Z   $��Images/PenIcon.png��6m   	� 5s   
   -,   5        $	 RadioButtonRuler��5s      $��RadioButton��60   $
��Left=�6F   $��
14,159,0,0q�6a   $	��Top=�6u   $��15��6�   $��47��6�   $��Center=�6�   6�   �� 5t   
   $
��Left=�6   $��47��6+   $	��Top=�67   $��47��6O   $��
34,159,0,0q�6Z   $��Images/Ruler.png��6n   	� 5u   
   --   5        $	 RadioButtonPen��5u      $�� ��6.   $
��Left=�69   $��	14,90,0,0q�6T   $	��Top=�6g   $��47��6   $��Center=�6�   6�   	� 5v   
   -.   5        $	 RadioButtonRectangle��5v      $��RadioButton��64   $
��Left=�6J   $	��Top=�6e   $��Center=�6}   $��
14,227,0,0q�6�   $��16��6�   $��47��6�   6�   �� 5w   
   $
��Left=�6   $��47��6+   $��
35,227,0,0q�67   $	��Top=�6K   $��47��6c   $��Images/Rectangle.ico��6n   	� 5x   
   -/   5        $	 RadioButtonTriangle��5x      $��RadioButton��63   $
��Left=�6I   $��
14,302,0,0q�6d   $	��Top=�6x   $��Center=�6�   $��16��6�   $��47��6�   6�   �� 5y   
   $
��Left=�6   $��47��6+   $��
35,302,0,0q�67   $	��Top=�6K   $��47��6c   $��Images/Triangle.png��6n   �� 5z   
   
���   �
�������$��1q�69   $
��Left=�6M   $��20��6h   $��2,54,0,0q�6t   $	��Top=�6�   $��86��6�   �� 5{   
   -0   5        $ ImageOpenFile��5{      $
��Left=�6'   $��25��6B   $��	45,23,0,0q�6N   $	��Top=�6a   $��25��6y   $��Images/OpenFile.png��6�   6�   �� 5|   
   -1   5        $ ImageSaveFile��5|      $
��Left=�6'   $��25��6B   $��	85,23,0,0q�6N   $	��Top=�6a   $��25��6y   $��Images/SaveFile.png��6�   $
��Fill=�6�   6�   �� 5}   
   -2   5        $ ImageDeleteFile��5}      $
��Left=�6)   $��25��6D   $��
124,23,0,0q�6P   $	��Top=�6d   $��25��6|   $��Images/CloseFile.png��6�   6�   �� 5~   
   -3   5        $ 
ImagePrint��5~      $
��Left=�6$   $��25��6?   $��
164,23,0,0q�6K   $	��Top=�6_   $��25��6w   $��Images/PrintFile.ico��6�   �� 5   
   -4   5        $ 	ImageUndo��5      $
��Left=�6#   $��25��6>   $��
204,23,0,0q�6J   $	��Top=�6^   $��25��6v   $��Images/Undo.png��6�   6�   �� 5�   
   -5   5        $ ImageDeleteAll��5�      $
��Left=�6(   $��25��6C   $��
244,23,0,0q�6O   $	��Top=�6c   $��25��6{   $��Images/Delete.png��6�   6�   �� 5�   
   -6   5        $ ImageDeleteAt��5�      $
��Left=�6'   $��25��6B   $��
284,23,0,0q�6N   $	��Top=�6b   $��25��6z   $��Images/DeleteSelected.png��6�   6�   �� 5�   
   $
��Left=�6   $��	49,56,0,0q�6/   $
��Wrap=�6B   $��Y:��6V   $	��Top=�6`   �� 5�   
   $
��Left=�6   $��5,56,0,0q�6/   $
��Wrap=�6A   $��X:��6U   $	��Top=�6_   $��16��6w   �� 5�   
   -7   5        $ 
TextBlockY��5�      $
��Left=�6(   $��	60,56,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��25��6�   ���	#FFE8E6E66�   �� 5�   
   -8   5        $ 
TextBlockX��5�      $
��Left=�6(   $��	17,56,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��25��6�   ���	#FFE8E6E66�   �� 5�   
   -9   5         ��Name$ ButtonConnect��5�      $��Connect��6(   $
��Left=�6:   $��901,460,0,0q�6U   $	��Top=�6j   $��91��6�   $��29��6�   6�   �� 5�   
   -:   5        $ ComboBoxCOM��5�      $
��Left=�6(   $��767,460,0,0q�6C   $	��Top=�6X   $	��116��6p   $��29��6|   �� 5�   
   -;   5        $ LabelCom��5�      $��Selected Port:��6"   $
��Left=�6;   $��646,460,0,0q�6V   $	��Top=�6k   $��29��6�   $	��104��6�   5�      5�      