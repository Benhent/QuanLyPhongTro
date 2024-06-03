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


        #region Phân Quyền
        public DataTable LayDSGroupUser(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_GroupUser_SelectToCombo", CommandType.StoredProcedure, null);
        }

        public DataTable LayDSFunctionsByUser(ref string err, string groupID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
         new SqlParameter("@GroupID",groupID)
            };
            return db.GetDataTable(ref err, "PSP_PhanQuyen_SelectToGrid", CommandType.StoredProcedure, sqlParameters);
        }

        public int CapNhatPhanQuyen(ref string err, string funcId, string groupId, int tong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@GroupID",groupId),
                    new SqlParameter("@FuncID",funcId),
                        new SqlParameter("@Total",tong)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_PhanQuyen_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable LayDanhSachQuyen(ref string err, string ID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ID",ID)
            };
            return db.GetDataTable(ref err, "PSP_PhanQuyen_Select", CommandType.StoredProcedure, sqlParameters);
        }
        #endregion
    }

}
