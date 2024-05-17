﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.BLL
{
    public class BLL_Customer
    {
        internal MyDatabase db;
        public BLL_Customer(string path) 
        {
            db = new MyDatabase(path);
        }

        public DataTable DanhSachCustomer(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_Customer_Select", CommandType.StoredProcedure, null);
        }

        public int CapNhatCustomer(ref string err, Customer customer)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@MaKH",customer.MaKH),
                new SqlParameter("@HoTenKH", customer.HoTenKH),
                 new SqlParameter("@GioiTinhKH", customer.GioiTinhKH),
                  new SqlParameter("@NgaySinh",customer.NgaySinh),
                   new SqlParameter("@QueQuan",customer.QueQuan),
                    new SqlParameter("@SDT",customer.SDT),
                     new SqlParameter("@SoThangThue",customer.SoThangThue),
                      new SqlParameter("@MaP",customer.MaP),
           };
            return db.MyExcuteNonQuery(ref err, "PSP_Customer_InsertAndUpdate", CommandType.StoredProcedure, sqlparameter);
        }

        public int XoaCustomer(ref string err, Customer customer)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
               new SqlParameter("@MaKH",customer.MaKH)
           };
            return db.MyExcuteNonQuery(ref err, "PSP_Customer_Delete", CommandType.StoredProcedure, sqlparameter);
        }
    }
}
