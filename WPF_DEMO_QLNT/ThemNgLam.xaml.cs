﻿using System;
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
namespace WPF_DEMO_QLNT
{
    /// <summary>
    /// Interaction logic for ThemNgLam.xaml
    /// </summary>
    public partial class ThemNgLam : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");

        public ThemNgLam()
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
            try
            {
                con.Open();
                string name = HOTEN.Text.ToString();
                string MaNLam;
                string SDT = DT.Text.ToString();
                string GTinh = GT.Text.ToString();
                string CMND = CM.Text.ToString();
                string ngsi = NS.Text.ToString();
                string DIC = DC.Text.ToString();
                string LICH = MALICH.Text.ToString();
                string Luog = LUONG.Text.ToString();

                SqlCommand sc = new SqlCommand("insert into NONGDAN values('" + name + "','" + GTinh + "','" + SDT + "','" + CMND + "','" + ngsi + "','" + DIC + "','" + Luog + "','" + LICH + "')", con);
                sc.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            HOTEN.Text = "";
            //MANL.Text = "";
            DT.Text = "";
            GT.Text = "";
            CM.Text = "";
            NS.Text = "";
            DC.Text = "";
            MALICH.Text = "";
            LUONG.Text = "";
        }


    }
}
