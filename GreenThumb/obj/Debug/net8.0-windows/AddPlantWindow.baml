   M S B A M L   `   `   `  ����E  AGreenThumb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GreenThumb
GreenThumb  5   	       GreenThumb.AddPlantWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GreenThumb     5   	     � Title$  AddPlantWindow��5   	   $	��450��6    $	��800��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��25* �6   �� 5      $	��50* �6   �� 5      $	��25* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6   $��0��6%   $��0,0,0,73q�62   $��2��6D   .+�5      �� $��	Add plant��6   $��15(�6)   �� 5      -   5        $��txtAddPlant��5      $	��245��6*   $��40��66   $
��Left=�6C   6^   �� 5      $��Add instruction to plant��6   $��15(�68   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��txtAddInstruction��5      $	��200��64   $��40��6@   $
��Left=�6M   " �� VerticalScrollBarVisibility$
 Auto=�6h   6�   �� 5      -   5        $��btnAddInsctruction��5      $��add instruction��65   $��85��6O   $��25��6Z   $
��Left=�6f   6�   5!      5#      �� 5$   
   -   5         ��Name$ lstNewInstructions��5$      $��1��6/   $��1��6?   $��2��6L   $
��True��6^   $��Visible=�6�   5&      �� 5'   
   $��3��6   $��1��6"   $ 
Horizontal=�62   .+�5(      �� -   5        $��btnAddPlant��5(      $��	Add plant��6(   $��80��6<   $��55��6G   $
��Left=�6S   6n   5+      �� 5,   
   -   5        $��	btnGoBack��5,      $��0��6$   $��1��64   $��Go back��6A   $��80��6S   $��55��6^   $��Center=�6j   $��Center=�6�   6�   53      54      