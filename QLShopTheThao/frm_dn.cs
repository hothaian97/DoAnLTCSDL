using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopTheThao
{
    public partial class frm_dn : Form
    {
        QLSQADataContext _db = new QLSQADataContext();
        public frm_dn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Dang nhap that bai", "Thong Bao", MessageBoxButtons.OK);
            }
        }
    }
}
