   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	        BankHub_6._7.CreditAccList   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  CreditAccList��5   	   $	��500��5	   	   $	��950��5
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
��Auto �6(   .+�5;      �� $��Image/SmallImageLogo.png��6   $��50��5<      $��50��5=      6*   �� 5?      $��1��6    $��Credit list��5@       $��30(�5A       #��[  5B       � 5D      $��2��6   $��15q�5E      .+�5J        -   5          Name$ AccountsGrid��5J   #      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5L   #   ���	#FF424242
�������$��16(�5O   #      
IsReadOnly$
 True��5P   #   5R      5U      � 5X      $��3��6   $�� 15 20 15  20q�5Y      $��Bottom=�5Z       � ColumnDefinitions 5[      �� 5\      �� 5]      .+�5`      �� $��0��6!   $��85��5a   !   $
��Left=�5b   !   $
��Exit��5c   !   ���	#FF1E1E1E$��0q�5e   !    �� IsCancel$
 True��5f   !    �� 	IsDefault$
 true��5g   !   5i      5l      5q      5u      5v      5w      