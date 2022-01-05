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
    public partial class FCariKasir : Form
    {
        // Tambahkan beberapa variabel yang digunakan untuk proses read data
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodeKsr, namaKsr = "";

        // Import kelas koneksi yang berasal dari folder kelas menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        // Membuat prosedur refresh pelanggan
        void RefreshKasir()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM kasir", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "kasir");
                dataGridKasir.DataSource = ds;
                dataGridKasir.DataMember = "kasir";
                dataGridKasir.Refresh();
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

        public FCariKasir()
        {
            InitializeComponent();
            // Membersihkan komponen inputan dan panggil proc refresh pelanggan
            txtCariKasir.Clear();
            RefreshKasir();
        }

        private void txtCariKasir_TextChanged(object sender, EventArgs e)
        {
            // Membuat perintah pencarian data kasir berdasarkan kode dan nama
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM kasir WHERE Nama_kasir LIKE '%" +
                txtCariKasir.Text + "%' OR Id_kasir LIKE '%" +
                txtCariKasir.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "kasir");
            dataGridKasir.DataSource = ds;
            dataGridKasir.DataMember = "kasir";
            dataGridKasir.Refresh();
            conn.Close();
        }

        private void dataGridKasir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke variabel global kodeKsr dan namaKsr
            try
            {
                DataGridViewRow row = this.dataGridKasir.Rows[e.RowIndex];
                kodeKsr = row.Cells["Id_kasir"].Value.ToString();
                namaKsr = row.Cells["Nama_kasir"].Value.ToString();
                this.Close(); // Menutup form cari pelanggan
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        // Membuat function ambil kode pelanggan
        public String ambilKodeKasir
        {
            get
            {
                return kodeKsr;
            }
        }

        // Membuat function ambil nama pelanggan
        public String ambilNamaKasir
        {
            get
            {
                return namaKsr;
            }
        }
    }
}
