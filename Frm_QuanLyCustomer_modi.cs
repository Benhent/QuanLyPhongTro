using QuanLyPhongTro.BLL;
using QuanLyPhongTro.DTO;
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
    public partial class Frm_QuanLyCustomer_modi : Form
    {
        public bool isAdd = false;
        //Lưu thông tin khách hàng cho trường hợp sửa
        public Customer _customer;
        // Biến lưu đường dẫn file chứa chuỗi kết nối
        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        // khai báo biến để lưu lỗi
        string err = string.Empty;
        // Khai báo đối tương của lớp BusinessLayer
        BLL_Customer _bd;

        public Frm_QuanLyCustomer_modi()
        {
            InitializeComponent();
        }

        private void Frm_QuanLyCustomer_modi_Load(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng BusinessLayer
            _bd = new BLL_Customer(path);
            cbPhai.Items.Add("Nam");
            cbPhai.Items.Add("Nữ");


            if (isAdd)
            {
                txtMaKh.Text = "0";
                cbPhai.SelectedIndex = 0;
                txtHoTen.Focus();
            }
            else
            {
                //Trường hợp sửa thông tin người dùng
                txtMaKh.Text = _customer.MaKH;
                txtHoTen.Text = _customer.HoTenKH;
                cbPhai.SelectedItem = _customer.GioiTinhKH;
                txtSDT.Text = _customer.SDT;
                txtSoTT.Text = _customer.SoThangThue.ToString();
                txtMaPhong.Text = _customer.MaP;
                txtHoTen.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text))
            {
                try
                {
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    if (ngaySinh > DateTime.Now)
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng chọn một ngày trong quá khứ.");
                        return;
                    }
                    int soThangThue;
                    if (!int.TryParse(txtSoTT.Text, out soThangThue) || soThangThue <= 0)
                    {
                        MessageBox.Show("Số tháng thuê không hợp lệ. Vui lòng nhập một số nguyên dương.");
                        return;
                    }
                    string MaP = txtMaPhong.Text;
                    Room room = new Room() { MaP = MaP }; // tạo đối tượng phòng
                    BLL_Room bllRoom = new BLL_Room(path);
                    if (!bllRoom.CheckTrangThaiPhong(ref err, room))
                    {
                        MessageBox.Show("Phòng đã hết.");
                        return;
                    }
                    // Khởi tạo đối tượng người dùng và gán giá trị trên control vào đối tượng User
                    _customer = new Customer()
                    {
                        MaKH = txtMaKh.Text,
                        HoTenKH = txtHoTen.Text,
                        GioiTinhKH = cbPhai.Text,
                        NgaySinh = ngaySinh,
                        QueQuan = txtQueQuan.Text,
                        SDT = txtSDT.Text,
                        SoThangThue = int.Parse(txtSoTT.Text),
                        MaP = txtMaPhong.Text
                    };

                    // Gọi phương thức cập nhật thông tin người dùng từ đối tượng BusinessLayer (bd)
                    // Nếu phương thức trả về giá trị > 0 thì cập nhật thành công
                    if (_bd.CapNhatCustomer(ref err, _customer) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");

                        // Cập nhật trạng thái của phòng thành "đã hết"
                        room.TrangThai = "Đã hết";
                        bllRoom.CapNhatPhong(ref err, room);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công: " + err);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ. Vui lòng kiểm tra lại.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã phòng không tồn tại!");
                    //MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
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
