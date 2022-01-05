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
    public partial class FCariPelanggan : Form
    {
        // Tambahkan beberapa variabel yang digunakan untuk proses read data
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodePlg, namaPlg = "";

        // Import kelas koneksi yang berasal dari folder kelas menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        // Membuat prosedur refresh pelanggan
        void RefreshPelanggan()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM pelanggan", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "pelanggan");
                dataGridPelanggan.DataSource = ds;
                dataGridPelanggan.DataMember = "pelanggan";
                dataGridPelanggan.Refresh();
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

        public FCariPelanggan()
        {
            InitializeComponent();
            // Membersihkan komponen inputan dan panggil proc refresh pelanggan
            txtCariPelanggan.Clear();
            RefreshPelanggan();
        }

        private void txtCariPelanggan_TextChanged(object sender, EventArgs e)
        {
            // Membuat perintah pencarian data pelanggan berdasarkan kode dan nama
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM pelanggan WHERE Nama_pelanggan LIKE '%" +
                txtCariPelanggan.Text + "%' OR Id_pelanggan LIKE '%" +
                txtCariPelanggan.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "pelanggan");
            dataGridPelanggan.DataSource = ds;
            dataGridPelanggan.DataMember = "pelanggan";
            dataGridPelanggan.Refresh();
            conn.Close();
        }

        private void dataGridPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke variabel global kodePlg dan namaPlg
            try
            {
                DataGridViewRow row = this.dataGridPelanggan.Rows[e.RowIndex];
                kodePlg = row.Cells["Id_pelanggan"].Value.ToString();
                namaPlg = row.Cells["Nama_pelanggan"].Value.ToString();
                this.Close(); // Menutup form cari pelanggan
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        // Membuat function ambil kode pelanggan
        public String ambilKodePelanggan
        {
            get
            {
                return kodePlg;
            }
        }

        // Membuat function ambil nama pelanggan
        public String ambilNamaPelanggan
        {
            get
            {
                return namaPlg;
            }
        }
    }
}
