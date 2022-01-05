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
    public partial class FKue : Form
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
            txtKodeKue.Clear();
            txtNamaKue.Clear();
            txtHargaKue.Clear();
            cmbJenisKue.Text = "-Pilih Satuan-";
            txtStokKue.Clear();
        }

        // Membuat prosedur atur tombol
        void AturTombol(Boolean status)
        {
            btnEdit.Enabled = status;
            btnHapus.Enabled = status;
        }

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
                listKue.DataSource = ds;
                listKue.DataMember = "kue";
                listKue.Refresh();
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


        public FKue()
        {
            InitializeComponent();
            // Panggil prosedur pada saat form kue pertama kali dijalankan
            Bersih();
            AturTombol(false);
            RefreshKue();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            // Memanggil prosedur bersih dan atur tombol saat klik tombol baru
            Bersih();
            txtKodeKue.Focus();
            AturTombol(false); // Membuat nilai status pada prosedur menjadi false
            btnSimpan.Enabled = true; // Mengaktifkan button simpan
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Perintah simpan data kue
            // Jika ada komponen inputan yang kosong
            if (txtKodeKue.Text.Trim() == "" || txtNamaKue.Text.Trim() == ""
                || txtHargaKue.Text.Trim() == "" || txtStokKue.Text.Trim() == "" ||
                cmbJenisKue.Text.Trim() == "")
            {
                // Tampilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                // Mempersiapkan SQL Connection
                SqlConnection conn = konn.GetConn();
                try
                {
                    // Mempersiapkan SQL Command yang akan dieksekusi
                    cmd = new SqlCommand("EXECUTE simpan_kue '" + txtKodeKue.Text + "','"
                        + txtNamaKue.Text + "','" + txtHargaKue.Text + "','"
                        + cmbJenisKue.Text + "','" + txtStokKue.Text + "'", conn);
                    // Membuka koneksi database
                    conn.Open();
                    // Menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    // Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Memanggil prosedur bersih dan refresh kue
                    Bersih();
                    RefreshKue();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void listKue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke textbox
            try
            {
                btnSimpan.Enabled = false;
                AturTombol(true);
                DataGridViewRow row = this.listKue.Rows[e.RowIndex];
                txtKodeKue.Text = row.Cells["Kd_kue"].Value.ToString();
                txtNamaKue.Text = row.Cells["Nama_kue"].Value.ToString();
                txtHargaKue.Text = row.Cells["Harga_kue"].Value.ToString();
                cmbJenisKue.Text = row.Cells["Jenis_kue"].Value.ToString();
                txtStokKue.Text = row.Cells["Stok_kue"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Perintah edit data kue
            if (txtKodeKue.Text.Trim() == "" || txtNamaKue.Text.Trim() == ""
                || txtHargaKue.Text.Trim() == "" || cmbJenisKue.Text.Trim() == "" ||
                txtStokKue.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_kue '" + txtNamaKue.Text + "','"
                        + txtHargaKue.Text + "','" + cmbJenisKue.Text + "','"
                        + txtStokKue.Text + "','" + txtKodeKue.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dirubah", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Bersih();
                    RefreshKue();
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
            // Perintah hapus data kue
            if (MessageBox.Show("Yakin ingin menghapus data kue ?",
                "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_kue '" + txtKodeKue.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kue berhasil dihapus", "informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Bersih();
                RefreshKue();
                // Memanggil prosedur atur tombol
                AturTombol(false);
                btnSimpan.Enabled = true;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Keluar form kue
            Close();
        }

        private void txtCariKue_TextChanged(object sender, EventArgs e)
        {
            // Perintah cari nama kue
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("EXECUTE cari_kue '" + txtCariKue.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "kue");
            listKue.DataSource = ds;
            listKue.DataMember = "kue";
            listKue.Refresh();
            conn.Close();
        }
    }
}
