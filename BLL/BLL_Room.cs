using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Room
    {
        public MyDatabase db;
        public BLL_Room(string path)
        {
            db = new MyDatabase(path);
        }

        //phuong thuc lay ds khach hang
        public DataTable LayDSPhong(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_Room_Select", CommandType.StoredProcedure, null);
        }

        public int CapNhatPhong(ref string err, Room room)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@MaP",room.MaP),
                new SqlParameter("@GiaPhong",room.GiaPhong),
                 new SqlParameter("@TrangThai",room.TrangThai),
            };
            
            return Int32.Parse(db.GetDataTable(ref err, "PSP_Room_InsertOrUpdate", CommandType.StoredProcedure, sqlparameter).Rows[0]["TotalRowChanged"].ToString());

        }

        public int XoaPhong(ref string err, Room room)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaP", room.MaP)
            };

            return db.MyExcuteNonQuery(ref err, "PSP_Room_Delete", CommandType.StoredProcedure, sqlParameters);
        }

        public bool CheckTrangThaiPhong(ref string err, Room room)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaP", room.MaP)
            };

            DataTable dt = db.GetDataTable(ref err, "PSP_Room_CheckStatus", CommandType.StoredProcedure, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                string status = dt.Rows[0]["TrangThai"].ToString();
                return status != "Đã hết";
            }
            return false;
        }

    }
}
