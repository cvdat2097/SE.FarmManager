   M S B A M L   `   `   `  ����H  DWPF_DEMO_QLNT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_DEMO_QLNTWPF_DEMO_QLNT  5   	   +    %WPF_DEMO_QLNT.BangDieuKhienThuongNhan   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_DEMO_QLNT     5   	     � Title$
  Lich��5   	   $	��513��6   $	��600��6#    � WindowStartupLocation$ CenterScreen=�60   ��5	      �� 5
   
    �� ImageSource$ backG/dc.jpg��6   .��5      ��  �� Padding$ 10q�6   ._�5      � .+�5   
   �� -   5        $��	ButtonMua��5      $
��Bold"�6"   $��Mua sản phẩm��64   $��215,361,0,50q�6K   $
��Left=�6a   $	��140��6|   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      �  � Color$ 	#FF0A247B��6#    � Offset$ 0Q�65   � 5      $ 	#FF4CE4E4��6#   $ 0.486Q�65   � 5      $ 	#FF4660B2��6#   $ 0.004Q�65   5      5      �� 5   
   -   5        	 ��Name$	 ButtonTroVe��5      $��0��6&   $
��Bold"�66   $��
Trở về��6H   $��10,25,463,386q�6Y   ��5      �� 5      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5      � $ 	#FF0A247B��6#   $ 0Q�65   � 5      $ 	#FF4CE4E4��6#   $ 0.486Q�65   � 5       $ 	#FF4660B2��6#   $ 0.004Q�65   5!      5#      �� 5&   
   $��Danh sách sản phẩm��6   $��10,81,10,355q�6.   &   System.Windows.Controls.DataGrid  5'   
   -   5        
  Name$
 DataGridDanhSachSanPham��5'      $��10,107,10,132q�64   6K   �� 5)   
   -   5         ��Name$ 
TextBoxGia��5)       � ToolTip$	 GIA��6&   $��Right=�65   $	��163��6Q   $��0,384,399,50q�6]   �� 5*   
   $
��Giá��6   $��23��6   $��10,361,399,78q�6+   5,      5/      50      