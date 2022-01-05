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
    public partial class FPembelian : Form
    {
        // Report - Buat ObjTransaksi
        public static FPembelian ObjTransaksi;

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
            txtKodeBeli.Text = "";
            dtpTanggalPembelian.Value = DateTime.Now;
            txtIdPelanggan.Text = "";
            txtNamaPelanggan.Text = "";
            txtIdKasir.Text = "";
            txtNamaKasir.Text = "";
            txtKodeKue.Text = "";
            txtNamaKue.Text = "";
            txtHargaKue.Text = "0";
            txtJumlahBeli.Text = "0";
            lblTotalBayar.Text = "-";
        }

        // Prosedur awal
        private void Awal()
        {
            // Panggil prosedur bersih di dalam prosedur awal
            Bersih();
            dataGridPembelian.Enabled = false; // Menonaktifkan datagrid pembelian
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM pembelian ORDER BY Kd_beli DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "pembelian");
                    dataGridPembelian.DataSource = ds;
                    dataGridPembelian.DataMember = "pembelian";
                    dataGridPembelian.Refresh();
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
            cmd = new SqlCommand("SELECT Kd_beli FROM pembelian WHERE Kd_beli IN(SELECT MAX(Kd_beli) FROM pembelian) ORDER BY Kd_beli DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows) // Jika sudah ada data transaksi pembelian sebelumnya
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["Kd_beli"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "PM" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else // Jika belum ada data transaksi
            {
                urut = "PM001";
            }
            rd.Close();
            txtKodeBeli.Text = urut;
            conn.Close();
        }

        // Prosedur simpan master pembelian
        private void SimpanMasterPembelian()
        {
            // Mempersiapkan SQL Connection
            SqlConnection conn = konn.GetConn();
            {
                // Mempersiapkan SQL Command yang akan dieksekusi
                cmd = new SqlCommand("EXECUTE simpan_pembelian '" + txtKodeBeli.Text + "','"
                    + dtpTanggalPembelian.Text + "','" + txtIdPelanggan.Text + "','" + txtIdKasir.Text + "'", conn);
                // Membuka koneksi database
                conn.Open();
                // Menjalankan perintah query
                cmd.ExecuteNonQuery();
            }
        }

        // Prosedur simpan detail pembelian
        private void SimpanDetailPembelian()
        {
            SqlConnection conn = konn.GetConn();
            {
                // Mempersiapkan SQL Command yang akan dieksekusi
                cmd = new SqlCommand("EXECUTE simpan_detail_pembelian '" + txtKodeBeli.Text + "','"
                    + txtKodeKue.Text + "','" + txtJumlahBeli.Text + "'", conn);
                // Membuka koneksi database
                conn.Open();
                // Menjalankan perintah query
                cmd.ExecuteNonQuery();
            }
        }

        // Prosedur refresh pembelian
        private void RefreshPembelian()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    // Memanggil view_detail_pembelian
                    cmd = new SqlCommand("SELECT * FROM view_detailpembelian WHERE Kd_beli = '"
                        + txtKodeBeli.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "view_detailpembelian");
                    dataGridPembelian.DataSource = ds;
                    dataGridPembelian.DataMember = "view_detailpembelian";
                    dataGridPembelian.Refresh();
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
        private void RefreshTransaksiPembelian()
        {
            // Memanggil proc refresh pembelian dan bersihkan beberapa komponen transaksi kue
            RefreshPembelian();
            txtKodeKue.Clear();
            txtNamaKue.Clear();
            txtHargaKue.Text = "0";
            txtJumlahBeli.Text = "0";
            txtKodeKue.Focus();
        }

        // Prosedur refresh total seluruh
        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("SELECT SUM(Total_bayar) " +
                    " FROM view_pembelian WHERE Kd_beli = '" + txtKodeBeli.Text + "' ", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                lblTotalBayar.Text = result.ToString("#,##0");
                conn.Close();
            }
        }

        public FPembelian()
        {
            InitializeComponent();
            // Report - Mengisi variabel ObjTransaksi dengan nilai FPembelian
            ObjTransaksi = this;

            // Memanggil prosedur awal
            Awal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCariPelanggan_Click(object sender, EventArgs e)
        {
            // Memanggil form cari pelanggan
            FCariPelanggan cariPlg = new FCariPelanggan();
            cariPlg.ShowDialog();
            txtIdPelanggan.Text = cariPlg.ambilKodePelanggan;
            txtNamaPelanggan.Text = cariPlg.ambilNamaPelanggan;
            txtKodeKue.Focus();
        }

        private void btnCariKasir_Click(object sender, EventArgs e)
        {
            // Memanggil form cari kasir
            FCariKasir cariKsr = new FCariKasir();
            cariKsr.ShowDialog();
            txtIdKasir.Text = cariKsr.ambilKodeKasir;
            txtNamaKasir.Text = cariKsr.ambilNamaKasir;
            txtKodeKue.Focus();
        }
        private void btnBaru_Click(object sender, EventArgs e)
        {
            // Memanggil prosedur awal dan auto number ketika button baru dijalankan
            Awal();
            AutoNumber();
            dtpTanggalPembelian.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Simpan data pembelian per barang (trigger untuk automasi stok)
            dataGridPembelian.Enabled = true; // Mengaktifkan datagrid pembelian
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                /*
                // Jika stok habis
                conn.Open();
                cmd = new SqlCommand("SELECT Stok_kue FROM kue WHERE Stok_kue = 0", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read()) // Jika ada data detail pembelian
                {
                    MessageBox.Show("Stok Habis ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conn.Close();
                */
                
                 
                // Jika ada data yang kosong
                if (txtKodeBeli.Text.Trim() == "" || txtIdPelanggan.Text.Trim() == "" ||
                    txtIdKasir.Text.Trim() == "" || txtKodeKue.Text.Trim() == "" ||
                    txtJumlahBeli.Text.Trim() == "0")
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
                        txtKodeBeli.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) // Jika data pembelian sudah ada
                    {
                        // Refresh koneksi
                        conn.Close();
                        conn.Open();

                        cmd = new SqlCommand("SELECT * FROM detail_pembelian WHERE Kd_beli = '" +
                            txtKodeBeli.Text + "' AND Kd_kue = '" + txtKodeKue.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();

                        if (reader.Read()) // Jika data kue sudah diinputkan ke tabel detail_pembelian
                        {
                            MessageBox.Show("Data kue " + txtNamaKue.Text + " sudah diinputkan, harap pilih barang yang lain",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else // Jika data kue belum diinputkan ke tabel detail_pembelian
                        {
                            // Panggil prosedur detail_pembelian
                            SimpanDetailPembelian();
                            // Panggil prosedur total seluruh
                            totalseluruh();
                        }
                    }
                    else // Jika data pembelian belum ada
                    {
                        // Panggil prosedur simpan master dan detail pembelian
                        SimpanMasterPembelian();
                        SimpanDetailPembelian();
                        // Panggil prosedur total seluruh
                        totalseluruh();
                    }
                    // Panggil prosedur refresh transaksi pembelian
                    RefreshTransaksiPembelian();
                }
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            // Hapus data pembelian per kue
            // Mempersiapkan koneksi database
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                // Query menghapus data berdasarkan Kode Beli dan Kode Kue pada tabel detail
                cmd = new SqlCommand("EXECUTE hapus_detail_pembelian '" + txtKodeBeli.Text + "','" +
                    txtKodeKue.Text + "'", conn);
                // Buka koneksi database
                conn.Open();
                // Eksekusi query
                cmd.ExecuteNonQuery();

                // Cek data di detail pembelian
                cmd = new SqlCommand("SELECT * FROM detail_pembelian WHERE Kd_beli = '"
                    + txtKodeBeli.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read()) // Jika ada data detail pembelian
                {
                    // Panggil prosedur total seluruh
                    totalseluruh();
                }
                else // Jika belum ada data detail pembelian
                {
                    lblTotalBayar.Text = "0";
                }
                // Memanggil proc refresh transaksi pembelian
                RefreshTransaksiPembelian();
            }
        }

        private void dataGridPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tampilkan data pembelian per barang
            DataGridViewRow row = this.dataGridPembelian.Rows[e.RowIndex];
            txtKodeKue.Text = row.Cells["Kd_kue"].Value.ToString();
            txtNamaKue.Text = row.Cells["Nama_kue"].Value.ToString();
            txtHargaKue.Text = row.Cells["Harga_kue"].Value.ToString();
            txtJumlahBeli.Text = row.Cells["Jml_beli"].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Transaksi selesai
            MessageBox.Show("Transaksi Selesai");
            
            // Report - Memanggil report kwitansi
            FKwitansiPembelian kw = new FKwitansiPembelian();
            kw.Show();
            Awal();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Keluar form transaksi pembelian
            Close();
        }

        private void btnCariKue_Click(object sender, EventArgs e)
        {
            // Memanggil form cari kue
            FCariKue cariKue = new FCariKue();
            cariKue.ShowDialog();
            txtKodeKue.Text = cariKue.ambilKodeKue;
            txtNamaKue.Text = cariKue.ambilNamaKue;
            txtHargaKue.Text = cariKue.ambilHargaKue;
            txtJumlahBeli.Focus();
        }
    }
}



        


