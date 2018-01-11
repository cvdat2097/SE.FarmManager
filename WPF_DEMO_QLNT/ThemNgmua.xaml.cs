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
    /// Interaction logic for ThemNgmua.xaml
    /// </summary>
    public partial class ThemNgmua : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");

        public ThemNgmua()
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
                string name = textboxHoTen.Text.ToString();
                string MaNMua;
                string Ab = SDT.Text.ToString();
                string GT = GTinh.Text.ToString();
                string CM = CMND.Text.ToString();
                string ngsi = NGS.Text.ToString();
                string DIC = DC.Text.ToString();
                string SAP = SP.Text.ToString();

                SqlCommand sc = new SqlCommand("insert into THUONGNHAN values('" + name + "','" + GT + "','" + Ab + "','" + CM + "','" + ngsi + "','" + DIC + "','" + SAP + "')", con);
                sc.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textboxHoTen.Text = "";
            SDT.Text = "";
            NGS.Text = "";
            DC.Text = "";
            CMND.Text = "";
            SP.Text = "";
            GTinh.Text = "";
            //MANM.Text = "";

        }


    }
}