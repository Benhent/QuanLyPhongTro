namespace QuanLyPhongTro
{
    partial class Frm_QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyHoaDon));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Tinh = new System.Windows.Forms.ToolStripButton();
            this.btn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.dtgvDSBill = new System.Windows.Forms.DataGridView();
            this.cl_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_MaKH = new System.Windows.Forms.ComboBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_GiaP = new System.Windows.Forms.TextBox();
            this.txt_TienNuoc = new System.Windows.Forms.TextBox();
            this.txt_TienDien = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Sua,
            this.btn_Xoa,
            this.btn_Tinh,
            this.btn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(57, 22);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(46, 22);
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(47, 22);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tinh.Image")));
            this.btn_Tinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(50, 22);
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(57, 22);
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dtgvDSBill
            // 
            this.dtgvDSBill.AllowUserToAddRows = false;
            this.dtgvDSBill.AllowUserToDeleteRows = false;
            this.dtgvDSBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaHD,
            this.cl_TienDien,
            this.cl_TienNuoc,
            this.cl_TongTien,
            this.cl_MaKH});
            this.dtgvDSBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSBill.Location = new System.Drawing.Point(0, 230);
            this.dtgvDSBill.Name = "dtgvDSBill";
            this.dtgvDSBill.ReadOnly = true;
            this.dtgvDSBill.Size = new System.Drawing.Size(800, 220);
            this.dtgvDSBill.TabIndex = 2;
            this.dtgvDSBill.Click += new System.EventHandler(this.dtgvDSBill_Click);
            // 
            // cl_MaHD
            // 
            this.cl_MaHD.DataPropertyName = "MaHD";
            this.cl_MaHD.HeaderText = "MaHD";
            this.cl_MaHD.Name = "cl_MaHD";
            this.cl_MaHD.ReadOnly = true;
            // 
            // cl_TienDien
            // 
            this.cl_TienDien.DataPropertyName = "TienDien";
            this.cl_TienDien.HeaderText = "TienDien";
            this.cl_TienDien.Name = "cl_TienDien";
            this.cl_TienDien.ReadOnly = true;
            // 
            // cl_TienNuoc
            // 
            this.cl_TienNuoc.DataPropertyName = "TienNuoc";
            this.cl_TienNuoc.HeaderText = "TienNuoc";
            this.cl_TienNuoc.Name = "cl_TienNuoc";
            this.cl_TienNuoc.ReadOnly = true;
            // 
            // cl_TongTien
            // 
            this.cl_TongTien.DataPropertyName = "TongTien";
            this.cl_TongTien.HeaderText = "TongTien";
            this.cl_TongTien.Name = "cl_TongTien";
            this.cl_TongTien.ReadOnly = true;
            // 
            // cl_MaKH
            // 
            this.cl_MaKH.DataPropertyName = "MaKH";
            this.cl_MaKH.HeaderText = "MaKH";
            this.cl_MaKH.Name = "cl_MaKH";
            this.cl_MaKH.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.cbo_MaKH);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.txt_GiaP);
            this.groupBox1.Controls.Add(this.txt_TienNuoc);
            this.groupBox1.Controls.Add(this.txt_TienDien);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn tháng";
            // 
            // cbo_MaKH
            // 
            this.cbo_MaKH.FormattingEnabled = true;
            this.cbo_MaKH.Location = new System.Drawing.Point(494, 36);
            this.cbo_MaKH.Name = "cbo_MaKH";
            this.cbo_MaKH.Size = new System.Drawing.Size(280, 26);
            this.cbo_MaKH.TabIndex = 12;
            this.cbo_MaKH.SelectedIndexChanged += new System.EventHandler(this.cbo_MaKH_SelectedIndexChanged);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(494, 96);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(280, 24);
            this.txt_TongTien.TabIndex = 11;
            // 
            // txt_GiaP
            // 
            this.txt_GiaP.Location = new System.Drawing.Point(494, 66);
            this.txt_GiaP.Name = "txt_GiaP";
            this.txt_GiaP.Size = new System.Drawing.Size(280, 24);
            this.txt_GiaP.TabIndex = 10;
            // 
            // txt_TienNuoc
            // 
            this.txt_TienNuoc.Location = new System.Drawing.Point(103, 96);
            this.txt_TienNuoc.Name = "txt_TienNuoc";
            this.txt_TienNuoc.Size = new System.Drawing.Size(261, 24);
            this.txt_TienNuoc.TabIndex = 8;
            // 
            // txt_TienDien
            // 
            this.txt_TienDien.Location = new System.Drawing.Point(103, 66);
            this.txt_TienDien.Name = "txt_TienDien";
            this.txt_TienDien.Size = new System.Drawing.Size(261, 24);
            this.txt_TienDien.TabIndex = 7;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(103, 36);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(261, 24);
            this.txt_MaHD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(385, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(382, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(382, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền nước:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền điện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
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
            this.lblErr.Size = new System.Drawing.Size(118, 17);
            this.lblErr.Text = "toolStripStatusLabel1";
            // 
            // Frm_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgvDSBill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_QuanLyHoaDon";
            this.Text = "Frm_QuanLyHoaDon";
            this.Load += new System.EventHandler(this.Frm_QuanLyHoaDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_Tinh;
        private System.Windows.Forms.ToolStripButton btn_Thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_GiaP;
        private System.Windows.Forms.TextBox txt_TienNuoc;
        private System.Windows.Forms.TextBox txt_TienDien;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDSBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaKH;
        private System.Windows.Forms.ComboBox cbo_MaKH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
    }
}