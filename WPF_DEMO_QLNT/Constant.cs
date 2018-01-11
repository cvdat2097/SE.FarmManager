using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DEMO_QLNT
{
    static class Constant
    {
        // Ten Server
        //public static string _SERVER_NAME_ = Environment.MachineName + @"\SQLEXPRESS";
        public static string _SERVER_NAME_ = @"BAMPC\SQLEXPRESS";

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

}
