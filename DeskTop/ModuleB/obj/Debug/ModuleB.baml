   M S B A M L   `   `   `  ����B  >ModuleB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ModuleBModuleB  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          ModuleB.ModuleB   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:ModuleB     5      :m,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5        � 	Resources  5         RedBrush �� Color  nameStr �� 
TargetType  StyleMakeUp �� Property �� Value �� Triggers P� Property P� Value :� RoutedEvent	 g� Duration
 �� TargetProperty	 W� To  ButtonTemplate �� 
TargetType �� Triggers �� 
TargetName  personDataTem �� CornerRadius � RowDefinitions �� Path �� Triggers P� 
SourceName  listItemsPanelTem �� Orientation��%�  &	        &	 "     &	 `     &	 �    &	 �    &	     �� 5   
   $	 Red��6+   69   ��5   
   &"数据模板,控件模板的使用��5      �� 5   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ 12(�6)   �� 5       � ��$
 Bold"�6+    5      P� 5       �@J�	IsFocused . . �5      ��  � ��
 �  ��6;   5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 � ���6;   �� 5       � ��$
 Bold"�6;   5      P� 5!       � �� . . �5"      ��  � ��
 ��  �6;   5#      :� 5$      $ Mouse.MouseEnter��6   [�5&      �� 5(      .��5*      �� .��5+   "   W� $	 0:0:0.2D�5,      $
 FontSize�5-      $ 22X�5.      5/      50      52      :� 54      $ Mouse.MouseLeave��6   [�55      �� 56      .��59      �� .��5:   "   W� $	 0:0:1D�5;      $
 FontSize�5<      5=      5>      5@      5B      �� 5C   
   " ��61   .R�5D      � .+�5E      A� $	��ell��6   
��� ���$��20��63   $��20��6>   6L   �� 5G      #��z��6#   $��Center=�6N   $��Center=�6i   6�   5H       5I      P� 5J       �@J�IsMouseOver . . �5K      �� $	 ell��6    � ��
 � ���6?   5L      5N      �� 5P   
   .R�5Q      �� $��
blueBorder��6   $��3q�6'   $��3q�62   
����  �$ 5��5R      ._�5S      � $��3q�6    5T      �� 5U      6*   �� 5V      6*   .+�5X      �� $��nametxt��6    $
��Bold"�6/   ��6A   �� $
 Name�6^   �� 5Y      $��1��6    ��6-   �� $	 Age�6I   5Z      5[       5]      P� 5^      $ 
blueBorder��6    �@J�IsMouseOver . . �5_      �� $ 
blueBorder��6    � ��
 �����6K   �� 5`      $ nametxt��6    � ��$ 20(�6F   5a      5c      �� 5e   
   .R�5f      �� $ 
Horizontal=�6   $��Center=�5g      $
��Left=�5h      5i      5k      .��5m      � .+�5n   
   �� $ 5��6   6%   �� 5o   
   
������ 
������ .��5p      �� $ 
Horizontal=�6   .+�5s      �� .+�5u      �� #��[ 6    �� 5v      #��[  6/   $��5q�6V   $��14(�6a   $$��不适用预先定义的样式��6o   ��6   Z� 6o   �� 5w      #���   6   $��使用��6F   #��[ 6S   #��[ 6x   �� 5x      .+�5y      �� -   5        $��	lstPerson��5y   "   $��Stretch=�63   #��[ 6Y   #��[ 6�   6�   5z      5|      5�      5�      5�      5�      