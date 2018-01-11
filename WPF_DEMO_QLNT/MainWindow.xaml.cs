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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WPF_DEMO_QLNT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = ("Getting Connection ...");

            SqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                textBox.Text = ("Openning Connection ...");

                conn.Open();

                textBox.Text = ("Connection successful!");
            }
            catch (Exception e)
            {
                textBox.Text = ("Error: " + e.Message);
            }


        }


        private void Tim_Kiem(object sender, RoutedEventArgs e)
        {
            TK t = new TK();
            this.Close();
            t.Show();
        }




        private void Lich(object sender, RoutedEventArgs e)
        {
            this.Close();
            Lich L = new Lich();
            L.Show();

        }

        private void Chi_Phi(object sender, RoutedEventArgs e)
        {
            this.Close();
            BangDieuKhienThuongNhan Cp = new BangDieuKhienThuongNhan();
            Cp.Show();
        }
        private void BangDieuKhienBoss(object sender, RoutedEventArgs e)
        {
            this.Close();
            BangDieuKhienBoss Cp = new BangDieuKhienBoss();
            Cp.Show();
        }
        private void Cay_Trong(object sender, RoutedEventArgs e)
        {
            this.Close();
            Caytrong Cp = new Caytrong();
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



        private void DSR(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Danh_sach_nglam Ds = new Danh_sach_nglam();
            Ds.Show();
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Ruong R = new Ruong();
            R.Show();
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

        }

        private void Button_Initialized(object sender, EventArgs e)
        {
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            if (Flags.TN == true)
            {

            }
            else if (Flags.ND == true)
            {
                ButtonThemNguoiLam.IsEnabled = false;
                ButtonThemNguoiMua.IsEnabled = false;
                ButtonNongDan.IsEnabled = false;
                ButtonThuongNhan.IsEnabled = false;
            }
            else if (Flags.CH == true)
            {

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
