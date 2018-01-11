using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WPF_DEMO_QLNT
{
    /// <summary>
    /// Interaction logic for BangDieuKhienThuongNhan.xaml
    /// </summary>
    public partial class BangDieuKhienThuongNhan : Window
    {
        public BangDieuKhienThuongNhan()
        {
            InitializeComponent();
        }

        private void Tim_Kiem(object sender, RoutedEventArgs e)
        {
            this.Close();
            TK Tk = new TK();
            Tk.Show();
        }

        private void Lich(object sender, RoutedEventArgs e)
        {
            this.Close();
            Lich L = new Lich();
            L.Show();
        }
        private void Cay_Trong(object sender, RoutedEventArgs e)
        {
            this.Close();
            Caytrong Cp = new Caytrong();
            Cp.Show();
        }
        private void BangDieuKhienBoss(object sender, RoutedEventArgs e)
        {
            this.Close();
            BangDieuKhienBoss Cp = new BangDieuKhienBoss();
            Cp.Show();
        }
        private void Vat_Nuoi(object sender, RoutedEventArgs e)
        {
            this.Close();
            Vatnuoi Cp = new Vatnuoi();
            Cp.Show();
        }
        private void Them(object sender, RoutedEventArgs e)
        {
            this.Close();
            ThemNgLam Th = new ThemNgLam();
            Th.Show();
        }

        private void TN(object sender, RoutedEventArgs e)
        {
            this.Close();
            Danh_sach_Tn T = new Danh_sach_Tn();
            T.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Danh_sach_nglam Ds = new Danh_sach_nglam();
            Ds.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Ruong R = new Ruong();
            R.Show();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow M = new MainWindow();
            M.Show();
        }

        private void DataGridDanhSachSanPham_Initialized(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            String queary = "SELECT MASP,TENSP,LOAISP,SOLUONG,GIA GIADEXUAT FROM SANPHAM";
            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("HoatDongGanDay");
            sda.Fill(dt);
            DataGridDanhSachSanPham.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void ButtonMua_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                    con.Open();

                    // ================= DAT GIA SAN PHAM
                    DataRowView drv = (DataRowView)DataGridDanhSachSanPham.SelectedItem;
                    String masp = (drv["MASP"]).ToString();
                    String giasp = (drv["GIADEXUAT"]).ToString();

                    

                    //if (Convert.ToInt64(giasp) > Convert.ToInt64(TextBoxGia.Text))
                    //{
                    //    MessageBox.Show("Ba đặt giá lớn hơn hoặc bằng giá đề xuất");
                    //}


                        string queary = "insert into DONDATHANG (THUONGNHAN, SANPHAM, GIA) values ('" + Flags.MaTN + "','" + masp + "','" + TextBoxGia.Text.ToString() + "')";
                        SqlCommand sc = new SqlCommand(queary, con);
                        sc.ExecuteNonQuery();
                        // ====================================

                        MessageBox.Show("Đặt giá thành công!");

                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
        }

        private void ButtonTroVe_Click(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Close();
            m.Show();
        }


    }
}
