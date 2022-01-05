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
    public partial class FCariKue : Form
    {
        // Tambahkan beberapa variabel yang digunakan untuk proses read data
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodeKue, namaKue, jnsKue, hargaKue = "";

        // Import kelas koneksi yang berasal dari folder kelas menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        // Membuat prosedur refresh kue
        void RefreshKue()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM kue", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "kue");
                dataGridKue.DataSource = ds;
                dataGridKue.DataMember = "kue";
                dataGridKue.Refresh();
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
        
        public FCariKue()
        {
            InitializeComponent();
            // Membersihkan komponen inputan dan panggil proc refresh kue
            txtCariKue.Clear();
            RefreshKue();
        }

        private void txtCariKue_TextChanged(object sender, EventArgs e)
        {
            // Membuat perintah pencarian data kue berdasarkan kode atau nama
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM kue WHERE Nama_kue LIKE '%" +
                txtCariKue.Text + "%' OR Kd_kue LIKE '%" +
                txtCariKue.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "kue");
            dataGridKue.DataSource = ds;
            dataGridKue.DataMember = "kue";
            dataGridKue.Refresh();
            conn.Close();
        }

        private void dataGridKue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke variabel global
            try
            {
                DataGridViewRow row = this.dataGridKue.Rows[e.RowIndex];
                kodeKue = row.Cells["Kd_kue"].Value.ToString();
                namaKue = row.Cells["Nama_kue"].Value.ToString();
                hargaKue = row.Cells["Harga_kue"].Value.ToString();
                jnsKue = row.Cells["Jenis_kue"].Value.ToString();
                this.Close(); // Menutup form cari kue
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        // Membuat function ambil kode kue
        public String ambilKodeKue
        {
            get
            {
                return kodeKue;
            }
        }

        // Membuat function ambil nama kue
        public String ambilNamaKue
        {
            get
            {
                return namaKue;
            }
        }

        // Membuat function ambil jenis kue
        public String ambilJenisKue
        {
            get
            {
                return jnsKue;
            }
        }

        // Membuat function ambil harga kue
        public String ambilHargaKue
        {
            get
            {
                return hargaKue;
            }
        }
    }
}
