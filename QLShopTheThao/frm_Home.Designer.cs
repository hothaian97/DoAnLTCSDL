namespace QLShopTheThao
{
    partial class frm_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.baruser = new DevExpress.XtraBars.BarButtonItem();
            this.barproduct = new DevExpress.XtraBars.BarButtonItem();
            this.barcustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barbill = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barlogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.baruser,
            this.barproduct,
            this.barcustomer,
            this.barbill,
            this.barButtonItem1,
            this.barlogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(788, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // baruser
            // 
            this.baruser.Caption = "Quản Lý Người Dùng";
            this.baruser.Id = 2;
            this.baruser.ImageOptions.Image = global::QLShopTheThao.Properties.Resources.iconperson;
            this.baruser.Name = "baruser";
            this.baruser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.baruser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.baruser_ItemClick);
            // 
            // barproduct
            // 
            this.barproduct.Caption = "Quản Lý Sản Phẩm";
            this.barproduct.Id = 3;
            this.barproduct.ImageOptions.Image = global::QLShopTheThao.Properties.Resources.product_icon;
            this.barproduct.Name = "barproduct";
            this.barproduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barproduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barproduct_ItemClick);
            // 
            // barcustomer
            // 
            this.barcustomer.Caption = "Quản Lý Khách Hàng";
            this.barcustomer.Id = 4;
            this.barcustomer.ImageOptions.Image = global::QLShopTheThao.Properties.Resources.iconcustomer;
            this.barcustomer.Name = "barcustomer";
            this.barcustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barcustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barcustomer_ItemClick);
            // 
            // barbill
            // 
            this.barbill.Caption = "Quản Lý Hóa Đơn";
            this.barbill.Id = 5;
            this.barbill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbill.ImageOptions.Image")));
            this.barbill.Name = "barbill";
            this.barbill.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbill_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng Nhập";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = global::QLShopTheThao.Properties.Resources.login1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barlogout
            // 
            this.barlogout.Caption = "Đăng Xuất";
            this.barlogout.Id = 7;
            this.barlogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barlogout.ImageOptions.Image")));
            this.barlogout.Name = "barlogout";
            this.barlogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barlogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.baruser);
            this.ribbonPageGroup1.ItemLinks.Add(this.barproduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.barcustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbill);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản Lý";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ Thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barlogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Đăng Nhập/ Đăng Xuất";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(788, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frm_Home";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem baruser;
        private DevExpress.XtraBars.BarButtonItem barproduct;
        private DevExpress.XtraBars.BarButtonItem barcustomer;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barbill;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barlogout;
    }
}