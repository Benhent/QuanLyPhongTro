using QuanLyPhongTro.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class Frm_Login : Form
    {
        private BLL_HeThong bd;
        private string err = string.Empty;
        private DataTable dtUser;

        public Frm_Login()
        {
            InitializeComponent();
            string connectionString = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
            bd = new BLL_HeThong(connectionString);  // Khởi tạo đối tượng BLL_HeThong với chuỗi kết nối
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_User.Text))
            {
                if (!string.IsNullOrEmpty(txt_Pass.Text))
                {
                    if (KiemTraDangNhap(txt_User.Text, txt_Pass.Text))
                    {
                        ClsMain.tenUser = dtUser.Rows[0]["TaiKhoan"].ToString();
                        this.Hide();
                        Frm_Main frm_main = new Frm_Main();  // Tạo instance của Frm_Main
                        frm_main.ShowDialog();  // Hiển thị Frm_Main
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thong tin tai khoan khong dung");
                    }
                }
                else
                {
                    MessageBox.Show("Chua nhap Mat khau");
                }
            }
            else
            {
                MessageBox.Show("Chua nhap tai khoan");
            }

        }

        private bool KiemTraDangNhap(string userName, string password)
        {
            dtUser = new DataTable();
            dtUser = bd.KiemTraDangNhap(ref err, userName, password);
            if (dtUser.Rows.Count > 0)
            {
                if (dtUser.Rows[0]["Code"].ToString().Equals("1"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
