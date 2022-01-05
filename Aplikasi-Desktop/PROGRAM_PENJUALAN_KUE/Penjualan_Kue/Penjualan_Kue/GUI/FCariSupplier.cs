using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Tambahkan library SQL Server
using System.Data.SqlClient;

namespace Penjualan_Kue.GUI
{
    public partial class FCariSupplier : Form
    {
         // Tambahkan beberapa variabel yang digunakan untuk proses read data
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodeSupp, namaSupp = "";

        // Import kelas koneksi yang berasal dari folder kelas menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        // Membuat prosedur refresh supplier
        void RefreshSupplier()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM supplier", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "supplier");
                dataGridSupplier.DataSource = ds;
                dataGridSupplier.DataMember = "supplier";
                dataGridSupplier.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public FCariSupplier()
        {
            InitializeComponent();
            // Membersihkan komponen inputan dan panggil proc refresh supplier
            txtCariSupplier.Clear();
            RefreshSupplier();
        }

        private void txtCariSupplier_TextChanged(object sender, EventArgs e)
        {
            // Membuat perintah pencarian data supplier berdasarkan kode dan nama
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM supplier WHERE Nama_supplier LIKE '%" +
                txtCariSupplier.Text + "%' OR Id_supplier LIKE '%" +
                txtCariSupplier.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "supplier");
            dataGridSupplier.DataSource = ds;
            dataGridSupplier.DataMember = "supplier";
            dataGridSupplier.Refresh();
            conn.Close();
        }

        private void dataGridSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke variabel global kodeSupp dan namaSupp
            try
            {
                DataGridViewRow row = this.dataGridSupplier.Rows[e.RowIndex];
                kodeSupp = row.Cells["Id_supplier"].Value.ToString();
                namaSupp = row.Cells["Nama_supplier"].Value.ToString();
                this.Close(); // Menutup form cari supplier
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        // Membuat function ambil kode supplier
        public String ambilKodeSupplier
        {
            get
            {
                return kodeSupp;
            }
        }

        // Membuat function ambil nama supplier
        public String ambilNamaSupplier
        {
            get
            {
                return namaSupp;
            }
        }
    }
}
