   M S B A M L   `   `   `  ����B  >ModuleE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ModuleE.ViewModelModuleE.ViewModel  5
          ModuleE.View.ModuleEPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   (vmclr-namespace:ModuleE.ViewModel  5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � 	Resources 5         HorizontalSeparatorStyle �� 
TargetType��%"   &	        �� 5   
   " �61   5       � DataContext 5      ,   &ModuleE.ViewModel.ModuleEPageViewModel  5   
   .��5      � .+�5   
   �� .��5      �  � RowDefinitions 5      �� 5      �� 5      �� 5      $
��Auto �6$   .+�5      �� $��0��6   ._�5      �� -   5         ��Name$ TextMessage��5      $��Stretch=�6c   $��Stretch=�6�   $	��100��6�   ��63   ��  �� Path$ TextMessage� �� Mode$ TwoWay=�6�   5      �� 5      $��2��6   .+�5      �� $ ��值绑定元素textmessage��6    $
��auto��69   6H   �� 5      $
��auto��6Q   ��6   ��  �� ElementName$ TextMessage��$
 Text�6`   5       5!      5"      �� 5#   
   $��给文本框赋值��6   {�. $
��auto��65   $
��auto��6B   $��Right=�6Q   $��0��6m   .  (System.Windows.Interactivity.Interaction	   Triggers	 5$      /  )System.Windows.Interactivity.EventTrigger  5%      
   	EventName$
 Click��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5&      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *AssignCommand+5'      5)      5+      5,      