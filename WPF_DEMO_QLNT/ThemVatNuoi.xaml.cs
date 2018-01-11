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
    /// Interaction logic for ThemVatNuoi.xaml
    /// </summary>
    public partial class ThemVatNuoi : Window
    {
        public ThemVatNuoi()
        {
            InitializeComponent();
        }

        private void Tro_Ve(object sender, RoutedEventArgs e)
        {
            MainMenu M = new MainMenu();
            this.Close();
            M.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
                con.Open();
                string tendv = TENDV.Text.ToString();
                string madv;
                string vitri = VITRI.Text.ToString();
                string tgcs = TGCS.Text.ToString();
                string vondautu = VONDAUTU.Text.ToString();
                if(tendv.Any(char.IsDigit)|| !tgcs.Any(char.IsDigit) ||!vondautu.Any(char.IsDigit))
                {
                    goto Dost;
                }

                i = 0;
                // Tạo mã Vật nuôi
                String quearyMADV = "select MAX(CONVERT(INT,RIGHT(MACTVN,3))) from CAYTRONGVATNUOI where MACTVN like 'DV%'";
                SqlCommand cmdMADV = new SqlCommand(quearyMADV, con);
                SqlDataAdapter sdaMADV = new SqlDataAdapter(cmdMADV);
                DataTable dtMADV = new DataTable("MaDV");
                sdaMADV.Fill(dtMADV);

                int currentMADV = dtMADV.Rows[0].Field<int>(0);
                currentMADV++;

                if (currentMADV >= 0 && currentMADV <= 9)
                {
                    madv = "DV00" + currentMADV.ToString();
                }
                else if (currentMADV >= 10 && currentMADV <= 99)
                {
                    madv = "DV0" + currentMADV.ToString();
                }
                else
                {
                    madv = "DV" + currentMADV.ToString();
                }




                // Them vao CAYTRONGVATNUOI
                string queary = "insert into CAYTRONGVATNUOI values('" + madv + "','" + tendv + "','" + vitri + "','" + tgcs + "','" + vondautu + "')";
                SqlCommand sc = new SqlCommand(queary, con);
                sc.ExecuteNonQuery();

                // THEM VAO LICH SU HOAT DONG
                queary = "insert into HDGD(TENHD) values('Them Vat nuoi " + tendv + "')";
                SqlCommand cmd = new SqlCommand(queary, con);
                cmd.ExecuteNonQuery();

                con.Close();
                if (i == 0)
                    goto ML;
            Dost:;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xin kiểm tra lại dữ liệu nhập!");
            }
            ML :
            TENDV.Text = "";
           // MADV.Text = "";
            VITRI.Text = "";
            TGCS.Text = "";
            VONDAUTU.Text = "";
        }
    }
}
