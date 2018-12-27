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
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        db_User user = new db_User();
        QLSQADataContext _db = new QLSQADataContext();
        public frmUser()
        {
            InitializeComponent();
        }

        private void cleardata()
        {
            txttnd.Text = "";
            txttdn.Text = "";
            txtmk.Text = "";
            txtemail.Text = "";
            rdbnam.Checked = false;
            rdbnu.Checked = false;
            cmbvaitro.SelectedValue = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void enableNutLenh(bool capnhat)
        {
            btnthem.Enabled = !capnhat;
            btnx.Enabled = !capnhat;
            btnsua.Enabled = !capnhat;
            btnthoat.Enabled = !capnhat;
            btnluu.Enabled = capnhat;
            btnhuy.Enabled = capnhat;
        }

        
        private void loadata()
        {
            using (_db = new QLSQADataContext())
            {
                dataGridView1.DataSource = _db.db_Users;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            enableNutLenh(true);
            cleardata();
        }

        private void btnluu_Click(object sender, EventArgs e)
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
            using (_db = new QLSQADataContext())
            {
                db_User user = new db_User
                {
                    TenNV = txttnd.Text,
                    TenDangNhap = txttdn.Text,
                    MatKhau = txtmk.Text,
                    EmailDK = txtemail.Text,
                    Vaitro = cmbvaitro.SelectedItem.ToString(),
                    GioiTinhDK = flag,
                    NgaySinh = dateTimePicker1.Value
                };
                _db.db_Users.InsertOnSubmit(user);
                _db.SubmitChanges();
                loadata();
            };
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            enableNutLenh(false);
            cleardata();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            bool flag;
            int pid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
                item.EmailDK = txtemail.Text;
                item.Vaitro = cmbvaitro.SelectedItem.ToString();
                item.GioiTinhDK = flag;
                item.NgaySinh = dateTimePicker1.Value;
                _db.SubmitChanges();
                loadata();
            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            cleardata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttnd_Enter(object sender, EventArgs e)
        {
            if (txttnd.Text == "Nhập tên người dùng...")
            {
                txttnd.Text = "";
            }
        }

        private void txttnd_Leave(object sender, EventArgs e)
        {
            if (txttnd.Text == "")
            {
                txttnd.Text = "Nhập tên người dùng...";
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cleardata();
            enableNutLenh(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            cleardata();
            loadata();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (_db = new QLSQADataContext())
            {
                var item = _db.db_Users.Where(r => r.TenNV.Contains(txttnd.Text) && r.TenDangNhap.Contains(txttdn.Text) && r.EmailDK.Contains(txtemail.Text));
                if (item != null)
                {
                    dataGridView1.DataSource = item;
                }
                else if (item == null)
                {
                    MessageBox.Show("Không", "Thông báo", MessageBoxButtons.OK);
                }
                cleardata();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txttnd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txttdn.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtmk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
                bool flag = (bool)dataGridView1.CurrentRow.Cells[7].Value;
                if (flag == true)
                {
                    rdbnam.Checked = true;
                }
                else
                {
                    rdbnu.Checked = true;
                }
                cmbvaitro.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}