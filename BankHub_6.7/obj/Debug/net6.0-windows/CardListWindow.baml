   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	   !    BankHub_6._7.CardListWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  CardListWindow��5   	   $	��500��5	   	   $
��1100��5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value 
 DStyle&   System.Windows.Controls.DataGrid��%�   &	        &	 �     �� 5   
   " ��5      .�5      ��  � ��$ Calibri)�5      6'   �� 5       � ��$ Regular"�5      6'   �� 5       � ��
 �����5   )   5      �� 5   
   "  5      5"      5'      .��5)      �� ���	#FF282828	 �� CornerRadius$	 25��5*      ._�5-   
   � .+�50      �� 
 �� Padding$
 10q�6   $��2��51      ._�54      �  � RowDefinitions 55      �� 56      $
��Auto �6(   �� 57      $
��Auto �6(   �� 58      �� 59      $
��Auto �6(   .+�5;      �� $��Image/SmallImagelogo.png��6   $��50��5<      $��50��5=      6*   �� 5>      $��1��6    $��
Cards list��5?       $��30(�5@       #��[  5A       � 5C      $��2��6   $��15q�5D      .+�5I        -   5          Name$ 	CardsGrid��5I   #      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5K   #   ���	#FF424242
�������$��16(�5N   #      
IsReadOnly$
 True��5O   #   5Q      5T      � 5W      $��3��6   $�� 15 20 15  20q�5X      $��Bottom=�5Y       � ColumnDefinitions 5Z      �� 5[      �� 5\      .+�5_      �� $��0��6!   $��85��5`   !   $
��Left=�5a   !   $
��Exit��5b   !   ���	#FF1E1E1E$��0q�5d   !    �� IsCancel$
 True��5e   !    �� 	IsDefault$
 true��5f   !   �� 5h      -   5         ��Name$ ShowPassword��5h   !   $��1��5i   !   $	��120��5j   !   $��12(�5k   !   $��Right=�5l   !   $��Show password��5m   !   ���	#FF1E1E1E$��0q�5o   !   $��
0,0,-0.4,0q�5q   !   $	��Top=�5r   !   5t      5w      5|      5�      5�      5�      