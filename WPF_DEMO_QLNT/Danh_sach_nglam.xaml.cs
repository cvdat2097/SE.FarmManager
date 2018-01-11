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
    /// Interaction logic for Danh_sach_nglam.xaml
    /// </summary>
    public partial class Danh_sach_nglam : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");

        public Danh_sach_nglam()
        {
            InitializeComponent();
            fillcombobox();
        }
        void fillcombobox()
        {
            string Q = "select * from NONGDAN";
            SqlCommand cmdd = new SqlCommand(Q, con);

            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmdd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    DSNLCOMBO.Items.Add(name);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Tro_Ve(object sender, RoutedEventArgs e)
        {
            MainMenu M = new MainMenu();
            this.Close();
            M.Show();
        }

        private void SHOWDSNL(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                con.Open();
                String queary = "SELECT * FROM NONGDAN where MAND ='" + DSNLCOMBO.Text + "'";
                SqlCommand cmd = new SqlCommand(queary, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Nongdan");
                sda.Fill(dt);

                MANL.Text = dt.Rows[0].Field<string>(0);
                HOTEN.Text = dt.Rows[0].Field<string>(1);
                GT.Text = dt.Rows[0].Field<string>(2);
                DT.Text = dt.Rows[0].Field<string>(3);
                CM.Text = dt.Rows[0].Field<string>(4);
                NS.Text = (dt.Rows[0].Field<DateTime>(5)).ToString();
                DC.Text = dt.Rows[0].Field<string>(6);
                LUONG.Text = (dt.Rows[0].Field<Double>(7)).ToString();
                MALICH.Text = dt.Rows[0].Field<string>(8);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                string name = DSNLCOMBO.Text.ToString();
                SqlCommand sc = new SqlCommand("delete from NONGDAN where MAND ='" + DSNLCOMBO.Text + "'", con);
                sc.ExecuteNonQuery();
                DSNLCOMBO.Items.Remove(DSNLCOMBO.Text);
                //THONGTINRUONG.Items.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MANL.Text = "";
            HOTEN.Text = "";
            GT.Text = "";
            DT.Text = "";
            CM.Text = "";
            NS.Text = "";
            DC.Text = "";
            LUONG.Text = "";
            MALICH.Text = "";
        }
    }
}
