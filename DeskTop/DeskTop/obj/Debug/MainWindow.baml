   M S B A M L   `   `   `  ����B  >DeskTop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DeskTopDeskTop  5   	       DeskTop.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:DeskTop     5   	   P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5   
     � Title$  
MainWindow��5	   	   $	��500��6   $	��800��6)    � 	Resources 5
         ContentControlStyle �� 
TargetType �� Property �� Value �� 
TargetType��%�   &	        �� 5   
   " ��6,   .�5      ��  � ��$ 8q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� 5      5      5      5      .��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5"   
   �� $��0��6   $��0��6)   !  Prism.Regions.RegionManager	   
RegionName$	 ModuleA��67   #���   6`   �� 5$   
   $��1��6   $��0��6)   $	 ModuleB��66   #���   6_   �� 5&   
   $��0��6   $��1��6)   $	 ModuleC��66   #���   6`   �� 5(   
   $��1��6   $��1��6)   $	 ModuleD��66   #���   6_   �� 5)   
   $��0��6   $��2��6)   $	 ModuleE��66   #���   6_   �� 5*   
   $��1��6   $��2��6)   $	 ModuleF��66   #���   6_   5.      5/      