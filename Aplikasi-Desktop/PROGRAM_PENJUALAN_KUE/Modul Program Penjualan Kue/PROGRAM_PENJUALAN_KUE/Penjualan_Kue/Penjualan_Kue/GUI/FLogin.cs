using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Tambahkan library baru
using System.Data.SqlClient;

namespace Penjualan_Kue.GUI
{
    public partial class FLogin : Form
    {
        // Tambahkan variabel cmd untuk menampung perintah SQL
        private SqlCommand cmd;
        // Import kelas koneksi.cs menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Coding button login
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_login WHERE ussername = '"
                + txtUssername.Text + "' AND password = '" + txtPassword.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read()) // Jika usser dan password benar
            {
                MessageBox.Show("Login Berhasil", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mengaktifkan semua menu dan toolbar yang sempat di non aktifkan
                FMenuUtama.mdiObj.menuMaster.Enabled = true;
                FMenuUtama.mdiObj.menuTransaction.Enabled = true;
                FMenuUtama.mdiObj.subMenuLogout.Enabled = true;
                FMenuUtama.mdiObj.subMenuLogin.Enabled = false;
                FMenuUtama.mdiObj.toolKasir.Enabled = true;
                FMenuUtama.mdiObj.toolPelanggan.Enabled = true;
                FMenuUtama.mdiObj.toolSupplier.Enabled = true;
                FMenuUtama.mdiObj.toolKue.Enabled = true;
                FMenuUtama.mdiObj.toolPenyuplaian.Enabled = true;
                FMenuUtama.mdiObj.toolPembelian.Enabled = true;
                this.Close(); // Form login keluar
            }
            else // Jika usser atau password salah
            {
                MessageBox.Show("Ussername atau Password Salah !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUssername.Text = "";
                txtPassword.Text = "";
                txtUssername.Focus();
            }
            conn.Close(); // Tutup koneksi
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Keluar dari form login
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memberikan event pada tombol enter
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e); // Memanggil kode dari button login
            }
        }
    }
}
    
