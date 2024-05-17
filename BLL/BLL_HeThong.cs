using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyPhongTro.BLL
{
    public class BLL_HeThong
    {
        MyDatabase db;
        public BLL_HeThong(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable KiemTraDangNhap(ref string err, string userName, string password)
        {
            byte[] matKhauBytes = Encoding.UTF8.GetBytes(password);
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoan",userName),
                new SqlParameter("@MatKhau",matKhauBytes)
            };
            return db.GetDataTable(ref err, "PSP_KiemTraDangNhap", CommandType.StoredProcedure, sqlParameters);
        }

    }

}
