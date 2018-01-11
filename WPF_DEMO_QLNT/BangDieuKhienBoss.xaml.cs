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
    /// Interaction logic for BangDieuKhienBoss.xaml
    /// </summary>
    public partial class BangDieuKhienBoss : Window
    {
        public BangDieuKhienBoss()
        {
            InitializeComponent();
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

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_Initialized(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            String queary = "SELECT * FROM DONDATHANG";
            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("KhuVuc");

            sda.Fill(dt);

            //DatagridDonDatHang.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void ButtonTinhLuong_Click(object sender, RoutedEventArgs e)
        {
            // Tính lương
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                con.Open();

                string queary = "update NONGDAN set LUONG = GIOCONG * " + Constant._LUONG_GIO_;
                SqlCommand sc = new SqlCommand(queary, con);
                sc.ExecuteNonQuery();

                MessageBox.Show("Tính lương thành công!");
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

        private void ButtonGiaoDich_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
