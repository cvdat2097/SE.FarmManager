   M S B A M L   `   `   `  ����H  DWPF_DEMO_QLNT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_DEMO_QLNTWPF_DEMO_QLNT  5   	       WPF_DEMO_QLNT.Lich   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_DEMO_QLNT     5   	     � Title$
  Lich��5   	   $	��509��6   $	��600��6#   $��10q�6/    � WindowStartupLocation$ CenterScreen=�6D   ��5	      �� 5
   
    �� ImageSource$ backG/dc.jpg��6   .��5      ��  �� Padding$ 10q�6   ._�5   
   �� .+�5      �� $��10,10,10,10q�6   .+�5      � $��65��6    � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $��* �6+   �� 5      $��* �6+   .+�5      �� -   5         ��Name$ ButtonTroVe��5      $��0��62   $
��Bold"�6B   $��
Trở về��6T   $��19,10,63,10q�6e   ��5      �� 5       �� EndPoint$ 0.5,1&�62    � MappingMode$ RelativeToBoundingBox=�6C    �� 
StartPoint$ 0.5,0&�6g   .��5   "   � 	 � Color$	 	#FF0A247B��6/   
 � Offset$
 0Q�6A   � 5   "   $	 	#FF4CE4E4��6/   $
 0.486Q�6A   � 5   "   $	 	#FF4660B2��6/   $
 0.004Q�6A   5      5       5"      5#      �� 5'      $	��181��6   .+�5(      �  J� 	AllowDrop . $	��186��6(    5)      �� 5*      $��* �6+   .+�5.      �� $��1��6!   .+�52      �� .+�55      �  56   "   �� 57   &   $��* �67   �� 58   &   $��* �67   �� 59   &   $
��1.2* �67   �� 5:   &   $��* �67   �� 5;   &   $��* �67   �� 5<   &   $��* �67   .+�5>   "   �� $
��Bold"�6)   $��Lịch��6;   $��2��6J   $��	27,0,53,0q�6^   ��5?   &   �� 5@   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5A   .   � $	 Black��6;   $
 0Q�6I   � 5B   .   $	 	#FF9EE68E��6;   $
 1Q�6M   � 5C   .   $	 	#FFD2FF09��6;   $
 0.054Q�6M   5D   +   5F   #   5G      5H      &   System.Windows.Controls.DataGrid  5J      -   5          Name$ DataGrid_Lich��5J   #   $	��161��6:   $��	27,0,10,0q�6G   6�   5K      5O      5P      5T      5U      5V      