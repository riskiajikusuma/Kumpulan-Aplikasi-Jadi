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
    public partial class FPenyuplaian : Form
    {
        // Import kelas koneksi dari folder (Kelas/Koneksi.cs) menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        // Tambahkan variabel untuk perintah SQL
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        // Prosedur bersih
        private void Bersih()
        {
            txtKodeSuplai.Text = "";
            dtpTanggalPenyuplaian.Value = DateTime.Now;
            txtIdSupplier.Text = "";
            txtNamaSupplier.Text = "";
            
            txtKodeKue.Text = "";
            txtNamaKue.Text = "";
            txtJumlahSuplai.Text = "0";
        }

        // Prosedur awal
        private void Awal()
        {
            // Panggil prosedur bersih di dalam prosedur awal
            Bersih();
            dataGridPenyuplaian.Enabled = false; // Menonaktifkan datagrid penyuplaian
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM penyuplaian ORDER BY Kd_suplai DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "penyuplaian");
                    dataGridPenyuplaian.DataSource = ds;
                    dataGridPenyuplaian.DataMember = "penyuplaian";
                    dataGridPenyuplaian.Refresh();
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
        }

        // Prosedur auto number
        private void AutoNumber()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT Kd_suplai FROM penyuplaian WHERE Kd_suplai IN(SELECT MAX(Kd_suplai) FROM penyuplaian) ORDER BY Kd_suplai DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows) // Jika sudah ada data transaksi pembelian sebelumnya
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["Kd_suplai"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "PM" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else // Jika belum ada data transaksi
            {
                urut = "PM001";
            }
            rd.Close();
            txtKodeSuplai.Text = urut;
            conn.Close();
        }

        // Prosedur simpan master penyuplaian
        private void SimpanMasterPenyuplaian()
        {
            // Mempersiapkan SQL Connection
            SqlConnection conn = konn.GetConn();
            {
                // Mempersiapkan SQL Command yang akan dieksekusi
                cmd = new SqlCommand("EXECUTE simpan_penyuplaian '" + txtKodeSuplai.Text + "','"
                    + dtpTanggalPenyuplaian.Text + "','" + txtIdSupplier.Text + "'", conn);
                // Membuka koneksi database
                conn.Open();
                // Menjalankan perintah query
                cmd.ExecuteNonQuery();
            }
        }

        // Prosedur simpan detail penyuplaian
        private void SimpanDetailPenyuplaian()
        {
            SqlConnection conn = konn.GetConn();
            {
                // Mempersiapkan SQL Command yang akan dieksekusi
                cmd = new SqlCommand("EXECUTE simpan_detail_penyuplaian '" + txtKodeSuplai.Text + "','"
                    + txtKodeKue.Text + "','" + txtJumlahSuplai.Text + "'", conn);
                // Membuka koneksi database
                conn.Open();
                // Menjalankan perintah query
                cmd.ExecuteNonQuery();
            }
        }

        // Prosedur refresh penyuplaian
        private void RefreshPenyuplaian()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    // Memanggil view_detail_penyuplaian
                    cmd = new SqlCommand("SELECT * FROM view_detailpenyuplaian WHERE Kd_suplai = '"
                        + txtKodeSuplai.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "view_detailpenyuplaian");
                    dataGridPenyuplaian.DataSource = ds;
                    dataGridPenyuplaian.DataMember = "view_detailpenyuplaian";
                    dataGridPenyuplaian.Refresh();
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
        }

        // Prosedur refresh transaksi per kue
        private void RefreshTransaksiPenyuplaian()
        {
            // Memanggil proc refresh penyuplaian dan bersihkan beberapa komponen transaksi kue
            RefreshPenyuplaian();
            txtKodeKue.Clear();
            txtNamaKue.Clear();
            txtJumlahSuplai.Text = "0";
            txtKodeKue.Focus();
        }

        public FPenyuplaian()
        {
            InitializeComponent();
            // Memanggil prosedur awal
            Awal();
        }

        private void btnCariSupplier_Click(object sender, EventArgs e)
        {
            // Memanggil form cari supplier
            FCariSupplier cariSupp = new FCariSupplier();
            cariSupp.ShowDialog();
            txtIdSupplier.Text = cariSupp.ambilKodeSupplier;
            txtNamaSupplier.Text = cariSupp.ambilNamaSupplier;
            txtKodeKue.Focus();
        }

        private void btnCariKasir_Click(object sender, EventArgs e)
        {
            // Memanggil form cari kasir
            FCariKasir cariKsr = new FCariKasir();
            cariKsr.ShowDialog();
            txtKodeKue.Focus();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            // Memanggil prosedur awal dan auto number ketika button baru dijalankan
            Awal();
            AutoNumber();
            dtpTanggalPenyuplaian.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Simpan data penyuplaian per barang (trigger untuk automasi stok)
            dataGridPenyuplaian.Enabled = true; // Mengaktifkan datagrid penyuplaian
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                // Jika ada data yang kosong
                if (txtKodeSuplai.Text.Trim() == "" || txtIdSupplier.Text.Trim() == "" ||
                    txtKodeKue.Text.Trim() == "" ||
                    txtJumlahSuplai.Text.Trim() == "0")
                {
                    // Pesan data belum lengkap
                    MessageBox.Show("Data belum lengkap, lengkapi data", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                // Jika data sudah terisi semua
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM pembelian WHERE Kd_beli = '" +
                        txtKodeSuplai.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) // Jika data penyuplaian sudah ada
                    {
                        // Refresh koneksi
                        conn.Close();
                        conn.Open();

                        cmd = new SqlCommand("SELECT * FROM detail_penyuplaian WHERE Kd_suplai = '" +
                            txtKodeSuplai.Text + "' AND Kd_kue = '" + txtKodeKue.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();

                        if (reader.Read()) // Jika data kue sudah diinputkan ke tabel detail_penyuplaian
                        {
                            MessageBox.Show("Data kue " + txtNamaKue.Text + " sudah diinputkan, harap pilih barang yang lain",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else // Jika data kue belum diinputkan ke tabel detail_penyuplaian
                        {
                            // Panggil prosedur detail_penyuplaian
                            SimpanDetailPenyuplaian();
                        }
                    }
                    else // Jika data penyuplaian belum ada
                    {
                        // Panggil prosedur simpan master dan detail penyuplaian
                        SimpanMasterPenyuplaian();
                        SimpanDetailPenyuplaian();
                    }
                    // Panggil prosedur refresh transaksi penyuplaian
                    RefreshTransaksiPenyuplaian();
                }
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            // Hapus data penyuplaian per kue
            // Mempersiapkan koneksi database
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                // Query menghapus data berdasarkan Kode Suplai dan Kode Kue pada tabel detail
                cmd = new SqlCommand("EXECUTE hapus_detailpenyuplaian '" + txtKodeSuplai.Text + "','" +
                    txtKodeKue.Text + "'", conn);
                // Buka koneksi database
                conn.Open();
                // Eksekusi query
                cmd.ExecuteNonQuery();

                // Cek data di detail penyuplaian
                cmd = new SqlCommand("SELECT * FROM detail_penyuplaian WHERE Kd_suplai = '"
                    + txtKodeSuplai.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
    
                // Memanggil proc refresh transaksi pembelian
                RefreshTransaksiPenyuplaian();
            }
        }

        private void dataGridPenyuplaian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tampilkan data penyuplaian per barang
            DataGridViewRow row = this.dataGridPenyuplaian.Rows[e.RowIndex];
            txtKodeKue.Text = row.Cells["Kd_asdkue"].Value.ToString();
            txtNamaKue.Text = row.Cells["Nama_kue"].Value.ToString();
            txtJumlahSuplai.Text = row.Cells["Jml_suplai"].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Transaksi selesai
            MessageBox.Show("Transaksi Selesai");
            Awal();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Keluar form transaksi penyuplaian
            Close();
        }

        private void btnCariKue_Click(object sender, EventArgs e)
        {
            // Memanggil form cari kue
            FCariKue cariKue = new FCariKue();
            cariKue.ShowDialog();
            txtKodeKue.Text = cariKue.ambilKodeKue;
            txtNamaKue.Text = cariKue.ambilNamaKue;
            txtJumlahSuplai.Focus();
        }
    }
}
