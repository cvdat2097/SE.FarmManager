using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WPF_DEMO_QLNT
{
    static class Constant
    {
        // Ten Server
        public static string _SERVER_NAME_ = Environment.MachineName + @"\SQLEXPRESS";
        //public static string _SERVER_NAME_ = @"DESKTOP-020JKQK";

        // Ten CSDL
        public static string _DBNAME_ = "QUANLYNONGTRAI";

        // Ten dang nhap
        public static string _USERNAME_ = "sa";

        // Mat khau
        public static string _PASSWORD_ = "123456";

        // Tien luong gio
        public static string _LUONG_GIO_ = "20000";
    }

    static class Flags
    {
        public static bool CH = false;
        public static bool ND = false;
        public static bool TN = false;

        public static string MaCH;
        public static string MaND;
        public static string MaTN;
    }


    static class lib
    {
        public static void ThemLog(string s)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + Constant._SERVER_NAME_ + ";Initial Catalog=" + Constant._DBNAME_ + ";Integrated Security=True");
            con.Open();

            String queary = @"insert into HDGD(TENHD) values (N'" + s + "')";

            SqlCommand cmd = new SqlCommand(queary, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();


            con.Close();
        }
    }
}
