using QuanLyPhongTro.DTO;
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
    public partial class Frm_QuanLyUser_modi : Form
    {
        public bool isAdd = false;
        //Lưu thông tin khách hàng cho trường hợp sửa
        public User _user;
        // Biến lưu đường dẫn file chứa chuỗi kết nối
        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        // khai báo biến để lưu lỗi
        string err = string.Empty;
        // Khai báo đối tương của lớp BusinessLayer
        BLL_User _bd;

        public Frm_QuanLyUser_modi()
        {
            InitializeComponent();
        }

        private void Frm_QuanLyUser_modi_Load(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng BusinessLayer
            _bd = new BLL_User(path);
            cbPhai.Items.Add("Nam");
            cbPhai.Items.Add("Nữ");


            if (isAdd)
            {
                txtID.Text = "0";
                cbPhai.SelectedIndex = 0;
                txtHoTen.Focus();
            }
            else
            {
                //Trường hợp sửa thông tin người dùng
                txtID.Text = _user.ID.ToString();
                txtHoTen.Text = _user.HoTen;
                cbPhai.SelectedItem = _user.Phai ? "Nam":"Nữ";
                txtDienThoai.Text = _user.DienThoai;
                txtTaiKhoan.Text = _user.TaiKhoan;
                //Chuyển đổi MatKhau từ mảng byte về chuỗi
                txtMatKhau.Text = Encoding.UTF8.GetString(_user.MatKhau);
                txtRole.Text = _user.GroupID.ToString();
                txtHoTen.Focus();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text))
            {
                try
                {   // Đọc giá trị combobox và chuyển thành bool
                    bool phai = cbPhai.SelectedItem.ToString() == "Nam";
                    // Chuyển đổi MatKhau từ chuỗi sang byte
                    //byte[] matKhauBytes = Encoding.UTF8.GetBytes(txtMatKhau.Text);
                    byte[] matKhauBytes = BLL_User.HashPassword(txtMatKhau.Text, _bd._db, ref err);
                    // Khởi tạo đối tượng người dùng và gán giá trị trên control vào đối tượng User
                    _user = new User()
                    {
                        ID = int.Parse(txtID.Text),
                        HoTen = txtHoTen.Text,
                        Phai = phai,
                        DienThoai = txtDienThoai.Text,
                        TaiKhoan = txtTaiKhoan.Text,
                        MatKhau = matKhauBytes,
                        GroupID = int.Parse(txtRole.Text)
                    };

                    // Gọi phương thức cập nhật thông tin người dùng từ đối tượng BusinessLayer (bd)
                    // Nếu phương thức trả về giá trị > 0 thì cập nhật thành công
                    if (_bd.CapNhatUser(ref err, _user) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công: " + err);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID không hợp lệ. Vui lòng kiểm tra lại.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên người dùng");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
