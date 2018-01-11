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
    /// Interaction logic for Lich.xaml
    /// </summary>
    public partial class Lich : Window
    {
        public Lich()
        {
            InitializeComponent();
        }

        private void Tim_Kiem(object sender, RoutedEventArgs e)
        {
            if (Flags.ND == true || Flags.CH == true)
            {
                this.Close();
                TK Tk = new TK();
                Tk.Show();
            }
        }
        private void Chi_Phi(object sender, RoutedEventArgs e)
        {
            this.Close();
            BangDieuKhienThuongNhan Cp = new BangDieuKhienThuongNhan();
            Cp.Show();
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

        private void Them(object sender, RoutedEventArgs e)
        {
            this.Close();
            ThemNgLam Th = new ThemNgLam();
            Th.Show();
        }
        private void Mua(object sender, RoutedEventArgs e)
        {
            this.Close();
            ThemNgmua Th = new ThemNgmua();
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

        private void DataGrid_Lich_Initialized(object sender, EventArgs e)
        {
            try
            {

            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            String queary = "select c.MACV, c.TENCV, c.VITRI,c.THOIGIAN from NONGDAN n, LICH l, CONGVIEC c where n.MALICH = l.MALICH and c.MACV = l.CONGVIEC and n.MAND = '" + Flags.MaND + "'";
            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Lich");
            sda.Fill(dt);
            DataGrid_Lich.ItemsSource = dt.DefaultView;
            con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void DataGridDanhSachRuong_Initialized(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            String queary = "SELECT * FROM KHUVUC";
            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("KhuVuc");

            sda.Fill(dt);

            DataGridDanhSachRuong.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void DataGridHoatDongGanDay_Initialized(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            String queary = "SELECT * FROM HDGD";
            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("HoatDongGanDay");
            sda.Fill(dt);
            DataGridHoatDongGanDay.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow M = new MainWindow();
            M.Show();
        }

        private void Vat_Nuoi(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDiemDanh_Click(object sender, RoutedEventArgs e)
        {
            if (Flags.ND == true)
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                    con.Open();

                    // ================= Diem danh
                    string queary = @"update NONGDAN 
                                  set NGAYDIEMDANH = GETDATE(), GIOCONG = GIOCONG + 8 
                                  where (DAY(NGAYDIEMDANH) != DAY(GETDATE()) or MONTH(NGAYDIEMDANH) != MONTH(GETDATE()) or YEAR(NGAYDIEMDANH) != YEAR(GETDATE()))
                                  and MAND = '" + Flags.MaND + "'";
                    SqlCommand sc = new SqlCommand(queary, con);
                    sc.ExecuteNonQuery();
                    // ====================================

                    MessageBox.Show("Điểm danh thành công");
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
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
