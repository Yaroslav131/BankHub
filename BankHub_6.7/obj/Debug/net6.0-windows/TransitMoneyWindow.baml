   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	   %    BankHub_6._7.TransitMoneyWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  TransitMoneyWindow��5   	   $	��400��5	   	   $	��500��5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value  BorderStyle  TextBoxStyle  ComboBoxTest2	 �� 
TargetType
 d� 	IsChecked �� Path �� Mode �� RelativeSource � ColumnDefinitions ��Name �� CornerRadius F�Name �� Triggers P� Property P� Value �� 
TargetName J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth  �� MaxDropDownHeight! K� IsItemsHost" �� Triggers��%	
  &	        &	 �     &	 �    &	 [    �� 5   
   " ��5      .�5      ��  �@��Padding$ 12 0 0 0q�5      �� 5       � ��$ Calibri)�5      �� 5       � ��$ Regular"�5      �� 5       � ��
 �����5      5      �� 5!   
   " ��5"      .�5#      ��  �@��CornerRadius$ 10��5$      �� 5%       � ��
 �����5&      �� 5'       � ��$ 1q�5(      �� 5)       � ��$ 10 0 10 10 q�5*      �� 5+       �@��Padding$ 3q�5,      5-      �� 5/   
   " ��50      .�51      ��  � ��$ Center=�52      �� 53       � ��$ 16(�54      �� 55       � ��$ 0q�56      �� 57       � ��
 �����58      �� 59       �@��
CaretBrush
 �   �5:      �� 5;       �@��SelectionBrush �	#FFD70F005<      �� 5=       � ��
 ���� 5>      5A      �� 5C   
   " ��5D      .�5E      ��  � �� 5F      �� 5G      "	 ��6&   .R�5H      � .+�5I      d� $��2��6+   $|�false��5J   +   
 5K   +   �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+��5L   "   �� 5M   &   .R�5N   *   �  5O   .   �� 5P   2   $��5* �6C   �� 5Q   2   $��* �6C   .+�5S   .   �� $ Border��65   $��2��5T   5   $ 10��5U   5   
�������
�������$��1q�5X   5   �� 5Y   .   $��0��65   $ 	10,0,0,10��5Z   5   $��1q�5[   5   ���	#FF282828
�������$��0,0,1,0q�5^   5   F� 5_   .   $ Arrow��63   $��1��5`   3   ���	#FFFF1123$��Center=�5b   3   $��Center=�5c   3   "����        � 	=  	= � z     	5d   3   5e   +    5f   *   P� 5g   .    �@J�IsMouseOver$
 true��5h   6   . �5i   2   �� $ Border��69    � �� �	#FF1E1E1E5k   9   5l   /   P� 5m   .    �@d�	IsChecked$
 trueY�5n   6   . �5o   2   �� $ Border��69    � �� �	#FF1E1E1E5q   9   5r   /   5t   '   5v      �� 5w      $��ContentSite��6/   $ False��5x   /   #��z 5y   /   #��z 5z   /   #��z��5{   /   $��3q�5|   /   �� 5}      $ PART_EditableTextBox��6&   $y�Hidden=�5~   &   # z 5   &   � 5�      $��Popup��6$   $��Bottom=�5�   $   #��z 5�   $   $
 True��5�   $   $|�False��5�   $   $��Slide=�5�   $   .��5�   "   � $��DropDown��6(   $
 True��5�   (   #��z 5�   (   #��z  5�   (   .+�5�   &   �� $ DropDownBorder��6-   ���	#FF2828285�   -   �� 5�   &   $
 True��63   .��5�   *   �� $
! True��65   5�   '   5�   #   5�      5�      5�      5�      " 5�      5�      5�      .��5�      �� ���	#FF282828$ 25��5�      ._�5�   
   � .+�5�      �� # �� Padding$# 10q�6   ._�5�      �� -   5        $��NumberStackPanel��5�      .+�5�      �� $��Image/SmallImageLogo.png��6   $��50��5�      $��50��5�      �� 5�      $ �� Padding$$ 0q�6    $��Transit Money��5�       $��30(�5�       #��[  5�       �� 5�      $	��15 q�6!   .+�5�      �� $��Account name��6$   $��16(�5�   $   #��[  5�   $   �� 5�      -   5        $��AccError��5�   $   $$ 12 0 0 0q�5�   $   $��12(�5�   $   $��Calibri)�5�   $   $��Light"�5�   $   ���	#FFFF11235�   $   � 5�       5�      �� 5�   "   �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� $��0��6)   $��2��5�   )   .+�5�   "   �� -   5        $��accList��5�   +   $��
10 0 10 10q�5�   +   #��[ 5�   +   $��16(�5�   +   
�������5�   #   5�      5�      �� 5�      $��Recipient account name��6$   $��16(�5�   $   #��[  5�   $   �� 5�      -   5        $��AccRecListError��5�   $   $$ 12 0 0 0q�5�   $   $��12(�5�   $   $��Calibri)�5�   $   $��Light"�5�   $   ���	#FFFF11235�   $   � 5�       5�      �� 5�   "   �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� $��0��6)   $��2��5�   )   .+�5�   "   �� -   5        $��
AccRecList��5�   +   $��
10 0 10 10q�5�   +   #��[ 5�   +   $��16(�5�   +   
�������5�   #   5�      5�      � 5�       5�      �� 5�   "   �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� $��0��6)   $��2��5�   )   .+�5�   "   �� $��Money��6,   $��16(�5   ,   #��[  5  ,   �� 5  "   -   5        $��
MoneyError��5  ,   $$ 12 0 0 0q�5  ,   $��12(�5  ,   $��Calibri)�5  ,   $��Light"�5  ,   ���	#FFFF11235	  ,   �� 5
  "   #��[ 6)   ._�5  &   �� -   5        $��Money��5  .   #��[ 5  .   5  #   5     5     � 5     $�� 5 20 5  10q�6   $��Bottom=�5      5     �� 5  "   �� 5  "   .+�5     �� $��0��6%   $��85��5  %   $
��Left=�5  %   $
��Exit��5  %   ���	#FF1E1E1E$��0q�5  %   % �� IsCancel$
% True��5   %   �� 5"     -   5        $��TransitButton��5$  %   $��1��5"  %   $��85��5#  %   $��Right=�5%  %   ���	#FF1E1E1E$��0q�5'  %   $��Transit��5(  %   & �� 	IsDefault$
& true��5*  %   5+     5.     51     54     57     59     5:     