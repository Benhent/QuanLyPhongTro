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
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro
{
    public partial class Frm_QuanLyPhong : Frm_Base
    {
        public Frm_QuanLyPhong()
        {
            InitializeComponent();
        }

        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        BLL_Room bd; // Khai báo biến của đối tượng BusinessLayer
        DataTable dtroom;
        string err = string.Empty;

        private void Frm_QuanLyPhong_Load(object sender, EventArgs e)
        {
            bd = new BLL_Room(path);
            HienThiDSPhong();
        }

        private void HienThiDSPhong()
        {
            try
            {
                dtroom = bd.LayDSPhong(ref err);
                dtgvDSPhong.DataSource = dtroom.DefaultView;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                lblErr.Text = err;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyPhong_modi frm_QuanLyPhong_modi = new Frm_QuanLyPhong_modi();
            frm_QuanLyPhong_modi.isAdd = true; // Xác định trạng thái mở form để thêm mới phòng
            frm_QuanLyPhong_modi.ShowDialog();
            HienThiDSPhong();
        }

        Room _room;

        private void dtgvDSPhong_Click(object sender, EventArgs e)
        {
            if (dtgvDSPhong.CurrentRow != null && dtgvDSPhong.CurrentRow.Index >= 0 && dtgvDSPhong.CurrentRow.Cells["cl_MaP"].Value != null)
            {
                _room = new Room()
                {
                    MaP = dtgvDSPhong.CurrentRow.Cells["cl_MaP"].Value.ToString(),
                    GiaPhong = float.Parse(dtgvDSPhong.CurrentRow.Cells["cl_GiaPhong"].Value.ToString()),
                    TrangThai = dtgvDSPhong.CurrentRow.Cells["cl_TrangThai"].Value.ToString()
                };
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_room != null)
            {
                Frm_QuanLyPhong_modi frm_QuanLyPhong_modi = new Frm_QuanLyPhong_modi();
                frm_QuanLyPhong_modi.isAdd = false;
                frm_QuanLyPhong_modi._room = _room;
                frm_QuanLyPhong_modi.ShowDialog();
                HienThiDSPhong();
                _room = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_room != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bd.XoaPhong(ref err, _room.MaP) > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        HienThiDSPhong();
                        _room = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Lỗi: " + err);
                    }
                }
            }
        }
    }
}
