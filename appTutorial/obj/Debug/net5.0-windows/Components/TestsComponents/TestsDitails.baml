   M S B A M L   `   `   `  ����F  BappTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:appTutorial.ComponentsappTutorial.Components  5      )    #appTutorial.Components.TestsDitails   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:appTutorial.Components     5      .��5	      � .+�5
   
   ��    BorderPrimary#��[  6   $��1q�6>     �� CornerRadius$  5��6R    �� Padding$ 20q�6c    J� SnapsToDevicePixels$
 True��6p   ._�5      � .+�5      � ��5      �� 5       �� 
TargetType" �6    .�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;    �� Triggers 5      �� 5   "    �� Binding 6.   �� *HasSelectedTest+ �� Value	 False6R   .a�5   &   ��  � y�$ Visible=�6C   5   #   5      .+�5      �� $��32(�6    $��WrapWithOverflow=�6.   $+��%Please select a Test to see a ditails��6N   5      � 5      	 � IsSharedSizeScope$
	 True��6   ��5      �� 5      " �6    .�5      ��  � y�$ 	Collapsed=�6;    5      �� 5   "    6.   �� *HasSelectedTest+ True6R   .a�5    &   ��  � y�$ Visible=�6C   5!   #   5#      
 � RowDefinitions
 5%      �� 5&      $
��auto �6(   �� 5'      $
��auto �6(   �� 5(      $
��auto �6(   �� 5)      $
��auto �6(   .+�5-      �� $��0��6$   $��24(�6K   ��61   �� *
Testname+6K   � 50      $��1��6   $��0 20 0 0q�6,    � ColumnDefinitions 51      �� 52      $
��auto �6/    z� SharedSizeGroup$ Label��6<   �� 53      $
��auto �6/   .+�55      �� $��0��6$   $��TestDiscription ��64   $
��Bold"�6L   �� 56      $��1��6$   $��20 0 0 0q�64   ��6F   �� *TestDiscription+57      � 58      $��2��6   $��0 20 0 0q�6(    59      �� 5:      $
��auto �6/   $ Label��6<   �� 5;      $
��auto �6/   .+�5=      �� $��0��6$   $��TestTime��64   $
��Bold"�6D   �� 5>      $��1��6$   $��20 0 0 0q�64   ��6F   �� *
TestTime+5?      � 5@      $��3��6   $��0 20 0 0q�6(    5A      �� 5B      $
��auto �6/   $ Label��6<   �� 5C      $
��auto �6/   .+�5E      �� $��0��6$   $��AutorID��64   $
��Bold"�6C   �� 5F      $��1��6$   $��20 0 0 0q�64   ��6F   �� *	AutorID+5G      5H      5I      5J      5L      5M      