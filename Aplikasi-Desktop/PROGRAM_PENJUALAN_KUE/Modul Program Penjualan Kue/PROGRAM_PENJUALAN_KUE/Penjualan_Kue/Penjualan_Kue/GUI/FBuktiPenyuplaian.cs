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
    public partial class FBuktiPenyuplaian : Form
    {
        // Tambahkan beberapa variabel
        private DataSet ds;
        private SqlDataAdapter da;

        // Import kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FBuktiPenyuplaian()
        {
            InitializeComponent();
        }

        private void FBuktiPenyuplaian_Load(object sender, EventArgs e)
        {
            // Perintah load bukti penyuplaian berdasarkan kode suplai
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM view_penyuplaian WHERE Kd_suplai = '" +
                FPenyuplaian.ObjTransaksi.txtKodeSuplai.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "view_penyuplaian");
            // Memanggil report cetak bukti yang ada pada package laporan
            Laporan.CetakPenyuplaian myReport = new Laporan.CetakPenyuplaian();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            crystalReportViewer1.Refresh();
        }
    }
}
