   M S B A M L   `   `   `  ����E  AGreenThumb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GreenThumb
GreenThumb  5   	       GreenThumb.PlantWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GreenThumb     5   	     � Title$  PlantWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��25* �6   �� 5      $	��50* �6   �� 5      $	��25* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��0��6%   .+�5      �� $��Search for plant��6   $��15(�60   �� 5      -   5        $��txtSearchbar��5      $	��245��6+   $��40��67   $
��Left=�6D   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��	btnSearch��5      $��Search��6,   $��80��6=   $��55��6H   $
��Left=�6T   6o   �� 5      -   5        $��btnResetSearch��5      $��Reset��60   $��80��6@   $��55��6K   $
��Left=�6W   6r   5      5!      �� 5"   
   -   5         ��Name$ lstPlant��5"      $��1��6%   $��1��65   $��2��6B   $
��True��6T   $��Visible=�6y   5$      �� 5%   
   $��3��6   $��1��6"   $ 
Horizontal=�62   .+�5&      �� -   5        $��btnPlantDetails��5&      $��Details��6,   $��80��6>   $��55��6I   $
��Left=�6U   6p   �� 5'      -   5        $��btnDeletePlant��5'      $��Delete Plant��6,   $��80��6C   $��55��6N   $
��Left=�6Z   $��30 0 0 0q�6u   6�   5)      �� 5*   
   -   5        $��btnPlantWindow��5*      $��0��6)   $��1��69   $��	Add plant��6F   $��80��6Z   $��55��6e   $��Center=�6q   $��Center=�6�   6�   �� 5+   
   -   5        $��btnGoToGarden��5+      $��0��6(   $��2��68   $��Go to Garden��6E   $��80��6\   $��55��6g   $��Center=�6s   $��Center=�6�   6�   52      53      