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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WPF_DEMO_QLNT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void DataGridDanhSachRuong_Initialized(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();
            String queary = "SELECT * FROM KHUVUC";
            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("KhuVuc");

            sda.Fill(dt);

            DataGridDanhSachRuong.ItemsSource = dt.DefaultView;
            con.Close();
        }

 


        private void Window_Initialized(object sender, EventArgs e)
        {
        }

        private void ButtonTroVe_Click(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Close();
            m.Show();
        }

        

    }
}
