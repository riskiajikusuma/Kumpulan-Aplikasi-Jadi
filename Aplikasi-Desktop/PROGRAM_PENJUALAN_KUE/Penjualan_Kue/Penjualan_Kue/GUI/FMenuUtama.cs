using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Penjualan_Kue.GUI
{
    public partial class FMenuUtama : Form
    {
        // Membuat variabel / objek dari form terkait
        public static FMenuUtama mdiObj;
        FPelanggan plg;
        FKasir ksr;
        FSupplier supp;
        FKue kue;
        FPenyuplaian suplai;
        FPembelian beli;
        FAboutProgrammer aboutProg;

        // Membuat prosedur event form closed
        void Proc_KasirClosed(Object sender, FormClosedEventArgs e)
        {
            ksr = null;
        }

        void Proc_PelangganClosed(Object sender, FormClosedEventArgs e)
        {
            plg = null;
        }

        void Proc_SupplierClosed(Object sender, FormClosedEventArgs e)
        {
            supp = null;
        }

        void Proc_KueClosed(Object sender, FormClosedEventArgs e)
        {
            kue = null;
        }

        void Proc_PenyuplaianClosed(Object sender, FormClosedEventArgs e)
        {
            suplai = null;
        }

        void Proc_PembelianClosed(Object sender, FormClosedEventArgs e)
        {
            beli = null;
        }

        void Proc_AboutProgrammerClosed(Object sender, FormClosedEventArgs e)
        {
            aboutProg = null;
        }

        public FMenuUtama()
        {
            InitializeComponent();
        }

        private void subMenuExit_Click(object sender, EventArgs e)
        {
            // Membuat kode keluar aplikasi
            if (MessageBox.Show("Keluar dari aplikasi ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu exit
            subMenuExit_Click(sender, e);
        }

        private void subMenuKasir_Click(object sender, EventArgs e)
        {
            // Memanggil form kasir
            if (ksr == null)
            {
                ksr = new FKasir();
                ksr.MdiParent = this;
                ksr.FormClosed += new FormClosedEventHandler(Proc_KasirClosed);
                ksr.Show();
            }
            else
            {
                ksr.Activate();
            }
        }

        private void toolKasir_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu kasir
            subMenuKasir_Click(sender, e);
        }

        private void subMenuSupplier_Click(object sender, EventArgs e)
        {
            // Memanggil form supplier
            if (supp == null)
            {
                supp = new FSupplier();
                supp.MdiParent = this;
                supp.FormClosed += new FormClosedEventHandler(Proc_SupplierClosed);
                supp.Show();
            }
            else
            {
                supp.Activate();
            }
        }

        private void toolSupplier_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu supplier
            subMenuSupplier_Click(sender, e);
        }

        private void subMenuPelanggan_Click(object sender, EventArgs e)
        {
            // Memanggil form pelanggan
            if (plg == null)
            {
                plg = new FPelanggan();
                plg.MdiParent = this;
                plg.FormClosed += new FormClosedEventHandler(Proc_PelangganClosed);
                plg.Show();
            }
            else
            {
                plg.Activate();
            }
        }

        private void toolPelanggan_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu pelanggan
            subMenuPelanggan_Click(sender, e);
        }

        private void subMenuKue_Click(object sender, EventArgs e)
        {
            // Memanggil form kue
            if (kue == null)
            {
                kue = new FKue();
                kue.MdiParent = this;
                kue.FormClosed += new FormClosedEventHandler(Proc_KueClosed);
                kue.Show();
            }
            else
            {
                kue.Activate();
            }
        }

        private void toolKue_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu kue
            subMenuKue_Click(sender, e);
        }

        private void subMenuPenyuplaian_Click(object sender, EventArgs e)
        {
            // Memanggil form penyuplaian
            if (suplai == null)
            {
                suplai = new FPenyuplaian();
                suplai.MdiParent = this;
                suplai.FormClosed += new FormClosedEventHandler(Proc_PenyuplaianClosed);
                suplai.Show();
            }
            else
            {
                suplai.Activate();
            }
        }

        private void toolPenyuplaian_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu penyuplaian
            subMenuPenyuplaian_Click(sender, e);
        }

        private void subMenuPembelian_Click(object sender, EventArgs e)
        {
            // Memanggil form pembelian
            if (beli == null)
            {
                beli = new FPembelian();
                beli.MdiParent = this;
                beli.FormClosed += new FormClosedEventHandler(Proc_PembelianClosed);
                beli.Show();
            }
            else
            {
                beli.Activate();
            }
        }

        private void toolPembelian_Click(object sender, EventArgs e)
        {
            // Memanggil kode dari event click pada menu pembelian
            subMenuPembelian_Click(sender, e);
        }

        private void subMenuAbout_Click(object sender, EventArgs e)
        {
            // Memanggil form about programmer
            if (aboutProg == null)
            {
                aboutProg = new FAboutProgrammer();
                aboutProg.MdiParent = this;
                aboutProg.FormClosed += new FormClosedEventHandler(Proc_AboutProgrammerClosed);
                aboutProg.Show();
            }
            else
            {
                aboutProg.Activate();
            }
        }

        private void FMenuUtama_Load(object sender, EventArgs e)
        {
            // Non aktifkan beberapa menu pada saat menu utama aktif
            menuMaster.Enabled = false;
            menuTransaction.Enabled = false;
            subMenuLogin.Enabled = true;
            subMenuLogout.Enabled = false;
            toolPelanggan.Enabled = false;
            toolKasir.Enabled = false;
            toolSupplier.Enabled = false;
            toolKue.Enabled = false;
            toolPenyuplaian.Enabled = false;
            toolPembelian.Enabled = false;

            // Memberikan nilai untuk var mdiObj adalah FMenuUtama
            mdiObj = this;

            // Menampilkan form login
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        private void subMenuLogout_Click(object sender, EventArgs e)
        {
            // Non aktifkan beberapa menu pada saat logout
            menuMaster.Enabled = false;
            menuTransaction.Enabled = false;
            subMenuLogin.Enabled = true;
            subMenuLogout.Enabled = false;
            toolPelanggan.Enabled = false;
            toolKasir.Enabled = false;
            toolSupplier.Enabled = false;
            toolKue.Enabled = false;
            toolPenyuplaian.Enabled = false;
            toolPembelian.Enabled = false;
        }

        private void subMenuLogin_Click(object sender, EventArgs e)
        {
            // Memanggil form login dari menu login
            FLogin login = new FLogin();
            login.ShowDialog();
        }


    }
}
