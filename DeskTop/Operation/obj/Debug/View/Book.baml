   M S B A M L   `   `   `  ����  	Operation    Operation.View.Book   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      -   5          >�Name$
  root��5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel .  � 	Resources 5         ListViewItemStyle �� 
TargetType �� Property �� Value��%[   &	        �� 5   
   " ��6*   .�5      ��  � ��$ Center=�6;   6L   5      5      .��5      � $
��auto��6   $��Center=�6   $��Center=�65   $��10,10,10,10q�6Q    � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   5      .+�5   
   ]� .+�5      �� $	��Top=�6    �� Orientation$ 
Horizontal=�6.   .+�5       �� 	 � ToolTip$	 修改��6<   $	��100��6I   ��6   �� *EditCanComamnd+��5"      �� 5#      $ 
Horizontal=�6%   .+�5%      �� $��修改��6(   $��Center=�62   5&      5(      �� 5)      $	 删除��68   $	��100��6E   ��6   �� *
DelCommand+��5*      �� 5+      $ 
Horizontal=�6%   .+�5-      �� $��删除��6(   $��Center=�62   5.      50      �� 51      $	 增加��68   $	��100��6F   ��6   �� *
AddCommand+��52      �� 53      $ 
Horizontal=�6%   .+�55      �� $��增加��6(   $��Center=�62   56      58      �� 59      $	 前进按钮��6   $	��100��6N   ��6*   �� *ForWardCommand+��5:      �� 5;      $ 
Horizontal=�6%   .+�5=      �� $��前进按钮��6(   $��Center=�64   5>      5@      5A      &   System.Windows.Controls.DataGrid  5B      -   5        $��BookGrid��5B      
   AutoGenerateColumns
 .     CanUserAddRows .  $
��Auto��6z   $��0��6�   $��0��6�   $��1q�6�      CanUserResizeColumns .    GridLinesVisibility$ 
Horizontal=�6�      HorizontalGridLinesBrush
 �   �!   EnableColumnVirtualization .  ��6'   �� *mylist+ �� SelectedItem 6  �� *Book+   RowStyle 5C      �� 5D      )  #System.Windows.Controls.DataGridRow"  6   .�5E      ��  � ��
 ��ح�67    �� Triggers 5F      P� 5G       P� Property �@J�IsMouseOver P� Value . . �5I   "   ��  � ��
 ��·�6?   �� 5J   "    � ��
 �����6?   5K      5M      ��5P      �� 5Q       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5R      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5S      $ White��6'   $ 1Q�65   5T         Columns 5V      4  .System.Windows.Controls.DataGridTemplateColumn  5W      ,  &System.Windows.Controls.DataGridColumn   Header 5X      �� 5Y       d� 	IsChecked 6'   �� *DataContext.IsSelectAll+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� RelativeSource ��  �� AncestorType$ DataGridL�  �� AncestorLevel$  1��.  (System.Windows.Interactivity.Interaction!   Triggers! 5Z   "   /  )System.Windows.Interactivity.EventTrigger  5[   &   "   	EventName$" Click��65   .  (System.Windows.Interactivity.TriggerBase#   Actions.# 5\   *   6	  0System.Windows.Interactivity.InvokeCommandAction	  $ 	  Command$ 6@   �� *DataContext.SelectAllCommand+ �� $ DataGridL�$  1��6�   5]   '   5_      %   CellTemplate% 5a      �� 5b      .R�5c   "   �� $��3q�6+    66   �� *
IsSelected+$ TwoWay=�$ PropertyChanged=�! 5d   &     5e   *   $" Click��69   .# 5f   .   	  $ 6D   �� *DataContext.SelectCommand+ �� $ UserControlL�$  1��& 	  CommandParameter& 6�   �� *BookId+6�   5g   +   5i   #   5j      5l      0
  *System.Windows.Controls.DataGridTextColumn
  5m      $ 书名��6S   '   Width5  /System.Windows.Controls.DataGridLengthConverter$' 50 6_   -   5        BookName��1  +System.Windows.Controls.DataGridBoundColumn(   Binding( 5m   )   �� *
BookName+$ TwoWay=�6j   
  5n      $ 	序列号��6P   $' 50 6]   ( 6)   �� *BookId+$ TwoWay=�6]   
  5o      $ 	发行者��6S   $' 50 6`   ( 6)   �� *	Publisher+$ TwoWay=�6`   
  5p      $ 作者��6T   $' 50 6`   ( 6)   �� *
BookAuthor+$ TwoWay=�6`   
  5q      $ 类型��6R   $' 50 6^   ( 6)   �� *
BookType+$ TwoWay=�6^     5r      % 5s      �� 5t      .R�5u   "   � .+�5v   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6g   .+�5x   *   �� $	 修改��6�   ��61   �� *DataContext.EditCommand+ �� $ UserControlL���5y   .   �� 5z   2   $ 
Horizontal=�6=   .+�5{   6   �� $��修改��6@   $��Center=�6J   5|   3   5~   +   �� 5   *   $��40��62   $��20��6=   $	 删除��6I   $��10(�6V   ��6d   �� *DataContext.DelCommand+ �� $ UserControlL���5�   .   �� 5�   2   $ 
Horizontal=�6=   .+�5�   6   �� $��删除��6@   $��Center=�6J   5�   3   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�   
   -   5        $��
textCanvas��5�   %   $y�Hidden=�6   .+�5�      �� -   5        $��txtBookName��5�   G   ��6   �� *!DataContext.SelectItem.BookName+6\   �� 5�      $��取消��6   ��6"   �� *CancelCommand+6G   �� 5�      $��保存��6   ��6"   �� *SaveCommand+6E   5�      � 5�   
   6   5�      5�      