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

namespace QLShopTheThao
{

    public partial class frmCrystal : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt_hoadon;
        DataTable dt_chitiethoadon;
        public frmCrystal()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmCrystal_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLShopTheThao;Integrated Security=True");
            da = new SqlDataAdapter("Select * from db_HoaDon", cnn);
            dt_hoadon = new DataTable();
            da.Fill(dt_hoadon);

            da.SelectCommand.CommandText = " select hd.MaHD,kh.TenKH,sp.TenSP,ctdh.SoLuong,TongTien,ThanhTien "
                                            + " from db_HoaDon hd join db_ChiTietDonHang ctdh on hd.MaHD = ctdh.MaHD join db_KhachHang kh on hd.MaKH = kh.MaKH, db_SanPham sp"
                                            + " where hd.MaKH = kh.MaKH and hd.MaHD = ctdh.MaHD and sp.MaSP = ctdh.MaSP";

            dt_chitiethoadon = new DataTable();
            da.Fill(dt_chitiethoadon);

            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDataSource(dt_chitiethoadon.DefaultView);
            crystalReportViewer1.ReportSource = rpt;

        }

    }
}