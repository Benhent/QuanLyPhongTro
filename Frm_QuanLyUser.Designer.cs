namespace QuanLyPhongTro
{
    partial class Frm_QuanLyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dtgvDsUser = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsUser)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QuanLyPhongTro.Properties.Resources.logout;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtgvDsUser
            // 
            this.dtgvDsUser.AllowUserToAddRows = false;
            this.dtgvDsUser.AllowUserToDeleteRows = false;
            this.dtgvDsUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ID,
            this.cl_HoTen,
            this.cl_Phai,
            this.cl_DienThoai,
            this.cl_TaiKhoan,
            this.cl_MatKhau,
            this.cl_role});
            this.dtgvDsUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDsUser.Location = new System.Drawing.Point(0, 25);
            this.dtgvDsUser.Name = "dtgvDsUser";
            this.dtgvDsUser.ReadOnly = true;
            this.dtgvDsUser.Size = new System.Drawing.Size(800, 425);
            this.dtgvDsUser.TabIndex = 2;
            this.dtgvDsUser.Click += new System.EventHandler(this.dtgvDsUser_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 17);
            // 
            // cl_ID
            // 
            this.cl_ID.DataPropertyName = "ID";
            this.cl_ID.HeaderText = "ID";
            this.cl_ID.Name = "cl_ID";
            this.cl_ID.ReadOnly = true;
            // 
            // cl_HoTen
            // 
            this.cl_HoTen.DataPropertyName = "HoTen";
            this.cl_HoTen.HeaderText = "HoTen";
            this.cl_HoTen.Name = "cl_HoTen";
            this.cl_HoTen.ReadOnly = true;
            // 
            // cl_Phai
            // 
            this.cl_Phai.DataPropertyName = "Phai";
            this.cl_Phai.HeaderText = "Phai";
            this.cl_Phai.Name = "cl_Phai";
            this.cl_Phai.ReadOnly = true;
            // 
            // cl_DienThoai
            // 
            this.cl_DienThoai.DataPropertyName = "DienThoai";
            this.cl_DienThoai.HeaderText = "DienThoai";
            this.cl_DienThoai.Name = "cl_DienThoai";
            this.cl_DienThoai.ReadOnly = true;
            // 
            // cl_TaiKhoan
            // 
            this.cl_TaiKhoan.DataPropertyName = "TaiKhoan";
            this.cl_TaiKhoan.HeaderText = "TaiKhoan";
            this.cl_TaiKhoan.Name = "cl_TaiKhoan";
            this.cl_TaiKhoan.ReadOnly = true;
            // 
            // cl_MatKhau
            // 
            this.cl_MatKhau.DataPropertyName = "MatKhau";
            this.cl_MatKhau.HeaderText = "MatKhau";
            this.cl_MatKhau.Name = "cl_MatKhau";
            this.cl_MatKhau.ReadOnly = true;
            // 
            // cl_role
            // 
            this.cl_role.DataPropertyName = "GroupID";
            this.cl_role.HeaderText = "Role";
            this.cl_role.Name = "cl_role";
            this.cl_role.ReadOnly = true;
            // 
            // Frm_QuanLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgvDsUser);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyUser";
            this.Text = "Frm_QuanLyUser";
            this.Load += new System.EventHandler(this.Frm_QuanLyUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsUser)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView dtgvDsUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_role;
    }
}