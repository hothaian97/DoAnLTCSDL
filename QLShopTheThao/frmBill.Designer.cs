namespace QLShopTheThao
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbtkh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpnd = new System.Windows.Forms.DateTimePicker();
            this.txtmhd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelnutlenh = new System.Windows.Forms.Panel();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnthongke = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnluusp = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemsp = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblmhd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotsp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelnutlenh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panelnutlenh);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 569);
            this.panel4.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(515, 492);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Tổng tiền thanh toán:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(843, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "VNĐ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.MaKH,
            this.NgayBan,
            this.TongTien});
            this.dataGridView2.Location = new System.Drawing.Point(10, 253);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(890, 209);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 110;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.Name = "NgayBan";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtsdt);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtdc);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.cmbtkh);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.dtpnd);
            this.panel6.Controls.Add(this.txtmhd);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(10, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(503, 155);
            this.panel6.TabIndex = 17;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(96, 98);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(121, 21);
            this.txtsdt.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Số điện thoại";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(314, 64);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(121, 21);
            this.txtdc.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Địa chỉ";
            // 
            // cmbtkh
            // 
            this.cmbtkh.FormattingEnabled = true;
            this.cmbtkh.Location = new System.Drawing.Point(96, 64);
            this.cmbtkh.Name = "cmbtkh";
            this.cmbtkh.Size = new System.Drawing.Size(121, 21);
            this.cmbtkh.TabIndex = 19;
            this.cmbtkh.SelectedIndexChanged += new System.EventHandler(this.cmbtkh_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên khách hàng";
            // 
            // dtpnd
            // 
            this.dtpnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnd.Location = new System.Drawing.Point(314, 25);
            this.dtpnd.Name = "dtpnd";
            this.dtpnd.Size = new System.Drawing.Size(121, 21);
            this.dtpnd.TabIndex = 17;
            // 
            // txtmhd
            // 
            this.txtmhd.Location = new System.Drawing.Point(96, 23);
            this.txtmhd.Name = "txtmhd";
            this.txtmhd.Size = new System.Drawing.Size(121, 21);
            this.txtmhd.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ngày đặt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(739, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng Tiền";
            // 
            // panelnutlenh
            // 
            this.panelnutlenh.Controls.Add(this.btnthongke);
            this.panelnutlenh.Controls.Add(this.btnthoat);
            this.panelnutlenh.Controls.Add(this.simpleButton1);
            this.panelnutlenh.Controls.Add(this.btnluu);
            this.panelnutlenh.Location = new System.Drawing.Point(519, 46);
            this.panelnutlenh.Name = "panelnutlenh";
            this.panelnutlenh.Size = new System.Drawing.Size(361, 155);
            this.panelnutlenh.TabIndex = 15;
            // 
            // btnluu
            // 
            this.btnluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.Location = new System.Drawing.Point(51, 23);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(124, 38);
            this.btnluu.TabIndex = 25;
            this.btnluu.Text = "Thêm hóa đơn";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thông Tin Hóa Đơn";
            // 
            // btnthongke
            // 
            this.btnthongke.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnthongke.Location = new System.Drawing.Point(51, 89);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(124, 38);
            this.btnthongke.TabIndex = 31;
            this.btnthongke.Text = "Thống Kê";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(201, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 38);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 502);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnluusp);
            this.panel5.Controls.Add(this.btnthemsp);
            this.panel5.Location = new System.Drawing.Point(5, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 67);
            this.panel5.TabIndex = 28;
            // 
            // btnluusp
            // 
            this.btnluusp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnluusp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluusp.ImageOptions.Image")));
            this.btnluusp.Location = new System.Drawing.Point(263, 16);
            this.btnluusp.Name = "btnluusp";
            this.btnluusp.Size = new System.Drawing.Size(98, 38);
            this.btnluusp.TabIndex = 28;
            this.btnluusp.Text = "Thanh Toán";
            this.btnluusp.Click += new System.EventHandler(this.btnluusp_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnthemsp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemsp.ImageOptions.Image")));
            this.btnthemsp.Location = new System.Drawing.Point(79, 16);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(127, 38);
            this.btnthemsp.TabIndex = 22;
            this.btnthemsp.Text = "Thêm sản phẩm";
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblmhd);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtdg);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtsl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbotsp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 155);
            this.panel3.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Số hóa đơn";
            // 
            // lblmhd
            // 
            this.lblmhd.AutoSize = true;
            this.lblmhd.Location = new System.Drawing.Point(104, 59);
            this.lblmhd.Name = "lblmhd";
            this.lblmhd.Size = new System.Drawing.Size(47, 13);
            this.lblmhd.TabIndex = 17;
            this.lblmhd.Text = "Hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(174, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giỏ Hàng";
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(318, 88);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(121, 21);
            this.txtdg.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn giá";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(318, 58);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(121, 21);
            this.txtsl.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng";
            // 
            // cbotsp
            // 
            this.cbotsp.FormattingEnabled = true;
            this.cbotsp.Location = new System.Drawing.Point(107, 89);
            this.cbotsp.Name = "cbotsp";
            this.cbotsp.Size = new System.Drawing.Size(121, 21);
            this.cbotsp.TabIndex = 9;
            this.cbotsp.TextChanged += new System.EventHandler(this.cbotsp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(5, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 209);
            this.dataGridView1.TabIndex = 4;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Đơn giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(908, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 569);
            this.panel1.TabIndex = 8;
            // 
            // btnthoat
            // 
            this.btnthoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(201, 89);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(98, 38);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmBill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelnutlenh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelnutlenh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnthongke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnthemsp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtmhd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbtkh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpnd;
        private DevExpress.XtraEditors.SimpleButton btnluusp;
        private System.Windows.Forms.Label lblmhd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
    }
}