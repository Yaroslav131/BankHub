   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	       BankHub_6._7.UserMenu   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  UserMenu��5   	   $	��960��5	   	   $	��540��5
   	   $
��1080��5   	   $
��1920��5   	   $��933.6��5   	    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 	Resources 5         NoMouseOverButtonTemplate �� 
TargetType �� Triggers P� Property P� Value	 �� Value
 �� Property ! NoMouseOverDropButtonTemplate!  BankHub_6._7.DropDownButton  WhiteTextStyle2 �� 
TargetType  ChooseButton��%.  &	        &	 (    &	 P    &	     �� 5   
   " ��5      .R�5      �� #��z��6   #��z��5      #��z��5      ._�5      �� #��z��6#   #��z��5   #   5       5      P� 5       � {�$ False��5       . �5!      �� #	 Z�5"      
 � ���� 5#      #	 Z
�5$      
 � ��5%      5'      �� 5)   
   "  5*      .R�5+      �� #��z��6   #��z��5,      #��z��5-      ._�5.      �� #��z��6#   #��z��5/   #   50       52      P� 53       � {�$ False��54      . �55      �� #	 Z�56      
 � ���� 57      #	 Z
�58      
 � ��59      5;      �� 5=   
   " ��5>      .�5?      �� 
 � ��
	 �����5@   %   �� 5A      
 � ��$	 16(�5B      6"   �� 5C      
 � ��$	 Calibri)�5D      6'   5E      �� 5G   
   " m�5H      .�5I      �� 
 � ��	 �	#FF2828285J   )   �� 5K      
 � ��
	 �   �5L   %   �� 5M      
 � ��
	 �����5N   %   �� 5O      
 � ��$	 1q�5P      6!   �� 5Q      
 � ��$	 16(�5R      6"   5S      5U      .��5W      � $��Stretch=�6   ���	#FF111111 � RowDefinitions 5Y   
   �� 5Z      $��60��6   $
��0.2* �5[      �� 5\      �� 5]      $��20 �6   .+�5`   
   � -   5         �Name$ Header��5a      $��0��5`      ���	#FF282828 � ColumnDefinitions 5c      �� 5d      $
��Auto �6#   �� 5e      �� 5f      �� 5g      �� 5h      �� 5i      �� 5j      $
��Auto �6#   .+�5l      �� -   5        $��
LogoBorder��5n      ���	#FF1D1D1D$	��0.5q�5m      ._�5q      �� -   5        $
��logo��5u      $��	10 5 10 5q�5q      $
��Left=�5r      $��Center=�5s      $��Image\ShottiteleLogo.png��5t      5u      5v        5x      -   5          Name$ AccountButton��5y   #   $��1��5x   #   $��Accounts��5z   #   ���	#FF282828
����������	#FF1D1D1D � Cursor$
 Hand��5   #   $��16(�5�   #   #��[ 5�   #   ��5{   #   �� *ActualHeight+ �� ElementName$ 
LogoButton�� �� Mode$ OneWay=�   Menu 5�      �� 5�      .@�5�      m� -   5        $��AddAccButton��5�   %   $��Add Account��5�   %   5�   %   m� 5�      -   5        $��DeleteAccButton��5�   '   $��Delete account ��5�   '   5�   '   m� 5�      -   5        $��ShowListAccCButton��5�   &   $��Accounts list ��5�   &   5�   &   m� 5�      -   5        $��CreditListButton��5�   &   $��Cedit accounts list��5�   #   5�   &   5�      5�        5�      -	   5        $ 
CardButton��5�   #   $��2��5�   #   $��Cards��5�   #   ���	#FF282828
����������	#FF1D1D1D$
 Hand��5�   #   $��16(�5�   #   #��[ 5�   #   ��5�   #   �� *ActualHeight+$ 
LogoButton��$ OneWay=� 5�      �� 5�      .@�5�      m� -
   5        $��AddCardButton��5�   %   $��Add Card��5�   %   5�   %   m� 5�      -   5        $��DeleteCardButton��5�   '   $��Delete Card ��5�   '   5�   '   m� 5�      -   5        $��ShowCardListButton��5�   #   $��Cards list ��5�   #   5�   &   5�      5�        5�      -   5        $ OpeationsButton��5�   #   $��3��5�   #   $��
Operations��5�   #   ���	#FF282828
����������	#FF1D1D1D$
 Hand��5�   #   $��16(�5�   #   #��[ 5�   #   ��5�   #   �� *ActualHeight+$ 
LogoButton��$ OneWay=� 5�      �� 5�      .@�5�      m� -   5        $��AddMoneyButton��5�   %   $��Add money to account��5�   %   ��5�   %   �� *ActualHeight+$ OpeationsButton��$ OneWay=�m� 5�      -   5        $��GetMoneyButton��5�   '   $��Get money from account��5�   '   ��5�   '   �� *ActualHeight+$ OpeationsButton��$ OneWay=�  5�      -   5        $ TransitButton��5�   /   $��Transit Money��5�   /   $
 Hand��5�   /   $��0q�5�   /   #��[ 5�   /   ��5�   /   �� *ActualHeight+$ GetMoneyButton��$ OneWay=���5�   /   �� *ActualHeight+$ GetMoneyButton��$ OneWay=���5�   /   �� *ActualHeight+$ GetMoneyButton��$ OneWay=���5�   /   �� *ActualHeight+$ GetMoneyButton��$ OneWay=���5�   /   �� *ActualHeight+$ GetMoneyButton��$ OneWay=���5�   /   �� *ActualHeight+$ GetMoneyButton��$ OneWay=� 5�      �� 5�   "   .@�5�   &   m� -   5        $��TransitInButton��5�   1   $��Transit to account��5�   1   5�   1   m� 5�   &   -   5        $��TransitOtherButton��5�   3   $��Transit to other account��5�   3   5�   3   5�   #   5�      m� 5�      -   5        $��GetCreditButton��5�   &   $��
Get credit��5�   &   ��5�   &   �� *ActualHeight+$ OpeationsButton��$ OneWay=�m� 5�      -   5        $��PayCreditButton��5�   &   $��
Pay credit��5�   &   ��5�   &   �� *ActualHeight+$ OpeationsButton��$ OneWay=�m� 5�      -   5        $��LastOperationButton��5�   &   $��Last Operation��5�   &   ��5�   &   �� *ActualHeight+$ OpeationsButton��$ OneWay=�5�      5�      �� 5�      -   5        $
��News��5�      $��4��5�      #��[  5     ���	#FF282828
����������	#FF1D1D1D$��16(�5     ��5      �� *ActualHeight+$ 
LogoBorder��$ OneWay=�.��5     ��  �� Orientation$ 
Horizontal=�6   .+�5	     �� $
��News��6    #��[ 5
      $��Center=�5      $��Center=�5      $��10q�5      5     5     �� 5     -   5        $	��Map��5     $��5��5     #��[  5     ���	#FF282828���	#FF1D1D1D
�������$��16(�5     ��5     �� *ActualHeight+$ 
LogoBorder��$ OneWay=�.��5     �� $ 
Horizontal=�6   .+�5     �� $	��Map��6    #��[ 5      $��Center=�5       $��Center=�5!      $��10q�5"      5%     5'     �� 5)     -   5        $��InfoUser��5*     $��6��5)     ���	#FF282828���	#FF1D1D1D#��[  5/     ��5,     �� *ActualHeight+$ 
LogoBorder��$ OneWay=�.��50     �� $ 
Horizontal=�6   ��51     �� *ActualHeight+$ 
LogoBorder��$ OneWay=�.+�53     �� -   5        $��UserName��54      #��[ 55      $��Center=�56      $��Center=�57      $��10q�58      �� 5:     -   5        $��	UserImage��5;     $��5 0 5 0q�5:     $��Center=�5<      �� CornerRadius$	 100��5?     ��5=     �� *ActualHeight+$
 logo����5>     �� *ActualHeight+$ 	UserImage����5B     �� 5C      �� ImageSource$ Image/UserAvatar.png��6)    j� Stretch$ UniformToFill=�5D  )   5H     5J     5L     5N     � 5P  
   -   5        $ MainContent��5P     $��1��5Q     ��5S     �� 5T     $$ Image\MainWindowBackground.jpg��6   .+�5W     ��  �� Padding$ 20q�6   5Z     5\     � 5^  
   -   5        $ Footer��5_     $��2��5^     .+�5`     �� $��30��6   
������� J� Opacity$	 0.1Q�5b     �� 5d     $��Calibri)�6   $
��Thin"�5e     $��Center=�5f     $��Center=�5g     
�������$��15(�5i     $	 0.8Q�5j     $7��1Developed by DeadLine Group. All rights reserved.��5k     5l     5p     5u     