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
    public partial class FKasir : Form
    {
        // Import kelas koneksi.cs yang berasal dari folder kelas menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();
        // Tambahkan beberapa variabel yang digunakan untuk proses CRUD
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        // Membuat prosedur bersih
        void Bersih()
        {
            txtIdKasir.Clear();
            txtNamaKasir.Clear();
            txtAlamatKasir.Clear();
            txtNoTelpKasir.Clear();
        }

        // Membuat prosedur atur tombol
        void AturTombol(Boolean status)
        {
            btnEdit.Enabled = status;
            btnHapus.Enabled = status;
        }

        // Membuat prosedur refresh kasir
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
                listKasir.DataSource = ds;
                listKasir.DataMember = "kasir";
                listKasir.Refresh();
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

        public FKasir()
        {
            InitializeComponent();
            // Panggil prosedur bersih dan atur tombol pada saat form kasir pertama kali dijalankan
            Bersih();
            AturTombol(false);
            RefreshKasir();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            // Memanggil prosedur bersih dan atur tombol saat klik tombol baru
            Bersih();
            txtIdKasir.Focus();
            AturTombol(false);
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Perintah simpan data kasir
            if (txtIdKasir.Text.Trim() == "" || txtNamaKasir.Text.Trim() == ""
                || txtAlamatKasir.Text.Trim() == "" || txtNoTelpKasir.Text.Trim() == "")
            {
                // Tampilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                // Mempersiapkan SQL Conenection
                SqlConnection conn = konn.GetConn();
                try
                {
                    // Mempersiapkan SQL Command yang akan dieksekusi
                    cmd = new SqlCommand("EXECUTE simpan_kasir '" + txtIdKasir.Text + "','" +
                        txtNamaKasir.Text + "','" + txtAlamatKasir.Text + "','" + txtNoTelpKasir.Text + "'", conn);
                    // Membuka koneksi database
                    conn.Open();
                    // Menampilkan perintah query
                    cmd.ExecuteNonQuery();
                    // Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Memanggil prosedur bersih dan refresh pelanggan
                    Bersih();
                    RefreshKasir();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void listKasir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke textbox
            try
            {
                btnSimpan.Enabled = false;
                AturTombol(true);
                DataGridViewRow row = this.listKasir.Rows[e.RowIndex];
                txtIdKasir.Text = row.Cells["Id_kasir"].Value.ToString();
                txtNamaKasir.Text = row.Cells["Nama_kasir"].Value.ToString();
                txtAlamatKasir.Text = row.Cells["Alamat_kasir"].Value.ToString();
                txtNoTelpKasir.Text = row.Cells["No_telp"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Perintah edit data kasir
            if (txtIdKasir.Text.Trim() == "" || txtNamaKasir.Text.Trim() == ""
                || txtAlamatKasir.Text.Trim() == "" || txtNoTelpKasir.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_kasir '" + txtIdKasir.Text + "','" +
                        txtNamaKasir.Text + "','" + txtAlamatKasir.Text + "','" + txtNoTelpKasir.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dirubah", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Bersih();
                    RefreshKasir();
                    // Memanggil prosedur atur tombol
                    AturTombol(false);
                    btnSimpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Perintah hapus data kasir 
            if (MessageBox.Show("Yakin ingin menghapus data kasir ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_kasir '" + txtIdKasir.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kasir berhasil dihapus", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Bersih();
                RefreshKasir();
                // Memanggil prosedur atur tombol
                AturTombol(false);
                btnSimpan.Enabled = true;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Keluar form kasir
            Close();
        }

        private void txtCariKasir_TextChanged(object sender, EventArgs e)
        {
            // Perintah cari nama kasir
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("EXECUTE cari_kasir '" + txtCariKasir.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "kasir");
            listKasir.DataSource = ds;
            listKasir.DataMember = "kasir";
            listKasir.Refresh();
            conn.Close();
        }
    }
}
