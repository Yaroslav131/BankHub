   M S B A M L   `   `   `  ����  BankHub_6.7$    BankHub_6._7.AccountListWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  AccountListWindow��5   	   $	��500��6#   $	��500��60    � AllowsTransparency$
 True��6<    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6'   .�5      ��  � ��$ Calibri)�6+   �� 5       � ��$ Regular"�6+   �� 5       � ��
 �����6+   5      5      .��5      �� ���	#FF282828	 �� CornerRadius$	 25��5   	   ._�5   
   � .+�5       �� 
 �� Padding$
 10q�5"      $��2��6   ._�5%      �  � RowDefinitions 5&      �� 5'      $
��Auto �6(   �� 5(      $
��Auto �6(   �� 5)      �� 5*      $
��Auto �6(   .+�5,      �� $��../Image/logoSing.png��6   $��50��6;   $��50��6F   �� 5.      $��1��5/      $��Accounts list��50      $��30(�51      #��[  52      � 54      $��2��56      $��15q�57      .+�5:      &   System.Windows.Controls.DataGrid  -   5          Name$ AccountsGrid��5:   #      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5<   #   ���	#FF424242
�������$��16(�5?   #      
IsReadOnly$
 True��5@   #   5C      � 5F      $��3��5G      $�� 15 20 15  20q�5H      $��Bottom=�5I       � ColumnDefinitions 5J      �� 5K      �� 5L      .+�5O      �� $��0��5P      $��85��5Q      $
��Left=�5R      $
��Exit��5S      ���	#FF1E1E1E$��0q�5U       �� IsCancel$
 True��5V       �� 	IsDefault$
 true��5W      5Y      5[      5^      5a      5b      5c      