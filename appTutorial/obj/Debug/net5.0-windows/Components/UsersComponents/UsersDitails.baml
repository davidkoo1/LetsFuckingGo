   M S B A M L   `   `   `  ����F  BappTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:appTutorial.ComponentsappTutorial.Components  5      )    #appTutorial.Components.UsersDitails   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:appTutorial.Components     5      .��5	      � .+�5
   
   ��    BorderPrimary#��[  6   $��1q�6>     �� CornerRadius$  5��6R    �� Padding$ 20q�6c    J� SnapsToDevicePixels$
 True��6p   ._�5      � .+�5      � ��5      �� 5       �� 
TargetType" �6    .�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;    �� Triggers 5      �� 5   "    �� Binding 6.   �� *HasSelectedUser+ �� Value	 False6R   .a�5   &   ��  � y�$ Visible=�6C   5   #   5      .+�5      �� $��32(�6    $��WrapWithOverflow=�6.   $+��%Please select a User to see a ditails��6N   5      � 5      	 � IsSharedSizeScope$
	 True��6   ��5      �� 5      " �6    .�5      ��  � y�$ 	Collapsed=�6;    5      �� 5   "    6.   �� *HasSelectedUser+ True6R   .a�5    &   ��  � y�$ Visible=�6C   5!   #   5#      
 � RowDefinitions
 5%      �� 5&      $
��auto �6(   �� 5'      $
��auto �6(   �� 5(      $
��auto �6(   �� 5)      $
��auto �6(   �� 5*      $
��Auto �6(   .+�5-      � $��0��6    � ColumnDefinitions 5.      �� 5/      $
��auto �6/   �� 50      $
��auto �6/   .+�52      �� $��0��6$   $��24(�6N   ��64   �� *
Username+6N   A� 53      $��1��6"   $��10��62   $��10��6=   ��6I   �� *IsOnlineColor+54      � 57      $��1��6   $��0 20 0 0q�6(    58      �� 59      $
��auto �6/    z� SharedSizeGroup$ Label��6<   �� 5:      $
��auto �6/   �� 5;      $
��auto �6/   .+�5=      �� $��0��6$   $��	FullName ��64   $
��Bold"�6E   �� 5>      $��1��6$   $��20 0 0 0q�64   ��6F   �� *
Username+�� 5?      $��2��6$   $��5 0 0 0q�64   ��6E   �� *UserSurname+5@      � 5A      $��2��6   $��0 20 0 0q�6(    5B      �� 5C      $
��auto �6/   $ Label��6<   �� 5D      $
��auto �6/   .+�5F      �� $��0��6$   $��LogIn��64   $
��Bold"�6A   �� 5G      $��1��6$   $��20 0 0 0q�64   ��6F   �� *	UserLogin+5H      � 5I      $��3��6   $��0 20 0 0q�6(    5J      �� 5K      $
��auto �6/   $ Label��6<   �� 5L      $
��auto �6/   .+�5N      �� $��0��6$   $��Password��64   $
��Bold"�6D   �� 5O      $��1��6$   $��20 0 0 0q�64   ��6F   �� *UserPassword+5P      � 5Q      $��4��6   $��0 20 0 0q�6(    5R      �� 5S      $
��auto �6/   $ Label��6<   �� 5T      $
��auto �6/   .+�5V      �� $��0��6$   $��Standing��64   $
��Bold"�6D   �� 5W      $��1��6$   $��20 0 0 0q�64   ��6F   �� *UserStanding+5X      5Y      5Z      5[      5]      5^      