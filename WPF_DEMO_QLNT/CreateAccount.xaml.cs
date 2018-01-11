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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();

            string passCu = passcu.Text.ToString();
            string passMoi = passmoi.Text.ToString();
            string XNpassMoi = xacnhanpassmoi.Text.ToString();
            String M = "";

            String N = "";
            if(Flags.ND==true)
            {
                N = "SELECT MATKHAU FROM NONGDAN WHERE MAND= '" + Flags.MaND + "'";
            }
            else if(Flags.TN==true)
            {
                N = "SELECT MATKHAU FROM THUONGNHAN WHERE MATN= '" + Flags.MaTN + "'";
            }
            else if(Flags.CH==true)
            {
                N = "SELECT MATKHAU FROM CHUNONGTRAI WHERE MACNT= '" + Flags.MaCH + "'";
            }
            SqlCommand cmd1 = new SqlCommand(N, con);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable("N");
            sda1.Fill(dt1);

            string newpass = dt1.Rows[0].Field<string>(0);
            if(passMoi==passCu)
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ", "ERROR!!!", MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else if (newpass == passCu)
            {
                if (passMoi == XNpassMoi)
                {
                    
                    if (Flags.ND == true)
                    {
                        M = "UPDATE NONGDAN SET MATKHAU = '" + passMoi + "' WHERE MAND = '" + Flags.MaND + "'";
                    }
                    if (Flags.TN == true)
                    {
                        M = "UPDATE THUONGNHAN SET MATKHAU = '" + passMoi + "' WHERE MATN = '" + Flags.MaTN + "'";
                    }
                    if (Flags.CH == true)
                    {
                        M = "UPDATE CHUNONGTRAI SET MATKHAU = '" + passMoi + "' WHERE MACNT = '" + Flags.MaCH + "'";
                    }
                    SqlCommand cmd = new SqlCommand(M, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo!!!", MessageBoxButton.OK,MessageBoxImage.Asterisk);

                    passcu.Text="";
                    passmoi.Text = "";
                    xacnhanpassmoi.Text = "";
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không giống!!!", "ERROR!!!", MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!!!", "ERROR!!!", MessageBoxButton.OK,MessageBoxImage.Error);
            }


            con.Close();

        }

        private void xacnhanpassmoi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(xacnhanpassmoi, null);
                MainMenu m = new MainMenu();
                m.Show();
                this.Close();
            }

        }
    }
}
