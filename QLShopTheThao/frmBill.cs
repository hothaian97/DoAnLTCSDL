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
    public partial class frmBill : DevExpress.XtraEditors.XtraForm
    {
        QLSQADataContext _db = new QLSQADataContext();
        QLSQADataContext db = new QLSQADataContext();
        public frmBill()
        {
            InitializeComponent();
        }

        private void loadcmb()
        {
            using (QLSQADataContext db = new QLSQADataContext())
            {
                cmbtkh.DataSource = db.db_KhachHangs.ToList();
                cmbtkh.ValueMember = "MaKH";
                cmbtkh.DisplayMember = "TenKH";
                cbotsp.DataSource = db.db_SanPhams.ToList();
                cbotsp.ValueMember = "MaSP";
                cbotsp.DisplayMember = "TenSP";
            }
        }
        private void frmBill_Load(object sender, EventArgs e)
        {
            loadcmb();
            cbotsp.SelectedIndex = 0;
            loadgrid();
        }

        private void cleardata()
        {
            
        }

        private void enableNutLenh(bool capnhat)
        {
            btnthoat.Enabled = !capnhat;
            btnluu.Enabled = capnhat;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            enableNutLenh(true);
            cleardata();
            loadgrid();
        }

        private void loadgrid()
        {
            dataGridView2.AutoGenerateColumns = false;
            QLSQADataContext _db = new QLSQADataContext();
            dataGridView2.DataSource = _db.db_HoaDons;           
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            db_HoaDon hd = new db_HoaDon
            {
                MaHD = txtmhd.Text,
                MaKH = int.Parse(cmbtkh.SelectedValue.ToString()),
                MaNV = 1,
                NgayBan=dtpnd.Value
            };
            db.db_HoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();
            lblmhd.Text = txtmhd.Text;
           
        }

        private void addrow(string gia,string soluong,string dt,string thanhtien)
        {
            string[] row = { gia, soluong, dt,thanhtien };
            dataGridView1.Rows.Add(row);
        }
      
        private void btnthemsp_Click(object sender, EventArgs e)
        {
            db_ChiTietDonHang dh = new db_ChiTietDonHang
            {
                ThanhTien = double.Parse(txtdg.Text) * double.Parse(txtsl.Text),
                MaHD = txtmhd.Text,
                SoLuong = int.Parse(txtsl.Text),
                MaSP = int.Parse(cbotsp.SelectedValue.ToString()),
            };
            _db.db_ChiTietDonHangs.InsertOnSubmit(dh);              
            DateTime dt = DateTime.Now;
            double tt = double.Parse(txtdg.Text) * double.Parse(txtsl.Text);
            addrow(cbotsp.Text, txtsl.Text, txtdg.Text, Convert.ToString(tt));
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            /*_db.SubmitChanges();
            db.SubmitChanges();
            loadgrid();*/
        }

        private void cmbtkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLSQADataContext _db = new QLSQADataContext();
            var item = (from tb in _db.db_KhachHangs
                        select tb).First();
            txtdc.Text = item.DiaChiKH.ToString();
            txtsdt.Text = item.sdtKH.ToString();
            if (cmbtkh.SelectedIndex > 0)
            {
                var item1 = (from tb in _db.db_KhachHangs
                             where tb.MaKH == int.Parse(cmbtkh.SelectedValue.ToString())
                             select tb).Single();
                txtdc.Text = item1.DiaChiKH.ToString();
                txtsdt.Text = item1.sdtKH.ToString();
            }
        }

        /*private void txtsl_TextChanged(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(txtdg.Text);
            y = double.Parse(txtsl.Text);
            z = x*y;
            txtthanhtien.Text = z.ToString();
        }*/

        private void cbotsp_TextChanged(object sender, EventArgs e)
        {
            var item = (from tb in _db.db_SanPhams
                         select tb).First();
            txtdg.Text = item.GiaSP.ToString();
            if (cbotsp.SelectedIndex > 0)
            {
                var item1 = (from tb in _db.db_SanPhams
                             where tb.MaSP == int.Parse(cbotsp.SelectedValue.ToString())
                             select tb).Single();
                txtdg.Text = item1.GiaSP.ToString();
            }

        }

        private void btnluusp_Click(object sender, EventArgs e)
        {
            _db.SubmitChanges();
            QLSQADataContext ql = new QLSQADataContext();
            double tongtien = 0;
            var item = (from tb in ql.db_ChiTietDonHangs
                        join tb1 in ql.db_HoaDons on tb.MaHD equals tb1.MaHD
                        where tb.MaHD == lblmhd.Text
                        select tb).ToList();
            foreach (var hd in item)
            {
                tongtien += (double)hd.ThanhTien;
            }
            label3.Text = tongtien.ToString();
            using (QLSQADataContext dbnew = new QLSQADataContext())
            {
                var item1 = dbnew.db_HoaDons.Where(r => r.MaHD == txtmhd.Text).Single();
                item1.TongTien = tongtien;
                dbnew.SubmitChanges();
                dataGridView1.Rows.Clear();
                loadgrid();
            }
                       
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                txtmhd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txt.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                txtsoluong.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtgia.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtgia.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}