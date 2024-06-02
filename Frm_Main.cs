using DevComponents.DotNetBar;
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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        bool bKTraMotab = false;
        string sTieuDe;

        public Frm_Main frm_Main;

        public delegate void _ClosedTab();
        public _ClosedTab CLosedTab;

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lblErr.Text = string.Format("Hệ thống đăng nhập bởi: {0}", ClsMain.tenUser);
        }


        #region Quản lý việc mở form trên TabControll
        /// <summary>
        /// Kiểm tra form có được mở chưa theo tên form

        private bool CheckOpenTab(string name)
        {
            for (int i = 0; i < tabControl2.Tabs.Count; i++)
            {
                if (tabControl2.Tabs[i].Text == name)
                {
                    tabControl2.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        // PHƯƠNG THỨC ĐƯỢC GỌI DELEGATE
        private void vDongTab()
        {
            foreach (TabItem iten in tabControl2.Tabs)
            {
                if (iten.IsSelected)
                {
                    tabControl2.Tabs.Remove(iten);
                    return;
                }
            }
        }
        // SỰ KIỆN DÙNG ĐỂ ĐÓNG TAB
        private void TabConTrol2_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem t = tabControl2.SelectedTab;
            tabControl2.Tabs.Remove(t);
        }

        private void OpenForm(bool statusOpen, string title, Frm_Base frm)
        {
            bKTraMotab = statusOpen;
            sTieuDe = title;
            if (!CheckOpenTab(sTieuDe))
            {
                TabItem t = tabControl2.CreateTab(sTieuDe);
                t.Name = "Frm_QuanLyUser";

                frm.deDongtab = new Frm_Base._deDongtab(vDongTab);
                this.frm_Main = this;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();

                tabControl2.SelectedTabIndex = tabControl2.Tabs.Count - 1;
            }
        }

        #endregion

        private void pb_QuanLyUser_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý người dùng", new Frm_QuanLyUser());
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pb_QuanLyCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý khách hàng", new Frm_QuanLyCustomer());
        }

        private void pb_QuanLyPhong_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý phòng", new Frm_QuanLyPhong());
        }

        private void pb_PhanQuyen_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Phân quyền", new Frm_PhanQuyen());
        }
    }
}
