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
using QuanLyPhongTro.BLL;

namespace QuanLyPhongTro
{
    public partial class Frm_QuanLyPhong_modi : Form
    {
        public Frm_QuanLyPhong_modi()
        {
            InitializeComponent();
        }

        // Lưu trạng thái mở form
        public bool isAdd = false;
        // Lưu thông tin phòng cho trường hợp sửa
        public Room _room;
        // Biến lưu đường dẫn file chứa chuỗi kết nối
        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        // Khai báo biến để lưu lỗi
        string err = string.Empty;
        // Khai báo đối tượng của lớp BusinessLayer
        BLL_Room bd;

        private void Frm_QuanLyPhong_modi_Load(object sender, EventArgs e)
        {
            bd = new BLL_Room(path);
            if (isAdd)
            {
                txtMaP.Text = string.Empty; // Gán giá trị rỗng nếu thêm mới
                txtGiaPhong.Text = string.Empty;
                cbTrangThai.SelectedIndex = -1; // Đặt combobox trạng thái về trạng thái chưa chọn
            }
            else
            {
                txtMaP.Text = _room.MaP;
                txtGiaPhong.Text = _room.GiaPhong.ToString();
                cbTrangThai.Text = _room.TrangThai;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaP.Text))
            {

                ////Khởi tạo đối tượng phòng và gán giá trị từ các điều khiển trên form
               _room = new Room()
               {
                   MaP = txtMaP.Text,
                   GiaPhong = float.Parse(txtGiaPhong.Text),
                   TrangThai = cbTrangThai.Items[cbTrangThai.SelectedIndex].ToString()
               };

                // Gọi phương thức cập nhật thông tin phòng từ đối tượng BusinessLayer (bd)
                if (bd.CapNhatPhong(ref err, _room) > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. Lỗi: " + err);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã Phòng");
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
