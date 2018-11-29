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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        db_KhachHang user = new db_KhachHang();
        QLSQADataContext _db = new QLSQADataContext();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void cleardata()
        {
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            rdbnam.Checked = false;
            rdbnu.Checked = false;
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
                dataGridView1.DataSource = _db.db_KhachHangs;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            enableNutLenh(true);
            cleardata();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (_db = new QLSQADataContext())
            {
                var item = _db.db_KhachHangs.Where(r => r.MaKH == pid).FirstOrDefault();
                _db.db_KhachHangs.DeleteOnSubmit(item);
                _db.SubmitChanges();
                loadata();
            }
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
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
                db_KhachHang user = new db_KhachHang
                {
                    TenKH = txttenkh.Text,
                    DiaChiKH = txtdiachi.Text,
                    sdtKH = txtsdt.Text,
                    EmailKH = txtemail.Text,                    
                    GioiTInh = flag,
                    NgaySinh = dateTimePicker1.Value
                };
                _db.db_KhachHangs.InsertOnSubmit(user);
                _db.SubmitChanges();
                loadata();
            };
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            enableNutLenh(false);
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
                var item = _db.db_KhachHangs.Where(r => r.MaKH == pid).FirstOrDefault();
                item.TenKH = txttenkh.Text;
                item.DiaChiKH = txtdiachi.Text;
                item.sdtKH = txtsdt.Text;
                item.EmailKH = txtemail.Text;
                item.GioiTInh = flag;
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cleardata();
            enableNutLenh(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txttenkh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtdiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtsdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
                bool flag = (bool)dataGridView1.CurrentRow.Cells[4].Value;
                if (flag == true)
                {
                    rdbnam.Checked = true;
                }
                else
                {
                    rdbnu.Checked = true;
                }               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cleardata();
            loadata();
        }
    }
}