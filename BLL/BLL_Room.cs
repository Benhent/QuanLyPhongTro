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
                 new SqlParameter("@TrangThai",room.GiaPhong),
           };
            return db.MyExcuteNonQuery(ref err, "PSP_Room_InsertOrUpdate", CommandType.StoredProcedure, sqlparameter);

        }

        public int XoaPhong(ref string err, string maPhong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaP", maPhong)
            };

            return db.MyExcuteNonQuery(ref err, "PSP_User_Delete", CommandType.StoredProcedure, sqlParameters);
        }
    }
}
