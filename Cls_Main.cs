using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public class ClsMain
    {
        public static string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        public static string tenUser = string.Empty;

        public static Hashtable hsQuyenByUser = new Hashtable();

        public static bool CheckQuyen(Form frm, QUYEN quyen)
        {
            foreach (string key in hsQuyenByUser.Keys)
            {
                if (key.Equals(frm.Name))
                {
                    return (Convert.ToInt32(hsQuyenByUser[key].ToString()) & ((int)quyen)) == ((int)quyen) ? true : false;
                }
            }
            return false;
        }

    }
}
