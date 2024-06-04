using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyPhongTro.BLL;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro
{
    public partial class Frm_QuanLyUser : Frm_Base
    {
        public Frm_QuanLyUser()
        {
            InitializeComponent();
        }

        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        BLL_User bd;// khai báo biến của đối tượng BusinessLayer
        DataTable dtUser;
        string err = string.Empty;

        private void Frm_QuanLyUser_Load(object sender, EventArgs e)
        {
            bd = new BLL_User(path);
            htDanhSachUser();
        }

        private void htDanhSachUser()
        {
            try
            {
                dtUser = new DataTable();
                dtUser = bd.DanhSachUser(ref err);
                dtgvDsUser.DataSource = dtUser.DefaultView;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                lblErr.Text = err;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyUser_modi frm_qluser_modi = new Frm_QuanLyUser_modi();
            frm_qluser_modi.isAdd = true;// Xác định trạng thái mở form để thêm mới khách hàng
            frm_qluser_modi.ShowDialog();
            // Gọi lại phương thức show danh sách khách hàng sau khi thêm vào database
            htDanhSachUser();
        }

        User _user;
        private void dtgvDsUser_Click(object sender, EventArgs e)
        {
            if (dtgvDsUser.Rows.Count > 0)
            {
                //Lấy thông tin khách hàng khi click trên datagridview và gán vào trong biến _khachHang
                string idString = dtgvDsUser.CurrentRow.Cells["cl_ID"].Value.ToString();
                int id;
                if (int.TryParse(idString, out id))
                {
                    string roleString = dtgvDsUser.CurrentRow.Cells["cl_GroupID"].Value.ToString();
                    int role;
                    if (int.TryParse (roleString, out role))
                    {
                        string phaiString = dtgvDsUser.CurrentRow.Cells["cl_Phai"].Value.ToString();
                        bool phai;
                        if (bool.TryParse(phaiString, out phai))
                        {
                            string matKhauString = dtgvDsUser.CurrentRow.Cells["cl_MatKhau"].Value.ToString();
                            byte[] matKhauBytes = Encoding.UTF8.GetBytes(matKhauString);

                            _user = new User()
                            {
                                ID = id,
                                HoTen = dtgvDsUser.CurrentRow.Cells["cl_HoTen"].Value.ToString(),
                                Phai = phai,
                                DienThoai = dtgvDsUser.CurrentRow.Cells["cl_DienThoai"].Value.ToString(),
                                TaiKhoan = dtgvDsUser.CurrentRow.Cells["cl_TaiKhoan"].Value.ToString(),
                                MatKhau = matKhauBytes,
                                GroupID = role
                            };
                        }
                        else
                        {
                            // Xử lý khi không thể chuyển đổi Phai
                            MessageBox.Show("Không thể chuyển đổi giá trị Phai.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể chuyển đổi giá trị Role.");
                    }
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi ID
                    MessageBox.Show("Không thể chuyển đổi giá trị ID.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                Frm_QuanLyUser_modi frm_quanlyUser_modi = new Frm_QuanLyUser_modi();
                frm_quanlyUser_modi.isAdd = false;
                frm_quanlyUser_modi._user = _user;
                frm_quanlyUser_modi.ShowDialog();
                htDanhSachUser();
                _user = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                if (bd.XoaUser(ref err, _user) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    htDanhSachUser();
                    _user = null;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            deDongtab();
        }
    }
}
