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
    public partial class Frm_QuanLyCustomer : Frm_Base
    {
        public Frm_QuanLyCustomer()
        {
            InitializeComponent();
        }

        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        BLL_Customer bd;// khai báo biến của đối tượng BusinessLayer
        DataTable dtCustomer;
        string err = string.Empty;

        private void Frm_QuanLyCustomer_Load(object sender, EventArgs e)
        {
            bd = new BLL_Customer(path);
            DanhSachCustomer();
        }

        private void DanhSachCustomer()
        {
            try
            {
                dtCustomer = new DataTable();
                dtCustomer = bd.DanhSachCustomer(ref err);

                dtgvDsCustomer.DataSource = dtCustomer.DefaultView;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                lblErr.Text = err;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_QuanLyCustomer_modi frm_qlcustomer_modi = new Frm_QuanLyCustomer_modi();
            frm_qlcustomer_modi.isAdd = true;// Xác định trạng thái mở form để thêm mới khách hàng
            frm_qlcustomer_modi.ShowDialog();
            // Gọi lại phương thức show danh sách khách hàng sau khi thêm vào database
            DanhSachCustomer();
        }

        Customer _customer;
        private void dtgvDsCustomer_Click(object sender, EventArgs e)
        {
            if (dtgvDsCustomer.Rows.Count > 0)
            {
                //Lấy thông tin khách hàng khi click trên datagridview và gán vào trong biến _khachHang
                _customer = new Customer()
                {
                    MaKH = dtgvDsCustomer.CurrentRow.Cells["cl_MaKH"].Value.ToString(),
                    HoTenKH = dtgvDsCustomer.CurrentRow.Cells["cl_HoTenKh"].Value.ToString(),
                    GioiTinhKH = dtgvDsCustomer.CurrentRow.Cells["cl_GioiTinhKH"].Value.ToString(),
                    NgaySinh = Convert.ToDateTime(dtgvDsCustomer.CurrentRow.Cells["cl_NgaySinh"].Value),
                    QueQuan = dtgvDsCustomer.CurrentRow.Cells["cl_QueQuan"].Value.ToString(),
                    SDT = dtgvDsCustomer.CurrentRow.Cells["cl_SDT"].Value.ToString(),
                    SoThangThue = Convert.ToInt32(dtgvDsCustomer.CurrentRow.Cells["cl_SoThangThue"].Value),
                    MaP = dtgvDsCustomer.CurrentRow.Cells["cl_MaP"].Value.ToString(),
                };
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                if (bd.XoaCustomer(ref err, _customer) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    DanhSachCustomer();
                    _customer = null;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                Frm_QuanLyCustomer_modi frm_quanlyCustomer_modi = new Frm_QuanLyCustomer_modi();
                frm_quanlyCustomer_modi.isAdd = false;
                frm_quanlyCustomer_modi._customer = _customer;
                frm_quanlyCustomer_modi.ShowDialog();
                DanhSachCustomer();
                _customer = null;
            }
        }
    }
}
