using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLShopTheThao
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        QLSQADataContext _db = new QLSQADataContext();
        public frmLogin()
        {
            InitializeComponent();
        }
   

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var item = _db.db_Users.Where(r => r.TenDangNhap == textBox1.Text && r.MatKhau == textBox2.Text).Single();
            if (item != null)
            {
                this.Hide();
                frm_Home frmhome = new frm_Home();
                frmhome.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}