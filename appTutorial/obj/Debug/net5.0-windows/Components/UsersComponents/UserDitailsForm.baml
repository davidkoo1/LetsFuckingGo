   M S B A M L   `   `   `  ����F  BappTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:appTutorial.ComponentsappTutorial.Components  5      ,    &appTutorial.Components.UserDitailsForm   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:appTutorial.Components     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � IsSharedSizeScope$
 True��6     5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��Auto �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6'    z� SharedSizeGroup$ Label��64   �� 5      $��* �6'   $	��250��61   .+�5      �� $��0��6   $��	UserName ��6,   $
��Bold"�6=   �� 5      $��1��6   $��20 0 0 0q�6*   ��6<   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5       � 5"      $��1��6   $��0 20 0 0q�6     5#      �� 5$      $
��auto �6'   $ Label��64   �� 5%      $��* �6'   $	��250��61   .+�5'      �� $��0��6   $��UserSurname ��6,   $
��Bold"�6@   �� 5(      $��1��6   $��20 0 0 0q�6*   ��6<   �� *UserSurname+5)      � 5*      $��2��6   $��0 20 0 0q�6     5+      �� 5,      $
��auto �6'   $ Label��64   �� 5-      $��* �6'   $	��250��61   .+�5/      �� $��0��6   $��LogIn��6,   $
��Bold"�69   �� 50      $��1��6   $��20 0 0 0q�6*   ��6<   �� *	UserLogin+51      � 52      $��3��6   $��0 20 0 0q�6     53      �� 54      $
��auto �6'   $ Label��64   �� 55      $��* �6'   $	��250��61   .+�57      �� $��0��6   $��Password��6,   $
��Bold"�6<   �� 58      $��1��6   $��20 0 0 0q�6*   ��6<   �� *UserPassword+59      � 5:      $��4��6   $��0 20 0 0q�6     5;      �� 5<      $
��Auto �6'   $ Label��64   �� 5=      $��* �6'   $	��250��61   .+�5?      �� $��0��6   $��Standing��6,   $
��Bold"�6<   �� 5@      $��1��6   $��20 0 0 0q�6*   ��6<   �� *UserStanding+5A      5B      � 5D   
   $��1��6   $��0 30 0 0q�6!   .+�5E      �� $��Submit��6   $��0 0 10 0q�6L   ��6&   �� *SubmitUserCommand+{�6^   �� *CanUserSubmit+�� 5F      $��Cancel��6      ButtonSecondary#��[  6L    � Cursor$
 Hand��6u   ��6&   �� *CancelUserCommand+6u   5G      5H      5I      