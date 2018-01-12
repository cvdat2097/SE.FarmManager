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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonVatNuoi_Click(object sender, RoutedEventArgs e)
        {
            Vatnuoi m = new Vatnuoi();
            this.Close();
            m.Show();
        }

        private void ButtonCayTrong_Click(object sender, RoutedEventArgs e)
        {
            Caytrong m = new Caytrong();
            this.Close();
            m.Show();
        }

        private void ButtonRuong_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Close();
            m.Show();
        }

        private void ButtonNongDan_Click(object sender, RoutedEventArgs e)
        {
            Danh_sach_nglam m = new Danh_sach_nglam();
            this.Close();
            m.Show();
        }

        private void ButtonThuongNhan_Click(object sender, RoutedEventArgs e)
        {
            Danh_sach_Tn m = new Danh_sach_Tn();
            this.Close();
            m.Show();
        }

        private void ButtonDonHang_Click(object sender, RoutedEventArgs e)
        {
            BangDieuKhienBoss m = new BangDieuKhienBoss();
            this.Close();
            m.Show();
        }

        private void ButtonThemRuong_Click(object sender, RoutedEventArgs e)
        {
            Ruong m = new Ruong();
            this.Close();
            m.Show();
        }

        private void ButtonThemVatNuoi_Click(object sender, RoutedEventArgs e)
        {
            ThemVatNuoi m = new ThemVatNuoi();
            this.Close();
            m.Show();
        }

        private void ButtonThemCayTrong_Click(object sender, RoutedEventArgs e)
        {
            ThemCayTrong m = new ThemCayTrong();
            this.Close();
            m.Show();
        }

        private void ButtonThemNongDan_Click(object sender, RoutedEventArgs e)
        {
            ThemNgLam m = new ThemNgLam();
            this.Close();
            m.Show();
        }

        private void ButtonThemThuongNhan_Click(object sender, RoutedEventArgs e)
        {
            ThemNgmua m = new ThemNgmua();
            this.Close();
            m.Show();
        }

        private void ButtonTimKiem_Click(object sender, RoutedEventArgs e)
        {
            TK m = new TK();
            this.Close();
            m.Show();
        }

        private void ButtonLich_Click(object sender, RoutedEventArgs e)
        {
            Lich m = new Lich();
            this.Close();
            m.Show();
        }

        private void ButtonBangDieuKhienThuongNhan_Click(object sender, RoutedEventArgs e)
        {
            BangDieuKhienThuongNhan m = new BangDieuKhienThuongNhan();
            this.Close();
            m.Show();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            TabItemBoss.IsEnabled = Flags.CH;
            GridBoss.IsEnabled = Flags.CH;
            TabItemNongDan.IsEnabled = Flags.ND;
            GridNongDan.IsEnabled = Flags.ND;
            TabItemThuongNhan.IsEnabled = Flags.TN;
            GridThuongNhan.IsEnabled = Flags.TN;

            if (Flags.CH == true)
            {
                TabControlMain.SelectedIndex = 0;
            }
            if (Flags.ND == true)
            {
                TabControlMain.SelectedIndex = 1;
            }
            if (Flags.TN == true)
            {
                TabControlMain.SelectedIndex = 2;
            }
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận!!!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Flags.CH = false;
                Flags.ND = false;
                Flags.TN = false;

                Dangnhap m = new Dangnhap();
                this.Close();
                m.Show();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount M = new CreateAccount();
            this.Close();
            M.Show();
        }

        private void Label_Initialized(object sender, EventArgs e)
        {
            if (Flags.ND == true)
                IDdangnhap.Content = Flags.MaND;
            else if (Flags.TN == true)
                IDdangnhap.Content = Flags.MaTN;
            else if (Flags.CH == true)
                IDdangnhap.Content = Flags.MaCH;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            string insertmess = nhapMess.Text.ToString();
            String M = "";
            if (insertmess != "")
            {
                if (Flags.CH == true)
                {
                    M = "INSERT INTO CHAT (NOIDUNG) VALUES ( '" + Flags.MaCH.ToString() + " : " + insertmess + " ')";
                }
                else if (Flags.ND == true)
                {
                    M = "INSERT INTO CHAT (NOIDUNG) VALUES ('" + Flags.MaND.ToString() + " : " + insertmess + " ')";
                }
                else if (Flags.TN == true)
                {
                    M = "INSERT INTO CHAT (NOIDUNG) VALUES ('" + Flags.MaTN.ToString() + " : " + insertmess + " ')";
                }
            }
            SqlCommand cmd1 = new SqlCommand(M, con);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable("M");
            cmd1.ExecuteNonQuery();
            con.Close();

            nhapMess.Text = "";
        }



        private void nhapMess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (guiMess.Focus())
                {
                    Button_Click_1(sender, null);
                    nhapMess.Text = string.Empty;
                    nhapMess.Focus();
                }
                // this.Close();
            }
        }

        private void listMess_Initialized(object sender, EventArgs e)
        {

        }
    }
}

