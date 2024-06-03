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
    public partial class Frm_PhanQuyen : Frm_Base
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
        }
        string path = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True";
        BLL_HeThong bd;
        DataTable dtGroupUser;
        DataTable dtFunctionByUser;
        string err = string.Empty;
        bool trangThaiLoadCombo = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            deDongtab();
        }

        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong(path);
            HienThiDuLieuCboGroupUser();
        }

        private void HienThiDuLieuCboGroupUser()
        {
            dtGroupUser = new DataTable();
            dtGroupUser = bd.LayDSGroupUser(ref err);

            cbo_GroupUser.DataSource = dtGroupUser;
            cbo_GroupUser.ValueMember = "GroupID";
            cbo_GroupUser.DisplayMember = "GroupName";

            cbo_GroupUser.SelectedIndex = -1;
            cbo_GroupUser.Text = "-- Chon Group user --";
            trangThaiLoadCombo = true;

        }

        private void cboGroupUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_GroupUser.SelectedIndex >= 0 && trangThaiLoadCombo == true)
            {
                HienThiDSFunctionsByUser(cbo_GroupUser.SelectedValue.ToString());
            }
        }

        private void HienThiDSFunctionsByUser(string groupID)
        {
            dtFunctionByUser = new DataTable();
            dtFunctionByUser = bd.LayDSFunctionsByUser(ref err, groupID);
            dgvDSFunctionByUser.DataSource = dtFunctionByUser.DefaultView;
        }

        private void dgvDSFunctionByUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSFunctionByUser.CurrentCell.ColumnIndex >=6 && dgvDSFunctionByUser.CurrentCell.ColumnIndex <= 9)
            {
                int diem = 0;
                for (int i = 6; i <= 9; i++)
                {
                    if (dgvDSFunctionByUser.CurrentRow.Cells[i].Value.ToString().Equals("1"))
                    {
                        switch (i)
                        {
                            case 6:
                                diem += 1;
                                break;
                            case 7:
                                diem += 2;
                                break;
                            case 8:
                                diem += 4;
                                break;
                            case 9:
                                diem += 8;
                                break;
                        }
                    }
                }
                dgvDSFunctionByUser.CurrentRow.Cells["cl_Tong"].Value = string.Format("{0}", diem);
            }
        }

        string funcId, groupId;
        int toltal = 0;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
                for (int i = 0; i < dgvDSFunctionByUser.Rows.Count; i++)
                {
                    funcId = dgvDSFunctionByUser.Rows[i].Cells["cl_FuncID"].Value.ToString();
                    groupId = dgvDSFunctionByUser.Rows[i].Cells["cl_GroupID"].Value.ToString();
                toltal = Int32.Parse(dgvDSFunctionByUser.Rows[i].Cells["cl_Tong"].Value.ToString());
                    bd.CapNhatPhanQuyen(ref err, funcId, groupId, toltal);
                }
                HienThiDSFunctionsByUser(cbo_GroupUser.SelectedValue.ToString());
           
        }
    }
}
