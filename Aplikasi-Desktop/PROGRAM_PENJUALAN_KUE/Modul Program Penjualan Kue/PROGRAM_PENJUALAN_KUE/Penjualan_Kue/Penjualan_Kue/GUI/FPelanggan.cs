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
    public partial class FPelanggan : Form
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
            txtIdPelanggan.Clear();
            txtNamaPelanggan.Clear();
            txtAlamatPelanggan.Clear();
            txtNoTelpPelanggan.Clear();
        }

        // Membuat prosedur atur tombol
        void AturTombol(Boolean status)
        {
            btnEdit.Enabled = status;
            btnHapus.Enabled = status;
        }

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
                listPelanggan.DataSource = ds;
                listPelanggan.DataMember = "pelanggan";
                listPelanggan.Refresh();
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

        public FPelanggan()
        {
            InitializeComponent();
            // Panggil prosedur bersih dan atur tombol pada saat form pelanggan pertama kali dijalankan
            Bersih();
            AturTombol(false);
            RefreshPelanggan();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            // Memanggil prosedur bersih dan atur tombol saat klik tombol baru
            Bersih();
            txtIdPelanggan.Focus();
            AturTombol(false);
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Perintah simpan data pelanggan
            if (txtIdPelanggan.Text.Trim() == "" || txtNamaPelanggan.Text.Trim() == ""
                || txtAlamatPelanggan.Text.Trim() == "" || txtNoTelpPelanggan.Text.Trim() == "")
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
                    cmd = new SqlCommand("EXECUTE simpan_pelanggan '" + txtIdPelanggan.Text + "','" +
                        txtNamaPelanggan.Text + "','" + txtAlamatPelanggan.Text + "','" + txtNoTelpPelanggan.Text + "'", conn);
                    // Membuka koneksi database
                    conn.Open();
                    // Menampilkan perintah query
                    cmd.ExecuteNonQuery();
                    // Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Memanggil prosedur bersih dan refresh pelanggan
                    Bersih();
                    RefreshPelanggan();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void listPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke textbox
            try
            {
                btnSimpan.Enabled = false;
                AturTombol(true);
                DataGridViewRow row = this.listPelanggan.Rows[e.RowIndex];
                txtIdPelanggan.Text = row.Cells["Id_pelanggan"].Value.ToString();
                txtNamaPelanggan.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                txtAlamatPelanggan.Text = row.Cells["Alamat_pelanggan"].Value.ToString();
                txtNoTelpPelanggan.Text = row.Cells["No_telp"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Perintah edit data pelanggan
            if (txtIdPelanggan.Text.Trim() == "" || txtNamaPelanggan.Text.Trim() == ""
                || txtAlamatPelanggan.Text.Trim() == "" || txtNoTelpPelanggan.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_pelanggan '" + txtIdPelanggan.Text + "','" +
                        txtNamaPelanggan.Text + "','" + txtAlamatPelanggan.Text + "','" + txtNoTelpPelanggan.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dirubah", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Bersih();
                    RefreshPelanggan();
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
            // Perintah hapus data pelanggan 
            if (MessageBox.Show("Yakin ingin menghapus data pelanggan ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_pelanggan '" + txtIdPelanggan.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data pelanggan berhasil dihapus", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Bersih();
                RefreshPelanggan();
                // Memanggil prosedur atur tombol
                AturTombol(false);
                btnSimpan.Enabled = true;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Keluar form pelanggan
            Close();
        }

        private void txtCariPelanggan_TextChanged(object sender, EventArgs e)
        {
            // Perintah cari nama pelanggan
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("EXECUTE cari_pelanggan '" + txtCariPelanggan.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "pelanggan");
            listPelanggan.DataSource = ds;
            listPelanggan.DataMember = "pelanggan";
            listPelanggan.Refresh();
            conn.Close();
        }
    }
}

