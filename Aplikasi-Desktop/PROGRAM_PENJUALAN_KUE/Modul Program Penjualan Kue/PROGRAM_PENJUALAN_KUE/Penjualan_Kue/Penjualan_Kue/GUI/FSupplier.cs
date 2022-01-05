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
    public partial class FSupplier : Form
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
            txtIdSupplier.Clear();
            txtNamaSupplier.Clear();
            txtAlamatSupplier.Clear();
            txtNoTelpSupplier.Clear();
        }

        // Membuat prosedur atur tombol
        void AturTombol(Boolean status)
        {
            btnEdit.Enabled = status;
            btnHapus.Enabled = status;
        }

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
                listSupplier.DataSource = ds;
                listSupplier.DataMember = "supplier";
                listSupplier.Refresh();
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

        public FSupplier()
        {
            InitializeComponent();
            // Panggil prosedur bersih dan atur tombol pada saat form supplier pertama kali dijalankan
            Bersih();
            AturTombol(false);
            RefreshSupplier();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            // Memanggil prosedur bersih dan atur tombol saat klik tombol baru
            Bersih();
            txtIdSupplier.Focus();
            AturTombol(false);
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Perintah simpan data supplier
            if (txtIdSupplier.Text.Trim() == "" || txtNamaSupplier.Text.Trim() == ""
                || txtAlamatSupplier.Text.Trim() == "" || txtNoTelpSupplier.Text.Trim() == "")
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
                    cmd = new SqlCommand("EXECUTE simpan_supplier '" + txtIdSupplier.Text + "','" +
                        txtNamaSupplier.Text + "','" + txtAlamatSupplier.Text + "','" + txtNoTelpSupplier.Text + "'", conn);
                    // Membuka koneksi database
                    conn.Open();
                    // Menampilkan perintah query
                    cmd.ExecuteNonQuery();
                    // Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Memanggil prosedur bersih dan refresh pelanggan
                    Bersih();
                    RefreshSupplier();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void listSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil nilai dari record yang dipilih menuju ke textbox
            try
            {
                btnSimpan.Enabled = false;
                AturTombol(true);
                DataGridViewRow row = this.listSupplier.Rows[e.RowIndex];
                txtIdSupplier.Text = row.Cells["Id_supplier"].Value.ToString();
                txtNamaSupplier.Text = row.Cells["Nama_supplier"].Value.ToString();
                txtAlamatSupplier.Text = row.Cells["Alamat_supplier"].Value.ToString();
                txtNoTelpSupplier.Text = row.Cells["No_telp"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Perintah edit data supplier
            if (txtIdSupplier.Text.Trim() == "" || txtNamaSupplier.Text.Trim() == ""
                || txtAlamatSupplier.Text.Trim() == "" || txtNoTelpSupplier.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_supplier '" + txtIdSupplier.Text + "','" +
                        txtNamaSupplier.Text + "','" + txtAlamatSupplier.Text + "','" + txtNoTelpSupplier.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dirubah", "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Bersih();
                    RefreshSupplier();
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
            // Perintah hapus data supplier
            if (MessageBox.Show("Yakin ingin menghapus data supplier ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_supplier '" + txtIdSupplier.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data supplier berhasil dihapus", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Bersih();
                RefreshSupplier();
                // Memanggil prosedur atur tombol
                AturTombol(false);
                btnSimpan.Enabled = true;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Keluar form supplier
            Close();
        }

        private void txtCariSupplier_TextChanged(object sender, EventArgs e)
        {
            // Perintah cari nama supplier
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("EXECUTE cari_supplier '" + txtCariSupplier.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "supplier");
            listSupplier.DataSource = ds;
            listSupplier.DataMember = "supplier";
            listSupplier.Refresh();
            conn.Close();
        }
    }
}
