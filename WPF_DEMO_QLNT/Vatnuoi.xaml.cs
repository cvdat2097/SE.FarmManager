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
    /// Interaction logic for Vatnuoi.xaml
    /// </summary>
    public partial class Vatnuoi : Window
    {
        public Vatnuoi()
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
            if (Flags.ND == true || Flags.CH == true)
            {
                this.Close();
                Lich L = new Lich();
                L.Show();
            }

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
        private void Mua(object sender, RoutedEventArgs e)
        {
            this.Close();
            ThemNgmua Th = new ThemNgmua();
            Th.Show();
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

       

        private void VATNUOI1_Initialized(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            string sc = "select * from CAYTRONGVATNUOI where CAYTRONGVATNUOI.MACTVN like 'DV%'";
            SqlCommand cd = new SqlCommand(sc, con);
            SqlDataAdapter sda = new SqlDataAdapter(cd);
            DataTable dt = new DataTable("VATNUOI");
            sda.Fill(dt);
            VATNUOI1.ItemsSource = dt.DefaultView;
        }

        private void ThemButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ThemVatNuoi R = new ThemVatNuoi();
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
            this.Close();
            MainWindow M = new MainWindow();
            M.Show();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
        }

        private void ButtonTroVe_Click(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Close();
            m.Show();
        }
    }
}
