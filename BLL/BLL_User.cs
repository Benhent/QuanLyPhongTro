using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.BLL
{
    public class BLL_User
    {
        internal MyDatabase _db;

        public BLL_User(String path)
        {
            _db = new MyDatabase(path);
        }

        public DataTable DanhSachUser(ref string err)
        {
            return _db.GetDataTable(ref err, "PSP_User_Select", CommandType.StoredProcedure, null);
        }

        public int CapNhatUser(ref string err, User user)
        {
            byte[] hashedPassword = HashPassword(Encoding.UTF8.GetString(user.MatKhau), _db, ref err);

            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@ID",user.ID),
                new SqlParameter("@HoTen",user.HoTen),
                 new SqlParameter("@Phai",user.Phai),
                  new SqlParameter("@DienThoai",user.DienThoai),
                   new SqlParameter("@TaiKhoan",user.TaiKhoan),
                    new SqlParameter("@MatKhau",user.MatKhau),
                     new SqlParameter("@GroupID",user.GroupID)
           };
            return _db.MyExcuteNonQuery(ref err, "PSP_User_InsertAndUpdate", CommandType.StoredProcedure, sqlparameter);

        }

        public static byte[] HashPassword(string password, MyDatabase _db, ref string err)
        {
            // Thực hiện băm mật khẩu sử dụng hàm PWDENCRYPT của SQL Server
            string query = "SELECT PWDENCRYPT(@Password)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Password", password)
            };
            DataTable result = _db.GetDataTable(ref err, query, CommandType.Text, parameters);

            // Trả về mật khẩu đã được băm dưới dạng byte[]
            return result.Rows.Count > 0 ? (byte[])result.Rows[0][0] : null;
        }

        public int XoaUser(ref string err, User user)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@ID",user.ID)
            };
            return _db.MyExcuteNonQuery(ref err, "PSP_User_Delete", CommandType.StoredProcedure, sqlparameter);
        }

    }
}
