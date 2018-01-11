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
    /// Interaction logic for Dangnhap.xaml
    /// </summary>
    public partial class Dangnhap : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");

        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                string Id = user.Text.ToString();
                string passs = pass.Text.ToString();
                string M = "select MATKHAU from NONGDAN where MAND = '" + Id + "'";
                string M1 = "select MATKHAU from THUONGNHAN where MATN = '" + Id + "'";
                string M2 = "select MATKHAU from CHUNONGTRAI where MACNT = '" + Id + "'";


                switch (Id[0])
                {
                    case 'N':
                        {
                            SqlCommand cmd = new SqlCommand(M, con);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable("M");
                            sda.Fill(dt);
                            string newpass = dt.Rows[0].Field<string>(0);
                            if (passs == newpass)
                            {
                                Flags.ND = true;
                                MessageBox.Show("Đăng nhập thành công!!");
                                Flags.MaND = Id;

                            }
                            break;
                        }
                    case 'T':
                        {
                            SqlCommand cmd1 = new SqlCommand(M1, con);
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                            DataTable dt1 = new DataTable("M");
                            sda1.Fill(dt1);
                            string newpass1 = dt1.Rows[0].Field<string>(0);
                            if (passs == newpass1)
                            {
                                Flags.TN = true;
                                Flags.MaTN = Id;
                                MessageBox.Show("Đăng nhập thành công!!");

                            }
                            break;
                        }
                    case 'C':
                        {
                            SqlCommand cmd2 = new SqlCommand(M2, con);
                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable("M2");
                            sda2.Fill(dt2);
                            string newpass2 = dt2.Rows[0].Field<string>(0);
                            if (passs == newpass2)
                            {
                                Flags.CH = true;
                                Flags.MaCH = Id;
                                MessageBox.Show("Đăng nhập thành công!!");
                            }
                            break;
                        }
                }

                if (Flags.ND == false && Flags.TN == false && Flags.CH == false)
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng! Xin vui lòng thử lại!!");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên người dùng không đúng! Xin vui lòng kiểm tra lại!");
            }


            // Chuyen cua so
            if (Flags.CH == true || Flags.ND == true || Flags.TN == true)
            {

                MainMenu R = new MainMenu();
                this.Close();
                R.Show();
            }

        }

        private void pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Dn_Click(pass, null);
            }
        }


    }
}
