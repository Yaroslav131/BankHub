   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	       BankHub_6._7.MakeReport   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  
MakeReport��5   	   $	��290��5	   	   $	��450��5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value  BorderStyle  TextBoxStyle��%x  &	        &	 �     &	 �    �� 5   
   " ��5      .�5      ��  � ��$ Calibri)�5      �� 5       � ��$ Regular"�5      �� 5       � ��
 �����5      �� 5       �@��Padding$ 12 0 0 0q�5      5      �� 5!   
   " ��5"      .�5#      ��  �@��CornerRadius$ 10��5$      �� 5%       � ��
 �����5&      �� 5'       � ��$ 1q�5(      �� 5)       � ��$ 
10 0 10 10q�5*      �� 5+       �@��Padding$ 3q�5,      5-      �� 5/   
   " ��50      .�51      ��  � ��$ Center=�52      �� 53       � ��$ 16(�54      �� 55       � ��$ 0q�56      �� 57       � ��
 �����58      �� 59       �@��
CaretBrush
 �   �5:      �� 5;       �@��SelectionBrush �	#FFD70F005<      �� 5=       � ��
 ���� 5>      5A      5C      .��5E      �� ���	#FF282828	 �� CornerRadius$	 25��5F      ._�5I   
   � .+�5L      �� 
 �� Padding$
 10q�6   $��2��5M      ._�5P      �� .+�5Q      �� $��Image/SmallImageLogo.png��6   $��50��5R      $��50��5S      �� 5U       �� Padding$ 0q�6    $��Make report��5V       $��30(�5W       #��[  5X       �� 5Z      $	��15 q�6!   .+�5[      �� -   5        $��	TypeError��5\   $   $ 12 0 0 0q�5[   $   $��12(�5]   $   $��Calibri)�5^   $   $��Light"�5_   $   ���	#FFFF11235`   $   R� 5a      $��	0 0 0 10 q�6#   $��16(�5b   #   $��Calibri)�5c   #   $��Light"�5d   #   
�������.@�5f      Q� -   5        $��ReportTreeViewItem��5f   +   $��Period of repport��5g   +   .@�5h   "   Q� -   5        $	��Day��5i   /   $��For day��5h   /   5j   /   Q� 5k   "   -   5        $��Month��5l   /   $��	For month��5k   /   5m   /   Q� 5n   "   -   5        $
��Year��5o   /   $��For year��5n   /   5p   /   5q      5r      � 5t      $�� 5 60 5  10q�6   $��Bottom=�5u       � ColumnDefinitions 5v      �� 5w   "   �� 5x   "   .+�5{      �� $��0��6%   $��85��5|   %   $
��Left=�5}   %   $
��Exit��5~   %   ���	#FF1E1E1E$��0q�5�   %    �� IsCancel$
 True��5�   %   �� 5�      -   5        $��1��5�   %   $��85��5�   %   $��Right=�5�   %   ���	#FF1E1E1E$��0q�5�   %   $
��Make��5�   %    �� 	IsDefault$
 true��5�   %   5�      5�      5�      5�      5�      5�      5�      