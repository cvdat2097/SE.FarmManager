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
    /// Interaction logic for Ruong.xaml
    /// </summary>
    public partial class Ruong : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");


        public Ruong()
        {
            InitializeComponent();
            fillcombobox();
        }


        void fillcombobox()
        {

            string Q = "select * from KHUVUC";
            SqlCommand cmdd = new SqlCommand(Q, con);

            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmdd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    THONGTINRUONG.Items.Add(name);

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
            this.Close();
            MainWindow M = new MainWindow();
            M.Show();
        }

        private void Themruong_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                string name = TENKV.Text.ToString();

                string DT = DACTINH.Text.ToString();
                string SS = S.Text.ToString();

                SqlCommand sc = new SqlCommand("insert into KHUVUC ( DACTINH, TENKV, DIENTICH)  values('" + DT + "','" + name + "','" + SS + "')", con);
                sc.ExecuteNonQuery();
                THONGTINRUONG.Items.Add(MAKHUCVUC.Text);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TENKV.Text = "";
            MAKHUCVUC.Text = "";
            DACTINH.Text = "";
            S.Text = "";

            // THEM CONG VIEC
            try
            {
                con.Open();

                SqlCommand sc = new SqlCommand("insert into CONGVIEC (TENCV,THOIGIAN,VITRI)  values(N'Chăm sóc',15, (select MAX(MAKV) from KHUVUC))", con);
                sc.ExecuteNonQuery();
                SqlCommand sc1 = new SqlCommand("insert into CONGVIEC (TENCV,THOIGIAN,VITRI)  values(N'Thu hoạch',5, (select MAX(MAKV) from KHUVUC))", con);
                sc1.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Xoaruong_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                string name = MAKHUCVUC.Text.ToString();
                SqlCommand sc = new SqlCommand("delete from KHUVUC where MAKV ='" + MAKHUCVUC.Text + "'", con);
                sc.ExecuteNonQuery();
                THONGTINRUONG.Items.Remove(MAKHUCVUC.Text);
                //THONGTINRUONG.Items.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MAKHUCVUC.Text = "";
            TENKV.Text = "";
            S.Text = "";
            DACTINH.Text = "";

        }

        private void THONGTINRUONG_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                con.Open();
                String queary = "SELECT * FROM KHUVUC where MAKV ='" + THONGTINRUONG.Text + "'";
                SqlCommand cmd = new SqlCommand(queary, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("KhuVuc");
                sda.Fill(dt);

                MAKHUCVUC.Text = dt.Rows[0].Field<string>(0);
                TENKV.Text = dt.Rows[0].Field<string>(2);
                DACTINH.Text = dt.Rows[0].Field<string>(1);
                S.Text = dt.Rows[0].Field<string>(3);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TENKV.Text = "";
            MAKHUCVUC.Text = "";
            DACTINH.Text = "";
            S.Text = "";
        }

    }
}



