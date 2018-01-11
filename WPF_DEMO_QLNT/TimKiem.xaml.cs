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

namespace WPF_DEMO_QLNT
{
    /// <summary>
    /// Interaction logic for TimKiem.xaml
    /// </summary>
    public partial class TimKiem : Window
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void Lich(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Lich L = new Lich();
            /// TimKiem Tk = new TimKiem();
            L.Show();
        }

        private void Chi_Phi(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Chiphi Cp = new Chiphi();
            Cp.Show();
        }
        private void Cay_Trong(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Caytrong Cp = new Caytrong();
            Cp.Show();
        }
        private void Khac(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Khac Cp = new Khac();
            Cp.Show();
        }
        private void Vat_Nuoi(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vatnuoi Cp = new Vatnuoi();
            Cp.Show();
        }
        private void Them(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ThemNgLam Th = new ThemNgLam();
            Th.Show();
        }
        private void Mua(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ThemNgmua Th = new ThemNgmua();
            Th.Show();
        }

        private void TN(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Danh_sach_Tn T = new Danh_sach_Tn();
            T.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Danh_sach_nglam Ds = new Danh_sach_nglam();
            Ds.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Ruong R = new Ruong();
            R.Show();
        }
    }
}
