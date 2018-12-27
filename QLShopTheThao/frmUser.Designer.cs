namespace QLShopTheThao
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelnutlenh = new System.Windows.Forms.Panel();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnx = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbvaitro = new System.Windows.Forms.ComboBox();
            this.lb7 = new System.Windows.Forms.Label();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lb6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txttnd = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelnutlenh.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.TenDangNhap,
            this.MatKhau,
            this.EmailDK,
            this.NgaySinh,
            this.Vaitro,
            this.GioiTinhDK});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 477);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin người dùng";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 542);
            this.panel4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Danh Sách Người Dùng";
            // 
            // panelnutlenh
            // 
            this.panelnutlenh.Controls.Add(this.btnthoat);
            this.panelnutlenh.Controls.Add(this.btnhuy);
            this.panelnutlenh.Controls.Add(this.btnluu);
            this.panelnutlenh.Controls.Add(this.btnsua);
            this.panelnutlenh.Controls.Add(this.btnx);
            this.panelnutlenh.Controls.Add(this.btnthem);
            this.panelnutlenh.Location = new System.Drawing.Point(6, 269);
            this.panelnutlenh.Name = "panelnutlenh";
            this.panelnutlenh.Size = new System.Drawing.Size(273, 120);
            this.panelnutlenh.TabIndex = 15;
            // 
            // btnthoat
            // 
            this.btnthoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(182, 74);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 38);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(93, 74);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 38);
            this.btnhuy.TabIndex = 26;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.Location = new System.Drawing.Point(3, 74);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 38);
            this.btnluu.TabIndex = 25;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(182, 16);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 38);
            this.btnsua.TabIndex = 24;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnx
            // 
            this.btnx.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnx.ImageOptions.Image")));
            this.btnx.Location = new System.Drawing.Point(93, 16);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 38);
            this.btnx.TabIndex = 23;
            this.btnx.Text = "Xóa";
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnthem
            // 
            this.btnthem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(3, 16);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 38);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cmbvaitro
            // 
            this.cmbvaitro.FormattingEnabled = true;
            this.cmbvaitro.Items.AddRange(new object[] {
            "Admin",
            "NhanVien"});
            this.cmbvaitro.Location = new System.Drawing.Point(95, 232);
            this.cmbvaitro.Name = "cmbvaitro";
            this.cmbvaitro.Size = new System.Drawing.Size(168, 21);
            this.cmbvaitro.TabIndex = 14;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(3, 235);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(42, 13);
            this.lb7.TabIndex = 13;
            this.lb7.Text = "Vai trò:";
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(176, 201);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(39, 17);
            this.rdbnu.TabIndex = 12;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(95, 201);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(46, 17);
            this.rdbnam.TabIndex = 11;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1049, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 539);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.panelnutlenh);
            this.panel2.Controls.Add(this.cmbvaitro);
            this.panel2.Controls.Add(this.lb7);
            this.panel2.Controls.Add(this.rdbnu);
            this.panel2.Controls.Add(this.rdbnam);
            this.panel2.Controls.Add(this.lb6);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lb5);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.lb4);
            this.panel2.Controls.Add(this.txtmk);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Controls.Add(this.txttdn);
            this.panel2.Controls.Add(this.lb2);
            this.panel2.Controls.Add(this.txttnd);
            this.panel2.Controls.Add(this.lb1);
            this.panel2.Location = new System.Drawing.Point(16, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 448);
            this.panel2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 395);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(257, 38);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(3, 203);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(49, 13);
            this.lb6.TabIndex = 10;
            this.lb6.Text = "Giới tính:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(3, 168);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(59, 13);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "Ngày Sinh:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(95, 128);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(168, 21);
            this.txtemail.TabIndex = 7;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(3, 131);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(35, 13);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Email:";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(95, 88);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(168, 21);
            this.txtmk.TabIndex = 5;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(3, 91);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(55, 13);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Mật khẩu:";
            // 
            // txttdn
            // 
            this.txttdn.Location = new System.Drawing.Point(95, 49);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(168, 21);
            this.txttdn.TabIndex = 3;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(3, 52);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(83, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Tên đăng nhập:";
            // 
            // txttnd
            // 
            this.txttnd.Location = new System.Drawing.Point(95, 12);
            this.txttnd.Name = "txttnd";
            this.txttnd.Size = new System.Drawing.Size(168, 21);
            this.txttnd.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(3, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(86, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Tên người dùng:";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 120;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // EmailDK
            // 
            this.EmailDK.DataPropertyName = "EmailDK";
            this.EmailDK.HeaderText = "Email";
            this.EmailDK.Name = "EmailDK";
            this.EmailDK.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // Vaitro
            // 
            this.Vaitro.DataPropertyName = "Vaitro";
            this.Vaitro.HeaderText = "Vai trò";
            this.Vaitro.Name = "Vaitro";
            this.Vaitro.ReadOnly = true;
            // 
            // GioiTinhDK
            // 
            this.GioiTinhDK.DataPropertyName = "GioiTinhDK";
            this.GioiTinhDK.HeaderText = "Giới tính";
            this.GioiTinhDK.Name = "GioiTinhDK";
            this.GioiTinhDK.ReadOnly = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmUser";
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelnutlenh.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelnutlenh;
        private System.Windows.Forms.ComboBox cmbvaitro;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txttdn;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txttnd;
        private System.Windows.Forms.Label lb1;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnx;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhDK;

    }
}