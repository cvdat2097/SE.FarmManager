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
    /// Interaction logic for TK.xaml
    /// </summary>
    public partial class TK : Window
    {
        public TK()
        {
            InitializeComponent();
        }

        private void Tro_Ve(object sender, RoutedEventArgs e)
        {
            MainMenu M = new MainMenu();
            this.Close();
            M.Show();
        }


        private void Tim(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            
            if(ComboBoxSearch.Text.ToString()==ND.Content.ToString())
            {
                string key = SearchBox.Text.ToString();
                string sc = "select * from NONGDAN where NONGDAN.MAND='"+key+"' or NONGDAN.HOTEN like N'%"+key+"%'";
                SqlCommand cd = new SqlCommand(sc, con);
                SqlDataAdapter sda = new SqlDataAdapter(cd);
                DataTable dt = new DataTable("Search");
                sda.Fill(dt);
                SearchResult.ItemsSource = dt.DefaultView;
                
            }
            else
            {
                if(ComboBoxSearch.Text.ToString()==TN.Content.ToString())
                {
                    string key = SearchBox.Text.ToString();
                    string sc = "select * from THUONGNHAN where THUONGNHAN.MATN='" + key +"' or THUONGNHAN.HOTEN like N'%"+key+"%'";
                    SqlCommand cd = new SqlCommand(sc, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cd);
                    DataTable dt = new DataTable("Search");
                    sda.Fill(dt);
                    SearchResult.ItemsSource = dt.DefaultView;
                }
                else
                {
                    if (ComboBoxSearch.Text.ToString()==VN.Content.ToString())
                    {
                        string key = SearchBox.Text.ToString();
                        string sc = "select * from CAYTRONGVATNUOI where CAYTRONGVATNUOI.MACTVN='" + key + "' or CAYTRONGVATNUOI.TEN like N'%" + key + "%' or (CAYTRONGVATNUOI.VITRI= '"+key+"' and CAYTRONGVATNUOI.MACTVN like 'DV%')";
                        SqlCommand cd = new SqlCommand(sc, con);
                        SqlDataAdapter sda = new SqlDataAdapter(cd);
                        DataTable dt = new DataTable("Search");
                        sda.Fill(dt);
                        SearchResult.ItemsSource = dt.DefaultView;
                    }
                    else
                    {
                        if(ComboBoxSearch.Text.ToString()==CT.Content.ToString())
                        {
                            string key = SearchBox.Text.ToString();
                            string sc = "select * from CAYTRONGVATNUOI where CAYTRONGVATNUOI.MACTVN='" + key + "' or CAYTRONGVATNUOI.TEN like N'%" + key + "%' or (CAYTRONGVATNUOI.VITRI= '" + key + "'and CAYTRONGVATNUOI.MACTVN like 'TV%')";
                            SqlCommand cd = new SqlCommand(sc, con);
                            SqlDataAdapter sda = new SqlDataAdapter(cd);
                            DataTable dt = new DataTable("Search");
                            sda.Fill(dt);
                            SearchResult.ItemsSource = dt.DefaultView;
                        }
                    }
                }
            }
            con.Close();

        }
    }
}
