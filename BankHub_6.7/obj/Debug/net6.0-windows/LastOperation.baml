   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	        BankHub_6._7.LastOperation   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  LastOperation��5   	   $	��500��5	   	   $	��500��5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��5      .�5      ��  � ��$ Calibri)�5      �� 5       � ��$ Regular"�5      �� 5       � ��
 �����5      5      5      .��5       �� ���	#FF282828	 �� CornerRadius$	 25��5!      ._�5$   
   � .+�5'      �� 
 �� Padding$
 10q�6   $��2��5(      ._�5+      �  � RowDefinitions 5,      �� 5-      $
��Auto �6(   �� 5.      $
��Auto �6(   �� 5/      �� 50      $
��Auto �6(   .+�52      �� $��Image/SmallImageLogo.png��6   $��50��53      $��50��54      �� 56      $��1��6    $��Last opetation list��57       $��30(�58       #��[  59       �� 5=      -   5         ��Name$ OperationList��5=      $��15q�5>      $��2��5?      ��5@      �� ��5A      �� 5B      .R�5C   "   �� .+�5D   &   �� 
�������$��Regular"�5F   0   $��Calibri)�5G   0   $��20(�5H   0   ��5D   0   �� *Type+5H   0   �� 5I   &   
�������$��Regular"�5K   0   $��Calibri)�5L   0   $��16(�5M   0   ��5I   0   �� *Time+5M   0   5O   #   5P      5R      � 5W      $��3��6   $�� 15 20 15  20q�5X      $��Bottom=�5Y       � ColumnDefinitions 5Z      �� 5[      �� 5\      .+�5_      �� $��0��6!   $��85��5`   !   $
��Left=�5a   !   $
��Exit��5b   !   ���	#FF1E1E1E$��0q�5d   !    �� IsCancel$
 True��5e   !    �� 	IsDefault$
 true��5f   !   �� 5i      -   5        $��1��5i   !   $	��110��5j   !   $��Right=�5k   !   $��Make report��5l   !   ���	#FF1E1E1E$��0q�5n   !   5o   !   5p      5r      5u      5x      5y      5z      