   M S B A M L   `   `   `  ����F  BBankHub_6.7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BankHub_6._7BankHub_6._7  5   	       BankHub_6._7.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BankHub_6._7     5   	     � Title$  BankHub��5	   	   $	��960��5
   	   $	��540��5   	   $
��1080��5   	   $
��1920��5   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value   BlockBorder  DropButt  	BlockGrid��%�  '        &	  �     &	 Y    &	 1    �� 5   
   "  6   .�5      ��  � ��$ 15 0 0 0q�5      �� 5       � ��
 �����5      �� 5       � �� �	#00FAFAFA5      5      �� 5   
   " ��5      .�5      ��  � ��
 �����5      �� 5       � ��
 �����5       �� 5!       �@J�Opacity$	 0.5Q�5"      5#      �� 5%   
   " ��5&      .�5'      ��  � �� �	#FF1E1E1E5(      �� 5)       � ��$	 100��5*      �� 5+       � ��$ 1q�5,      �� 5-       � �� �	#FF1D1D1D5.      5/      �� 51   
   " �52      .�53      ��  � ��$	 15 q�54      55      56      .��57      � ���	#FF111111 � RowDefinitions 58   
   �� 59      $��60��6   $��2* �5:      �� 5;      �� 5<      $��20��6   .+�5?   
   � -   5        	 �Name$	 Header��5@      $��0��5?      
 � ColumnDefinitions
 5A      �� 5B      �� 5C      .+�5F      �� $��0��6   $��2��5G      
������� J� Opacity$	 0.1Q�5I      �� 5K      $��0��6   $��10 5 0 5q�5L      $
��Left=�5M      $��Center=�5N      $��Image/ShotTiteleLogo.png��5O      !  BankHub_6._7.DropDownButton  5Q      -   5          Name$ DropDownButtonUser��5W   $   $��1��5Q   $   $��Right=�5R   $   $��0q�5S   $    � Cursor$
 Hand��5V   $   ��5T   $   �� *ActualHeight+ �� ElementName$ 
LogoButton�� �� Mode$ OneWay=���5U   $   �� *ActualHeight+$ DropDownButtonUser����5Z      �� 5[       �� ImageSource$ /Image/UserAvatar.png��6!      Menu 5`      �� 5a      .@�5b      m� -   5        $��SignInButton��5e   %   $��Sign In��5b   %   5e   %   m� 5g      -   5        $��SignUpButton��5j   '   $��Sign Up��5g   '   5j   '   m� 5l      -   5        $
��Exit��5l   '   5m   '   5o      5q      5�      � 5�   
   -   5        $	 MainContent��5�      $��1��5�      ��5�      �� 5�      $? 9D:\BankHub_6.0\BankHub_6.0\Image\MainWindowBackground.jpg��6   .+�5�      ��  �� Padding$ 20q�6   ._�5�      � -   5        $��ContentGrid��5�      
 5�      �� 5�      �� 5�      .+�5�      � $��0��6   $��0��5�       5�      �� 5�      �� 5�      $
��0.8* �6,   .+�5�      � -   5        $	 
FirstBlock��5�      $��0��5�      #��[ 5�      .+�5�      �� #��[  6%   ���	#FF2828285�   %   5�      � 5�      -	   5        $	 
FoursBlock��5�      $��1��5�      #��[ 5�      ��5�      �� 5�   "   $ Image/info-panel.jpg��6-   5�      5�      � 5�      -
   5        $	 RightTopBlock��5�      $��1��5�      #��[ 5�      5�      5�      5�      5�      � 5�   
   -   5        $	 Footer��5�      $��2��5�      .+�5�      �� $��30��6   
�������$	 0.1Q�5�      �� 5�      $��Calibri)�6   $
��Thin"�5�      $��Center=�5�      $��Center=�5�      
�������$��15(�5�      $	 0.8Q�5�      $7��1Developed by DeadLine Group. All rights reserved.��5�      5�      5�      5�      