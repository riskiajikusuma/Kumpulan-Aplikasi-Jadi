using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Tambahkan library baru
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Penjualan_Kue.GUI
{
    public partial class FKwitansiPembelian : Form
    {
        // Tambahkan beberapa variabel
        private DataSet ds;
        private SqlDataAdapter da;

        // Import kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FKwitansiPembelian()
        {
            InitializeComponent();
        }

        private void FKwitansiPembelian_Load(object sender, EventArgs e)
        {
            // Perintah load kwitansi berdasarkan kode beli
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM view_pembelian WHERE Kd_beli = '" +
                FPembelian.ObjTransaksi.txtKodeBeli.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "view_pembelian");
            // Memanggil report cetak kwitansi yang ada pada package laporan
            Laporan.CetakPembelian myReport = new Laporan.CetakPembelian();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            crystalReportViewer1.Refresh();
        }
    }
}
