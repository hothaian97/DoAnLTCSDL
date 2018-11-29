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
using System.Data.SqlClient;
using System.Data;

namespace QLShopTheThao
{
    public partial class frmCrystal : DevExpress.XtraEditors.XtraForm
    {
        public frmCrystal()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
                      
        }

        private void frmCrystal_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            using (QLSQADataContext _db = new QLSQADataContext())
            {
                var item2 = (from tb in _db.db_KhachHangs where tb.MaKH == 1 select tb).FirstOrDefault();
                //SqlDataAdapter da = new SqlDataAdapter(_db.Connection.ConnectionString,)
                var item = (from tb in _db.db_ChiTietDonDatHangs
                            join tb2 in _db.db_DonDatHangs on tb.MaDonDatHang equals tb2.MaDonDatHang
                            where tb2.MaKH == item2.MaKH
                            select new
                            {
                                tb2.db_KhachHang.TenKH,
                                tb.db_SanPham.TenSP,
                                //tb.SoLuongDat,
                                //tb.DonGiaDat,
                                //tb.db_DonDatHang.ThanhTienDH,
                            }).ToList();                
                var item1 = _db.db_ChiTietDonDatHangs.Join(_db.db_DonDatHangs, r => r.MaDonDatHang, ct => ct.MaDonDatHang, (r, ct) => new {db_ChiTietDonDatHang = r,db_DonDatHang = ct }).Where(a=>a.db_DonDatHang.MaKH == item2.MaKH).Select(p => new
                {
                    TenKH = p.db_DonDatHang.db_KhachHang.TenKH,
                    TenSP = p.db_ChiTietDonDatHang.db_SanPham.TenSP,
                    //SoLuongDat = p.db_ChiTietDonDatHang.SoLuongDat,
                    //DonGiaDat = p.db_ChiTietDonDatHang.DonGiaDat,
                    //ThanhTienDH = p.db_DonDatHang.ThanhTienDH,
                }).ToList();

                if (item == null)
                {
                    MessageBox.Show("null");
                }
                else
                {
                    CrystalReport1 rpt = new CrystalReport1();
                    rpt.Load(@"CrystalReport1.rpt");
                    rpt.SetDataSource(item);
                    //ds.Tables.Add(item)
                    this.crystalReportViewer1.ReportSource = rpt;
                }

            }
        }
    }
}