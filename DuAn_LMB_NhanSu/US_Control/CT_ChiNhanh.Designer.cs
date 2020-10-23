namespace DuAn_LMB_NhanSu.US_Control
{
    partial class CT_ChiNhanh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Luoi_ChiNhanh = new System.Windows.Forms.DataGridView();
            this.MaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThemPhongBan = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cboCapCN = new System.Windows.Forms.ComboBox();
            this.txtNhomMe = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenChiNhanh = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaChiNhanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_ChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Luoi_ChiNhanh);
            this.panel1.Controls.Add(this.btThemPhongBan);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.cboCapCN);
            this.panel1.Controls.Add(this.txtNhomMe);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenChiNhanh);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.txtMaChiNhanh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 533);
            this.panel1.TabIndex = 1;
            // 
            // Luoi_ChiNhanh
            // 
            this.Luoi_ChiNhanh.AllowUserToAddRows = false;
            this.Luoi_ChiNhanh.AllowUserToDeleteRows = false;
            this.Luoi_ChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_ChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiNhanh,
            this.TenChiNhanh,
            this.Cap,
            this.DiaChi,
            this.DienThoai,
            this.NhomMe});
            this.Luoi_ChiNhanh.Location = new System.Drawing.Point(58, 284);
            this.Luoi_ChiNhanh.Name = "Luoi_ChiNhanh";
            this.Luoi_ChiNhanh.ReadOnly = true;
            this.Luoi_ChiNhanh.Size = new System.Drawing.Size(663, 209);
            this.Luoi_ChiNhanh.TabIndex = 17;
            this.Luoi_ChiNhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_ChiNhanh_CellClick);
            // 
            // MaChiNhanh
            // 
            this.MaChiNhanh.DataPropertyName = "Ma_ChiNhanh";
            this.MaChiNhanh.HeaderText = "Mã Chi Nhánh";
            this.MaChiNhanh.Name = "MaChiNhanh";
            this.MaChiNhanh.ReadOnly = true;
            // 
            // TenChiNhanh
            // 
            this.TenChiNhanh.DataPropertyName = "Ten_ChiNhanh";
            this.TenChiNhanh.HeaderText = "Tên Chi Nhánh";
            this.TenChiNhanh.Name = "TenChiNhanh";
            this.TenChiNhanh.ReadOnly = true;
            // 
            // Cap
            // 
            this.Cap.DataPropertyName = "Cap";
            this.Cap.HeaderText = "Cấp";
            this.Cap.Name = "Cap";
            this.Cap.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // NhomMe
            // 
            this.NhomMe.DataPropertyName = "NhomMe";
            this.NhomMe.HeaderText = "Nhóm Mẹ";
            this.NhomMe.Name = "NhomMe";
            this.NhomMe.ReadOnly = true;
            // 
            // btThemPhongBan
            // 
            this.btThemPhongBan.Location = new System.Drawing.Point(574, 242);
            this.btThemPhongBan.Name = "btThemPhongBan";
            this.btThemPhongBan.Size = new System.Drawing.Size(147, 23);
            this.btThemPhongBan.TabIndex = 16;
            this.btThemPhongBan.Text = "Thêm Phòng Ban";
            this.btThemPhongBan.UseVisualStyleBackColor = true;
            this.btThemPhongBan.Click += new System.EventHandler(this.btThemPhongBan_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(230, 242);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 14;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(402, 242);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(58, 242);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cboCapCN
            // 
            this.cboCapCN.FormattingEnabled = true;
            this.cboCapCN.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCapCN.Location = new System.Drawing.Point(136, 182);
            this.cboCapCN.Name = "cboCapCN";
            this.cboCapCN.Size = new System.Drawing.Size(176, 21);
            this.cboCapCN.TabIndex = 9;
            // 
            // txtNhomMe
            // 
            this.txtNhomMe.Location = new System.Drawing.Point(472, 182);
            this.txtNhomMe.Name = "txtNhomMe";
            this.txtNhomMe.Size = new System.Drawing.Size(249, 20);
            this.txtNhomMe.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(472, 84);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(249, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenChiNhanh
            // 
            this.txtTenChiNhanh.Location = new System.Drawing.Point(136, 131);
            this.txtTenChiNhanh.Name = "txtTenChiNhanh";
            this.txtTenChiNhanh.Size = new System.Drawing.Size(176, 20);
            this.txtTenChiNhanh.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(472, 131);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(249, 20);
            this.txtSoDienThoai.TabIndex = 11;
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.Location = new System.Drawing.Point(136, 84);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(176, 20);
            this.txtMaChiNhanh.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhóm Mẹ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Chi Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chi Nhánh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(133, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(133, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(138, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 20;
            // 
            // CT_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(280, 0);
            this.Name = "CT_ChiNhanh";
            this.Size = new System.Drawing.Size(807, 560);
            this.Load += new System.EventHandler(this.CT_ChiNhanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_ChiNhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThemPhongBan;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cboCapCN;
        private System.Windows.Forms.TextBox txtNhomMe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenChiNhanh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
        private System.Windows.Forms.DataGridView Luoi_ChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomMe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}
