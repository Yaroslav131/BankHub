   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	       BankHub_6._7.OfferLoan   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  	OfferLoan��5   	   $	��210��5	   	   $	��350��5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value  BorderStyle  TextBoxStyle  PasswordBoxStyle��%�  &	        &	 �     &	 �    &	 j    �� 5   
   " ��5      .�5      ��  � ��$ Calibri)�5      6'   �� 5       � ��$ Regular"�5      6'   �� 5       � ��
 �����5   )   �� 5       �@��Padding$ 	10 0 0 0 q�5      6)   5      �� 5    
   " ��5!      .�5"      ��  �@��CornerRadius$ 10��5#      �� 5$       � ��
 �����5%      �� 5&       � ��$ 1q�5'      �� 5(       � ��$ 
10 0 10 0 q�5)      �� 5*       �@��Padding$ 5q�5+      5,      �� 5.   
   " ��5/      .�50      ��  � ��$ Center=�51      �� 53       � ��$ 15(�54      �� 55       � ��$ 0q�56      �� 57       � ��
 �����58      �� 59       �@��
CaretBrush
 �   �5:      �� 5;       �@��SelectionBrush �	#FFD70F005<      �� 5=       � ��
 ���� 5>   +   5@      �� 5B   
   " G�5C      .�5D      ��  � ��$ Center=�5E      �� 5F       � ��$ 15(�5G      �� 5H       � ��$ 0q�5I      �� 5J       � ��
 �����5K      �� 5L       �@G�
CaretBrush
 �   �5M      �� 5N       �@G�SelectionBrush �	#FFD70F005O      �� 5P       � ��
 ���� 5Q   +   5S      5T      .��5V      �� 	 �� Padding$	 10q�6   ���	#FF282828
 �� CornerRadius$
 25��5X      ._�5Z   
   � .+�5[      �� .+�5\      �� $��Image/SmallImageLogo.png��6   $��50��5]      $��50��5^      6&   �� 5`      $��Not enough money ��6   $��30(�5a      $��Calibri)�5b      $��Regular"�5c      
�������5d      �� 5f      $
��Wrap=�6   $H��BYou don't have enough money on your account. Do you want get loan?��5g      $��16(�5h      $��Calibri)�5i      $��Regular"�5j      
�������5k   5   � 5o      $�� 5 20 5  15q�6   $��Bottom=�5p      ��5q      �� *ActualWidth+ �� ElementName$ PasswordBorder�� � ColumnDefinitions 5s      �� 5t      �� 5u      .+�5x      �� $��0��6   $��85��5y      $
��Left=�5z      $��No��5{      ���	#FF1E1E1E$��0q�5}       �� IsCancel$
 True��5~      �� 5�      -   5        $��1��5�      $��85��5�      $��Right=�5�      ���	#FF1E1E1E$��0q�5�      $	��Yes��5�       �� 	IsDefault$
 true��5�      5�      5�      5�      5�      5�      