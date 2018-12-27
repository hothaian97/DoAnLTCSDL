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
using System.IO;

namespace QLShopTheThao
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {       
        public frmProduct()
        {
            InitializeComponent();
        }

        private void cleardata()
        {
            txttensp.Text = "";
            picProduct.Text = "";
            txtsoluong.Text = "";
            txtgia.Text = "";            
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

        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadata();
            cleardata();
        }

        private void loadata()
        {
            using (QLSQADataContext _db = new QLSQADataContext())
            {
                dataGridView1.DataSource = _db.db_SanPhams;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            enableNutLenh(true);
            cleardata();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (QLSQADataContext _db = new QLSQADataContext())
            {
                db_SanPham product = new db_SanPham
                {
                    TenSP = txttensp.Text,
                    AnhSP = txtanh.Text,
                    SoLuongSP = Convert.ToInt32(txtsoluong.Text),
                    GiaSP = Convert.ToDouble(txtgia.Text),
                };
                _db.db_SanPhams.InsertOnSubmit(product);
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
            using (QLSQADataContext _db = new QLSQADataContext())
            {
                var item = _db.db_SanPhams.Where(r => r.MaSP == pid).FirstOrDefault();
                _db.db_SanPhams.DeleteOnSubmit(item);
                _db.SubmitChanges();
                loadata();
            }
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            cleardata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (QLSQADataContext _db = new QLSQADataContext())
            {
                var item = _db.db_SanPhams.Where(r => r.MaSP == pid).FirstOrDefault();
                item.TenSP = txttensp.Text;
                item.AnhSP = txtanh.Text;
                item.SoLuongSP = Convert.ToInt32(txtsoluong.Text);
                item.GiaSP = Convert.ToDouble(txtgia.Text);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txttensp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtanh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtsoluong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtgia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                picProduct.Image = Image.FromFile(txtanh.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {       
            using (QLSQADataContext _db = new QLSQADataContext())
            {
                var item = _db.db_SanPhams.Where(r => r.TenSP.Contains(txttensp.Text));
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

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picProduct.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }

        }

        
    }
}