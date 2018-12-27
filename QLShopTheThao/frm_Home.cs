using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;


namespace QLShopTheThao
{
    public partial class frm_Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Home()
        {
            InitializeComponent();
        }


        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if(child.Name==form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {
            
        }

        

        private void barproduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmProduct();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void baruser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmUser();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barcustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmCustomer();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            var flogin = new frmLogin();
            flogin.Closed += (s, args) => this.Close();
            flogin.Show();
        }

        private void barbill_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmBill();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

    }
}