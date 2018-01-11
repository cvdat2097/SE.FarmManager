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
    /// Interaction logic for Danh_sach_Tn.xaml
    /// </summary>
    public partial class Danh_sach_Tn : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");

        public Danh_sach_Tn()
        {
            InitializeComponent();
            fillcombobox();
        }

        void fillcombobox()
        {
            string Q = "select * from THUONGNHAN";
            SqlCommand cmdd = new SqlCommand(Q, con);

            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmdd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    DSTN.Items.Add(name);

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                string name = DSTN.Text.ToString();
                SqlCommand sc = new SqlCommand("delete from THUONGNHAN where MATN ='" + DSTN.Text + "'", con);
                sc.ExecuteNonQuery();
                DSTN.Items.Remove(DSTN.Text);
                //THONGTINRUONG.Items.Clear();
                MANM.Text = "";
                textboxHoTen.Text = "";

                GTinh.Text = "";
                SDT.Text = "";
                CMND.Text = ""; ;
                NGS.Text = "";
                DC.Text = "";

                SP.Text = "";



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowDSTN(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                con.Open();
                String queary = "SELECT * FROM THUONGNHAN where MATN ='" + DSTN.Text + "'";
                SqlCommand cmd = new SqlCommand(queary, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ThuongNhan");
                sda.Fill(dt);

                MANM.Text = dt.Rows[0].Field<string>(0);
                textboxHoTen.Text = dt.Rows[0].Field<string>(1);
                GTinh.Text = dt.Rows[0].Field<string>(2);
                SDT.Text = dt.Rows[0].Field<string>(3);
                CMND.Text = dt.Rows[0].Field<string>(4);
                NGS.Text = (dt.Rows[0].Field<DateTime>(5)).ToString();


                DC.Text = dt.Rows[0].Field<string>(6);

                SP.Text = dt.Rows[0].Field<string>(7);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
