   M S B A M L   `   `   `  ����?  ;Lab2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab2Lab2  5   	       Lab2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
���iii� � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $!��Condition: 2x - cos (x) = 0��6   $��0��67   $��1��6D   $��Center=�6T   $��Center=�6q   
�������6�   �� 5   
   $��Condition: x + ln (x) = 0��6   $��0��65   $��2��6B   $��Center=�6R   $��Center=�6o   
�������6�   �� 5   
   $��0��6   $��2��6   $��Center=�6-   $��Center=�6J   
�������6e   �� 5   
   $��Enter x for 1 thread��6   $��0��60   $��1��6=   $��Center=�6M   $��Bottom=�6j   
�������6�   �� 5   
   $��Enter x for 1 thread��6   $��0��60   $��2��6=   $��Center=�6M   $��Bottom=�6j   
�������6�   �� 5   
   -   5         ��Name$ firstThreadInsert��5      $��1��6-   $��1��6:   $��Center=�6J   $	��Top=�6g   $	��100��6   $��20��6�   
�������6�   �� 5   
   -   5        $ secondThreadInsert��5      $��1��6.   $��2��6;   $��Center=�6K   $	��Top=�6h   $	��100��6�   $��20��6�   
�������6�   �� 5    
   -   5         ��Name$ firstThreadResult��5       $��1��6+   $��1��68   $��Center=�6H   $��Center=�6e   
�������$	��200��6�   $��40��6�   $��Center=�6�   �� 5!   
   -   5        $ secondThreadResult��5!      $��1��6,   $��2��69   $��Center=�6I   $��Center=�6f   
�������$	��200��6�   $��40��6�   $��Center=�6�   �� 5#   
   -   5        $��2��5#      $��2��6%   $��1��66   $��1��6F   $��150, 125, 150, 125q�6S   $��	Calculate��6o   
�������
�������6�   5%      5&      