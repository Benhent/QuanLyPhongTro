namespace QuanLyPhongTro
{
    partial class Frm_PhanQuyen
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
            this.btn_exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cbo_GroupUser = new System.Windows.Forms.ComboBox();
            this.dgvDSFunctionByUser = new System.Windows.Forms.DataGridView();
            this.cl_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_ChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_xem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_them = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_sua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_FuncID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSFunctionByUser)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::QuanLyPhongTro.Properties.Resources.logout;
            this.btn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(57, 22);
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.cbo_GroupUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân quyền";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(360, 17);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbo_GroupUser
            // 
            this.cbo_GroupUser.FormattingEnabled = true;
            this.cbo_GroupUser.Location = new System.Drawing.Point(25, 19);
            this.cbo_GroupUser.Name = "cbo_GroupUser";
            this.cbo_GroupUser.Size = new System.Drawing.Size(279, 21);
            this.cbo_GroupUser.TabIndex = 0;
            this.cbo_GroupUser.SelectedIndexChanged += new System.EventHandler(this.cboGroupUser_SelectedIndexChanged);
            // 
            // dgvDSFunctionByUser
            // 
            this.dgvDSFunctionByUser.AllowUserToAddRows = false;
            this.dgvDSFunctionByUser.AllowUserToDeleteRows = false;
            this.dgvDSFunctionByUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSFunctionByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSFunctionByUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_stt,
            this.cl_ChucNang,
            this.cl_xem,
            this.cl_them,
            this.cl_sua,
            this.cl_xoa,
            this.cl_GroupName,
            this.cl_GroupID,
            this.cl_FuncID,
            this.cl_Alias,
            this.cl_Tong});
            this.dgvDSFunctionByUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSFunctionByUser.Location = new System.Drawing.Point(0, 73);
            this.dgvDSFunctionByUser.Name = "dgvDSFunctionByUser";
            this.dgvDSFunctionByUser.Size = new System.Drawing.Size(800, 355);
            this.dgvDSFunctionByUser.TabIndex = 3;
            this.dgvDSFunctionByUser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSFunctionByUser_CellEndEdit);
            // 
            // cl_stt
            // 
            this.cl_stt.DataPropertyName = "STT";
            this.cl_stt.HeaderText = "STT";
            this.cl_stt.Name = "cl_stt";
            this.cl_stt.ReadOnly = true;
            // 
            // cl_ChucNang
            // 
            this.cl_ChucNang.DataPropertyName = "FuncName";
            this.cl_ChucNang.HeaderText = "Tên chức năng";
            this.cl_ChucNang.Name = "cl_ChucNang";
            this.cl_ChucNang.ReadOnly = true;
            // 
            // cl_xem
            // 
            this.cl_xem.DataPropertyName = "Xem";
            this.cl_xem.FalseValue = "0";
            this.cl_xem.HeaderText = "Xem";
            this.cl_xem.Name = "cl_xem";
            this.cl_xem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_xem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cl_xem.TrueValue = "1";
            // 
            // cl_them
            // 
            this.cl_them.DataPropertyName = "Them";
            this.cl_them.FalseValue = "0";
            this.cl_them.HeaderText = "Thêm";
            this.cl_them.Name = "cl_them";
            this.cl_them.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_them.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cl_them.TrueValue = "1";
            // 
            // cl_sua
            // 
            this.cl_sua.DataPropertyName = "Sua";
            this.cl_sua.FalseValue = "0";
            this.cl_sua.HeaderText = "Sửa";
            this.cl_sua.Name = "cl_sua";
            this.cl_sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cl_sua.TrueValue = "1";
            // 
            // cl_xoa
            // 
            this.cl_xoa.DataPropertyName = "Xoa";
            this.cl_xoa.FalseValue = "0";
            this.cl_xoa.HeaderText = "Xóa";
            this.cl_xoa.Name = "cl_xoa";
            this.cl_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cl_xoa.TrueValue = "1";
            // 
            // cl_GroupName
            // 
            this.cl_GroupName.DataPropertyName = "GroupName";
            this.cl_GroupName.HeaderText = "GroupName";
            this.cl_GroupName.Name = "cl_GroupName";
            this.cl_GroupName.Visible = false;
            // 
            // cl_GroupID
            // 
            this.cl_GroupID.DataPropertyName = "GroupID";
            this.cl_GroupID.HeaderText = "GroupID";
            this.cl_GroupID.Name = "cl_GroupID";
            this.cl_GroupID.Visible = false;
            // 
            // cl_FuncID
            // 
            this.cl_FuncID.DataPropertyName = "FuncID";
            this.cl_FuncID.HeaderText = "FuncID";
            this.cl_FuncID.Name = "cl_FuncID";
            this.cl_FuncID.Visible = false;
            // 
            // cl_Alias
            // 
            this.cl_Alias.DataPropertyName = "Alias";
            this.cl_Alias.HeaderText = "Alias";
            this.cl_Alias.Name = "cl_Alias";
            this.cl_Alias.Visible = false;
            // 
            // cl_Tong
            // 
            this.cl_Tong.DataPropertyName = "Tong";
            this.cl_Tong.HeaderText = "Tổng";
            this.cl_Tong.Name = "cl_Tong";
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDSFunctionByUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PhanQuyen";
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSFunctionByUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cbo_GroupUser;
        private System.Windows.Forms.DataGridView dgvDSFunctionByUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ChucNang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cl_xem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cl_them;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cl_sua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cl_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_FuncID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Tong;
    }
}