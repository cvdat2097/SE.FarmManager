   M S B A M L   `   `   `  ����H  DWPF_DEMO_QLNT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_DEMO_QLNTWPF_DEMO_QLNT  5   	       WPF_DEMO_QLNT.TK   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_DEMO_QLNT     5   	     � Title$4  .Phần mềm hỗ trợ nông nghiệp v.0.0.1��5   	   $	��509��66   $	��600��6C   $��10q�6O    � WindowStartupLocation$ CenterScreen=�6d   ��5	      �� 5
   
    �� ImageSource$ backG/dc.jpg��6   .��5      ��  �� Padding$ 10q�6   ._�5   
   �� .+�5      �� $��10,10,10,10q�6   .+�5      � $	��143��6   $��-4,0,0,0q�6$    � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $
��1.5* �6+   �� 5      $
��1.5* �6+   .+�5      �� -   5        $��0��5      $
��Bold"�6-   $��
Trở về��6?   $��10,10,40,76q�6P   ��5      �� 5       �� EndPoint$ 0.5,1&�62    � MappingMode$ RelativeToBoundingBox=�6C    �� 
StartPoint$ 0.5,0&�6g   .��5   "   �  � Color$ 	#FF0A247B��6/   	 � Offset$	 0Q�6A   � 5   "   $ 	#FF4CE4E4��6/   $	 0.486Q�6A   � 5   "   $ 	#FF4660B2��6/   $	 0.004Q�6A   5       5"      �� 5$      $��1��6   $"��Nhập thông tin cần tìm��6-   $
��Bold"�6N   $��31��6`   $��1,12,53,100q�6l   
 J� RenderTransformOrigin$
 0.452,-0.424&�6�   ��5%      �� 5&      $ 0.5,1&�62   $ 0.5,0&�6C   .��5'   "   � $ Black��6/   $	 0Q�6=   � 5(   "   $ White��6/   $	 1Q�6=   � 5)   "   $ 	#FFD2F3ED��6/   $	 0.019Q�6A   5*      5,      �� 5-      -   5         ��Name$ 	SearchBox��5-      $��1��61   $��	0,43,0,69q�6A   $
��Left=�6T   $	��198��6o   �� 5.      -   5        $
��Tìm��5.      $
��Bold"�6+   $��1��6=   $��129,74,3,34q�6M   ��5/      �� 50      $ 0.5,1&�62   $ RelativeToBoundingBox=�6C   $ 0.5,0&�6g   .��51   "   � $ 	#FF0A247B��6/   $	 0Q�6A   � 52   "   $ 	#FF4CE4E4��6/   $	 0.486Q�6A   � 53   "   $ 	#FF4660B2��6/   $	 0.004Q�6A   54      56      �� 58      -   5         ��Name$ ComboBoxSearch��58      $��2��67   $��
11,44,0,69q�6G   $��Arial)�6[   $
��Bold"�6n   .@�59      �� $)��#Chọn loại thông tin cần tìm��6(    �� 
IsSelected . 6b   �� 5:      -   5        $��ND��5:   '   $��
Nông Dân��61   6F   �� 5;      -   5        $��TN��5;   '   $��Thương Nhân��61   6I   �� 5<      -   5        $��VN��5<   '   $��Vật Nuôi��61   6F   �� 5=      -   5        $��CT��5=   '   $��Cây Trồng��61   6G   5>      5?      5@      &   System.Windows.Controls.DataGrid  5C      -	   5          Name$ SearchResult��5C      $	��275��6-   5E      5H      5I      5J      