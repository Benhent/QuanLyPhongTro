using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DTO
{
    public class User
    {
        public int ID { get; set;}
        public string HoTen { get; set;}
        public bool Phai { get; set; }
        public string DienThoai { get; set; }
        public string TaiKhoan { get; set; }
        public byte[] MatKhau { get; set;}
    }
}
