   M S B A M L   `   `   `  ����F  BappTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:appTutorial.ComponentsappTutorial.Components  5      N JDropdownMenuControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:DropdownMenuControl;assembly=DropdownMenuControlDropdownMenuControl 5      ,    &appTutorial.Components.UserListingItem   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:appTutorial.Components     5      Qcustom>clr-namespace:DropdownMenuControl;assembly=DropdownMenuControl     5      .��5
      ��   �� Padding$
  5 10q�6   $��16(�6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   ��6(   �� *
Username+&   DropdownMenuControl.DropdownMenu  5      -   5          Name$ dropDown��5   "   $��1��64   $��10 0 0 0q�6D   .��5      �� 
�������
�������$��1q�6?   ._�5      �� $	��125��6!    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value N� EnterActions �� TargetProperty	 �� To g� Duration N� ExitActions��%  '��       �� 5      " ��6$   .�5   "   ��  � �� �#f0f0f06?   �� 5   "    � ��
 �   �6?   �� 5   "    �@�Cursor$
 Hand��6;   �� 5   "    � ��$ 20 10q�6<   -   5        �� 5   "    � �� 5    &   �� 5!   *   " ��6:   .R�5"   .   �� #��z��65   #  z��6_   #��z��6�   ._�5#   2   �� 5$   /   5%   +   5'   #    5)   "   P� 5*   &   	 �@J�IsMouseOver$

 True��6E    5+   *   �� 5,   .   .��5-   2   �� .��5.   6   �� $( "Background.(SolidColorBrush.Color)�6E    #c7c7c76�   $ 0:0:0.1D�6�   5/   3   50   /    52   *   �� 53   .   .��54   2   �� .��55   6   �� $( "Background.(SolidColorBrush.Color)�6E    #f0f0f06�   $ 0:0:0.1D�6�   56   3   57   /   59   '   5;      5<      .+�5=      �� $
��Edit��6!   ��60   �� *EditUserCommand+�� 5>      $��Delete��6!    � Cursor$
 Hand��6X   ��62   �� *DeleteUserCommand+6X   5?      5@      5A      5C      5D      5E      