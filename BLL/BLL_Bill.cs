using QuanLyPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Bill
    {
        internal MyDatabase db;
        public BLL_Bill(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable DanhSachBill(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_Bill_Select", CommandType.StoredProcedure, null);
        }

        public int CapNhatBill(ref string err, Bill bill)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@MaHD", bill.MaHD),
                new SqlParameter("@TienDien", bill.TienDien),
                 new SqlParameter("@TienNuoc", bill.TienNuoc),
                  new SqlParameter("@TongTien", bill.TongTien),
                   new SqlParameter("@MaKH",bill.MaKH)
                  
           };
            return Int32.Parse(db.GetDataTable(ref err, "PSP_Bill_InsertAndUpdate", CommandType.StoredProcedure, sqlparameter).Rows[0]["TotalRowChanged"].ToString());
        }

        public int XoaBill(ref string err, Bill bill)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@MaHD",bill.MaHD)
           };
            return db.MyExcuteNonQuery(ref err, "PSP_Bill_Delete", CommandType.StoredProcedure, sqlparameter);
        }

        public DataTable LayMaKH(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_BillCustomer_SelectToCombo", CommandType.StoredProcedure, null);
        }

        public DataTable CapNhatGiaP(string MaKH, ref string err)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                new SqlParameter("@MaKH", MaKH)
            };
            return db.GetDataTable(ref err, "PSP_BillPhong_UpdateToTextbox", CommandType.StoredProcedure, sqlParameters);
        }

    }
}
