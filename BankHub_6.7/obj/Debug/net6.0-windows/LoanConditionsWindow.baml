   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	   '    !BankHub_6._7.LoanConditionsWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  LoanConditionsWindow��5   	   $	��380��5	   	   $	��500��5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value  BorderStyle  TextBoxStyle  PasswordBoxStyle��%�  &	        &	 �     &	 �    &	 f    �� 5   
   " ��5      .�5      ��  �@��Padding$ 12 0 0 0q�5      6(   �� 5       � ��$ Calibri)�5      6'   �� 5       � ��$ Regular"�5      6'   �� 5       � ��
 �����5   )   5      �� 5!   
   " ��5"      .�5#      ��  �@��CornerRadius$ 10��5$      �� 5%       � ��
 �����5&      �� 5'       � ��$ 1q�5(      �� 5)       � ��$ 10q�5*      �� 5+       �@��Padding$ 3q�5,      6!   5-      �� 5/   
   " ��50      .�51      ��  � ��$ Center=�52      �� 53       � ��$ 16(�54      �� 55       � ��$ 0q�56      �� 57       � ��
 �����58      �� 59       �@��
CaretBrush
 �   �5:      �� 5;       �@��SelectionBrush �	#FFD70F005<      �� 5=       � ��
 ���� 5>   +   5A      �� 5C   
   " G�5D      .�5E      ��  � ��$ Center=�5F      �� 5G       � ��$ 16(�5H      �� 5I       � ��$ 0q�5J      �� 5K       � ��
 �����5L      �� 5M       �@G�
CaretBrush
 �   �5N      �� 5O       �@G�SelectionBrush �	#FFD70F005P      �� 5Q       � ��
 ���� 5R   +   5U      5W      .��5Y      �� 	 �� CornerRadius$	 25��6   ���	#FF282828._�5[   
   � .+�5^      �� 
 �� Padding$
 10q�6   ._�5a      �� -   5        $��NumberStackPanel��5a      .+�5b      �� $��Image/SmallImageLogo.png��6   $��50��5c      $��50��5d      6*   �� 5f      $��Loan Condition��6    $��30(�5g       #��[  5h       �� 5j      $��15q�6!   .+�5k      �� $
��Wrap=�6$   $��20(�5l   $   #��[  5m   $   �� 6M   $���Get acquainted with the terms of the loan. You can borrow for 1 to 120 months (10 years), the amount of the loan is limited to $��6Q   �� 6�   $� ��6�   �� 6�   $���1,000,000. If the loan is not paid, your card will be blocked and you will have to report to the bank for clarification. If you don't show up, we'll have to sue you.��6�   6�  	� 5q      -   5        $��Accept��5x   '   $��16(�5q   '   
�������
�������
�������$
��Left=�5u   '   $	�� 15q�5v   '   $��I accept the terms��5w   '   5y   '   � 5|      $��0 15 0 0q�6   $��Bottom=�5}       � ColumnDefinitions 5~      �� 5   "   �� 5�   "   .+�5�      �� $��0��6%   $��85��5�   %   $
��Left=�5�   %   $
��Exit��5�   %   ���	#FF1E1E1E$��0q�5�   %    �� IsCancel$
 True��5�   %   �� 5�      -   5        $��Continue��5�   %   $��1��5�   %   $��85��5�   %   $��Right=�5�   %   ���	#FF1E1E1E$��0q�5�   %   $��12(�5�   %   $��Continue��5�   %    J� Opacity$	 0.5Q�5�   %   5�      5�      5�      5�      5�      5�      5�      