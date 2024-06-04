namespace QuanLyPhongTro
{
    partial class Frm_QuanLyCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvDsCustomer = new System.Windows.Forms.DataGridView();
            this.cl_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoThangThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btnSua,
            this.btnXoa,
            this.btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QuanLyPhongTro.Properties.Resources.plus;
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(57, 22);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyPhongTro.Properties.Resources.screwdriver;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyPhongTro.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::QuanLyPhongTro.Properties.Resources.logout;
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(57, 22);
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // dtgvDsCustomer
            // 
            this.dtgvDsCustomer.AllowUserToAddRows = false;
            this.dtgvDsCustomer.AllowUserToDeleteRows = false;
            this.dtgvDsCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaKH,
            this.cl_HoTenKH,
            this.cl_GioiTinhKH,
            this.cl_NgaySinh,
            this.cl_QueQuan,
            this.cl_CMND,
            this.cl_SDT,
            this.cl_SoThangThue,
            this.cl_MaP});
            this.dtgvDsCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDsCustomer.Location = new System.Drawing.Point(0, 25);
            this.dtgvDsCustomer.Name = "dtgvDsCustomer";
            this.dtgvDsCustomer.ReadOnly = true;
            this.dtgvDsCustomer.Size = new System.Drawing.Size(800, 403);
            this.dtgvDsCustomer.TabIndex = 2;
            this.dtgvDsCustomer.Click += new System.EventHandler(this.dtgvDsCustomer_Click);
            // 
            // cl_MaKH
            // 
            this.cl_MaKH.DataPropertyName = "MaKH";
            this.cl_MaKH.HeaderText = "MaKh";
            this.cl_MaKH.Name = "cl_MaKH";
            this.cl_MaKH.ReadOnly = true;
            // 
            // cl_HoTenKH
            // 
            this.cl_HoTenKH.DataPropertyName = "HoTenKH";
            this.cl_HoTenKH.HeaderText = "HoTenKH";
            this.cl_HoTenKH.Name = "cl_HoTenKH";
            this.cl_HoTenKH.ReadOnly = true;
            // 
            // cl_GioiTinhKH
            // 
            this.cl_GioiTinhKH.DataPropertyName = "GioiTinhKH";
            this.cl_GioiTinhKH.HeaderText = "GioiTinh";
            this.cl_GioiTinhKH.Name = "cl_GioiTinhKH";
            this.cl_GioiTinhKH.ReadOnly = true;
            // 
            // cl_NgaySinh
            // 
            this.cl_NgaySinh.DataPropertyName = "NgaySinh";
            this.cl_NgaySinh.HeaderText = "NgaySinh";
            this.cl_NgaySinh.Name = "cl_NgaySinh";
            this.cl_NgaySinh.ReadOnly = true;
            // 
            // cl_QueQuan
            // 
            this.cl_QueQuan.DataPropertyName = "QueQuan";
            this.cl_QueQuan.HeaderText = "QueQuan";
            this.cl_QueQuan.Name = "cl_QueQuan";
            this.cl_QueQuan.ReadOnly = true;
            // 
            // cl_CMND
            // 
            this.cl_CMND.DataPropertyName = "CMND";
            this.cl_CMND.HeaderText = "CCCD/CMND";
            this.cl_CMND.Name = "cl_CMND";
            this.cl_CMND.ReadOnly = true;
            // 
            // cl_SDT
            // 
            this.cl_SDT.DataPropertyName = "SDT";
            this.cl_SDT.HeaderText = "SDT";
            this.cl_SDT.Name = "cl_SDT";
            this.cl_SDT.ReadOnly = true;
            // 
            // cl_SoThangThue
            // 
            this.cl_SoThangThue.DataPropertyName = "SoThangThue";
            this.cl_SoThangThue.HeaderText = "SoThangThue";
            this.cl_SoThangThue.Name = "cl_SoThangThue";
            this.cl_SoThangThue.ReadOnly = true;
            // 
            // cl_MaP
            // 
            this.cl_MaP.DataPropertyName = "MaP";
            this.cl_MaP.HeaderText = "MaPhong";
            this.cl_MaP.Name = "cl_MaP";
            this.cl_MaP.ReadOnly = true;
            // 
            // Frm_QuanLyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvDsCustomer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyCustomer";
            this.Text = "Frm_QuanLyCustomer";
            this.Load += new System.EventHandler(this.Frm_QuanLyCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.DataGridView dtgvDsCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoThangThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaP;
    }
}