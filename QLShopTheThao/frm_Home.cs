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

        

        private void btnDanhMuc_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frm_QLND();
            form.MdiParent = this;            form.Show();        }

        /*private bool ExistForm(Xtra)
        {

        }*/
        private void frm_Home_Load(object sender, EventArgs e)
        {

        }
    }
}