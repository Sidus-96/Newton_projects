   M S B A M L   `   `   `  ����E  AGreenThumb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GreenThumb
GreenThumb  5   	   #    GreenThumb.PlantDetailsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GreenThumb     5   	     � Title$  PlantDetailsWindow��5   	   $	��500��6$   $	��800��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��25* �6   �� 5      $	��50* �6   �� 5      $	��25* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6   $��0��6%   $��	0,0,0,134q�62   $��2��6E   .+�5      �� $��
Plant Name��6   $��15(�6*   �� 5      -   5        $��txtchangeplant��5      $	��245��6-   $��40��69   $
��Left=�6F   �� 5      $��Add instruction to plant��6   $��15(�68   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��txtAddInstruction��5      $	��200��64   $��40��6@   $
��Left=�6M   " �� VerticalScrollBarVisibility$
 Auto=�6h   6�   �� 5      -   5        $��btnAddInsctruction��5      $��add instruction��65   $��85��6O   $��25��6Z   $
��Left=�6f   6�   5!      �� 5"      $ ��Edit instruction from list��6   $��15(�6:   �� 5#      $ 
Horizontal=�6   .+�5%      �� -   5        $��txtEditInstruction��5%      $	��212��65   $��30��6A   $
 Auto=�6N   �� 5&      -   5        $��btnEditInsctruction��5&      $��	Save edit��66   $��85��6J   $��25��6U   $
��Left=�6a   6|   5(      5*      �� 5+   
   -   5         ��Name$ lstDetailsInstructions��5+      $��1��63   $��1��6C   $
��True��6Q   $��Visible=�6v   $��0,25,0,0q�6�   6�   �� 5,   
   $��3��6   $��1��6"   $ 
Horizontal=�62   $��0,42,0,0q�6K   .+�5-      �� -   5        $��btnSaveChanges��5-      $��Save Changes��6+   $��80��6B   $��55��6M   $
��Left=�6Y   6t   �� 5.      -   5        $��btnUnlockinputs��5.      $��Unlock all inputs��6,   $	��120��6H   $��55��6T   $��Center=�6`   $��50 0 0 0q�6}   6�   �� 5/      -	   5        $��btnAddToGarden��5/      $��Add to garden��6+   $	��120��6C   $��55��6O   $��Center=�6[   $��20 0 0 0q�6x   ��50      �� 51       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��52      �  � Color$ Black��6'   � 53      $ 	#FF38BB6A��6'   	 � Offset$	 1Q�69   54      56      57      �� 58   
   -
   5        $��	btnGoBack��58      $��0��6$   $��1��64   $��Go back��6A   $��80��6S   $��55��6^   $��Center=�6j   $��Center=�6�   6�   5?      5@      