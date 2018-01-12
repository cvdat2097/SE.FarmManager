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
    /// Interaction logic for ThemCayTrong.xaml
    /// </summary>
    public partial class ThemCayTrong : Window
    {
        public ThemCayTrong()
        {
            InitializeComponent();
        }

        private void Tro_Ve(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Close();
            m.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                con.Open();
                string tentv = TENTV.Text.ToString();
                string matv;
                string vitri = VITRI.Text.ToString();
                string tgcs = TGCS.Text.ToString();
                string vondautu = VONDAUTU.Text.ToString();

                if (tentv.Any(char.IsDigit) || !tgcs.Any(char.IsDigit) || !vondautu.Any(char.IsDigit))
                {
                    goto Dost;
                }
                i = 0;

                // Tạo mã Cay trong
                String quearyMATV = "select MAX(CONVERT(INT,RIGHT(MACTVN,3))) from CAYTRONGVATNUOI where MACTVN like 'TV%'";
                SqlCommand cmdMATV = new SqlCommand(quearyMATV, con);
                SqlDataAdapter sdaMATV = new SqlDataAdapter(cmdMATV);
                DataTable dtMATV = new DataTable("MaTV");
                sdaMATV.Fill(dtMATV);

                int currentMATV = dtMATV.Rows[0].Field<int>(0);
                currentMATV++;

                if (currentMATV >= 0 && currentMATV <= 9)
                {
                    matv = "TV00" + currentMATV.ToString();
                }
                else if (currentMATV >= 10 && currentMATV <= 99)
                {
                    matv = "TV0" + currentMATV.ToString();
                }
                else
                {
                    matv = "TV" + currentMATV.ToString();
                }

                // THEM CAY TRONG
                string queary = "insert into CAYTRONGVATNUOI values('" + matv + "','" + tentv + "','" + vitri + "','" + tgcs + "','" + vondautu + "')";
                SqlCommand sc = new SqlCommand(queary, con);
                sc.ExecuteNonQuery();


                // THEM VAO LICH SU HOAT DONG
                lib.ThemLog("Thêm Cây trồng: " + matv + " " + tentv);
                con.Close();

                if (i == 0)
                    goto ML;
            Dost: ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        // 01644 656 534
        ML:
            TENTV.Text = "";
            // MATV.Text = "";
            VITRI.Text = "";
            TGCS.Text = "";
            VONDAUTU.Text = "";
        }


    }
}
