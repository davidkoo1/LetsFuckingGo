   M S B A M L   `   `   `  ����F  BappTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:appTutorial.ComponentsappTutorial.Components  5      ,    &appTutorial.Components.TestDitailsForm   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:appTutorial.Components     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � IsSharedSizeScope$
 True��6     5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6'    z� SharedSizeGroup$ Label��64   �� 5      $��* �6'   $	��250��61   .+�5      �� $��0��6   $��	TestName ��6,   $
��Bold"�6=   �� 5      $��1��6   $��20 0 0 0q�6*   ��6<   �� *
Testname+ �� UpdateSourceTrigger$ PropertyChanged=�5      � 5!      $��1��6   $��0 20 0 0q�6     5"      �� 5#      $
��auto �6'   $ Label��64   �� 5$      $��* �6'   $	��250��61   .+�5&      �� $��0��6   $��TestDiscription ��6,   $
��Bold"�6D   �� 5'      $��1��6   $��20 0 0 0q�6*   ��6<   �� *TestDiscription+5(      � 5)      $��2��6   $��0 20 0 0q�6     5*      �� 5+      $
��auto �6'   $ Label��64   �� 5,      $��* �6'   $	��250��61   .+�5.      �� $��0��6   $��TestTime��6,   $
��Bold"�6<   �� 5/      $��1��6   $��20 0 0 0q�6*   ��6<   �� *
TestTime+50      � 51      $��3��6   $��0 20 0 0q�6     52      �� 53      $
��auto �6'   $ Label��64   �� 54      $��* �6'   $	��250��61   .+�56      �� $��0��6   $��AutorID��6,   $
��Bold"�6;   �� 57      $��1��6   $��20 0 0 0q�6*   ��6<   �� *	AutorID+58      59      � 5;   
   $��1��6   $��0 30 0 0q�6!   .+�5<      �� $��Submit��6   $��0 0 10 0q�6L   ��6&   �� *SubmitTestCommand+{�6^   �� *CanTestSubmit+�� 5=      $��Cancel��6      ButtonSecondary#��[  6L    � Cursor$
 Hand��6u   ��6&   �� *CancelTestCommand+6u   5>      5@      5A      