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
    public partial class Frm_QuanLyHoaDon : Frm_Base
    {
        //public bool isAdd = false;
        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        BLL_Bill bd;
        DataTable dt;
        string err = string.Empty;

        public Frm_QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void Frm_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            bd = new BLL_Bill(path);
            DanhSachBill();
            LoadcboMaKh();
        }

        private void DanhSachBill()
        {
            try
            {
                dt = bd.DanhSachBill(ref err);
                dtgvDSBill.DataSource = dt;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                lblErr.Text = err;
            }
        }

        private void LoadcboMaKh()
        {
            DataTable cbMaKH = bd.LayMaKH(ref err);
            cbo_MaKH.DisplayMember = "MaKH";
            cbo_MaKH.DataSource = cbMaKH;
  
        }

        private void cbo_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCustomerID = cbo_MaKH.Text;

            try
            {
                // Gọi phương thức để lấy giá phòng từ BLL
                DataTable roomData = bd.CapNhatGiaP(selectedCustomerID, ref err);

                // Hiển thị giá phòng trong TextBox
                if (err == string.Empty && roomData.Rows.Count > 0)
                {
                    txt_GiaP.Text = roomData.Rows[0]["GiaPhong"].ToString();
                }
                else
                {
                    txt_GiaP.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            deDongtab();
        }

        private void dtgvDSBill_Click(object sender, EventArgs e)
        {
            if (dtgvDSBill.CurrentRow != null)
            {
                DataGridViewRow row = dtgvDSBill.CurrentRow;
                txt_MaHD.Text = row.Cells["cl_MaHD"].Value.ToString();
                txt_TienDien.Text = row.Cells["cl_TienDien"].Value.ToString();
                txt_TienNuoc.Text = row.Cells["cl_TienNuoc"].Value.ToString();
                txt_TongTien.Text = row.Cells["cl_TongTien"].Value.ToString();
                cbo_MaKH.Text = row.Cells["cl_MaKH"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSBill.CurrentRow != null)
            {
                DataGridViewRow row = dtgvDSBill.CurrentRow;
                string maHD = row.Cells["cl_MaHD"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn có mã " + maHD + "không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bd.XoaBill(ref err, new Bill { MaHD = maHD }) > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        DanhSachBill();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            try
            {
                float tienDien = float.Parse(txt_TienDien.Text);
                float tienNuoc = float.Parse(txt_TienNuoc.Text);
                float giaPhong = float.Parse(txt_GiaP.Text);

                float tongTien = tienDien + tienNuoc + giaPhong;
                txt_TongTien.Text = tongTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng: " + ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txt_MaHD.Text;
                float tienDien = float.Parse(txt_TienDien.Text);
                float tienNuoc = float.Parse(txt_TienNuoc.Text);
                float tongTien = float.Parse(txt_TongTien.Text);
                string maKH = cbo_MaKH.Text;

                Bill newBill = new Bill()
                {
                    MaHD = mahd,
                    TienDien = tienDien,
                    TienNuoc = tienNuoc,
                    TongTien = tongTien,
                    MaKH = maKH
                };

                if (bd.CapNhatBill(ref err, newBill) > 0)
                {
                    MessageBox.Show("Thêm hóa đơn mới thành công!");
                    DanhSachBill();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn mới không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn mới: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txt_MaHD.Text = "";
            txt_TienDien.Text = "";
            txt_TienNuoc.Text = "";
            txt_TongTien.Text = "";
            cbo_MaKH.SelectedIndex = -1;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgvDSBill.CurrentRow != null)
            {
                DataGridViewRow row = dtgvDSBill.CurrentRow;
                string maHD = row.Cells["cl_MaHD"].Value.ToString();

                float tienDien = float.Parse(txt_TienDien.Text);
                float tienNuoc = float.Parse(txt_TienNuoc.Text);
                float tongTien = float.Parse(txt_TongTien.Text);
                string maKH = cbo_MaKH.Text;

                Bill updatedBill = new Bill()
                {
                    MaHD = maHD,
                    TienDien = tienDien,
                    TienNuoc = tienNuoc,
                    TongTien = tongTien,
                    MaKH = maKH
                };

                if (bd.CapNhatBill(ref err, updatedBill) > 0)
                {
                    MessageBox.Show("Cập nhật thông tin hóa đơn thành công!");
                    DanhSachBill();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin hóa đơn không thành công!");
                }
            }
        }
    }
}
