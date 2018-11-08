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
    public partial class frm_QLND : Form
    {
        QLSQADataContext _db = new QLSQADataContext();
        public frm_QLND()
        {
            InitializeComponent();
        }

        private void cleardata()
        {
            txttnd.Text = "";
            txttdn.Text = "";
            txtmk.Text = "";
            txtdiachi.Text = "";
            rdbnam.Checked = false;
            rdbnu.Checked = false;
            cmbvt.SelectedValue = -1;
            dtpns.Value = DateTime.Now;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            bool flag;
            if (rdbnam.Checked == true)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            db_User user = new db_User
            {
                TenNV = txttdn.Text,
                TenDangNhap = txttdn.Text,
                MatKhau = txtmk.Text,
                DiaChi = txtdiachi.Text,
                Vaitro = cmbvt.SelectedItem.ToString(),
                GioiTinhDK = flag,
                NgaySinh = dtpns.Value
            };
            _db.db_Users.InsertOnSubmit(user);
            _db.SubmitChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            gv1.DataSource = _db.db_Users;
            cleardata();      
        }

        private void frm_QLND_Load(object sender, EventArgs e)
        {
            loadata();
            cleardata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bool flag;
            int pid = Convert.ToInt32(gv1.CurrentRow.Cells[0].Value.ToString());
            if (rdbnam.Checked == true)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            using (_db = new QLSQADataContext())
            {
                var item = _db.db_Users.Where(r => r.MaNV == pid).FirstOrDefault();
                item.TenNV = txttnd.Text;
                item.TenDangNhap = txttdn.Text;
                item.MatKhau = txtmk.Text;
                item.DiaChi = txtdiachi.Text;
                item.Vaitro = cmbvt.SelectedItem.ToString();
                item.GioiTinhDK = flag;
                item.NgaySinh = dtpns.Value;
                _db.SubmitChanges();
                loadata();
            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            cleardata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(gv1.CurrentRow.Cells[0].Value.ToString());
            using (_db = new QLSQADataContext())
            {
                var item = _db.db_Users.Where(r => r.MaNV == pid).FirstOrDefault();
                _db.db_Users.DeleteOnSubmit(item);
                _db.SubmitChanges();
                loadata();
            }
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            cleardata();
        }

        private void gv1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txttnd.Text = gv1.CurrentRow.Cells[1].Value.ToString();
            txttdn.Text = gv1.CurrentRow.Cells[2].Value.ToString();
            txtmk.Text = gv1.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = gv1.CurrentRow.Cells[4].Value.ToString();
            dtpns.Value = (DateTime)gv1.CurrentRow.Cells[5].Value;
            bool flag = (bool)gv1.CurrentRow.Cells[7].Value;
            if (flag == true)
            {
                rdbnam.Checked = true;
            }
            else
            {
                rdbnu.Checked = true;
            }
            cmbvt.Text = gv1.CurrentRow.Cells[6].Value.ToString();
        }
        private void loadata()
        {
            using (_db = new QLSQADataContext())
            {
                gv1.DataSource = _db.db_Users;
            }         
        }

    }
}
