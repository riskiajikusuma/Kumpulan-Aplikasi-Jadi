namespace Penjualan_Kue.GUI
{
    partial class FMenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuKue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPenyuplaian = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPembelian = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolKasir = new System.Windows.Forms.ToolStripButton();
            this.toolSupplier = new System.Windows.Forms.ToolStripButton();
            this.toolPelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolKue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPenyuplaian = new System.Windows.Forms.ToolStripButton();
            this.toolPembelian = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMaster,
            this.menuTransaction,
            this.menuTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuLogin,
            this.subMenuLogout,
            this.subMenuExit});
            this.menuFile.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(41, 25);
            this.menuFile.Text = "&File";
            // 
            // subMenuLogin
            // 
            this.subMenuLogin.Image = global::Penjualan_Kue.Properties.Resources.icons8_Lock_96px;
            this.subMenuLogin.Name = "subMenuLogin";
            this.subMenuLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.subMenuLogin.Size = new System.Drawing.Size(171, 26);
            this.subMenuLogin.Text = "Login";
            this.subMenuLogin.Click += new System.EventHandler(this.subMenuLogin_Click);
            // 
            // subMenuLogout
            // 
            this.subMenuLogout.Image = global::Penjualan_Kue.Properties.Resources.icons8_Padlock_96px;
            this.subMenuLogout.Name = "subMenuLogout";
            this.subMenuLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.subMenuLogout.Size = new System.Drawing.Size(171, 26);
            this.subMenuLogout.Text = "Logout";
            this.subMenuLogout.Click += new System.EventHandler(this.subMenuLogout_Click);
            // 
            // subMenuExit
            // 
            this.subMenuExit.Image = global::Penjualan_Kue.Properties.Resources.icons8_Exit_Sign_96px;
            this.subMenuExit.Name = "subMenuExit";
            this.subMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.subMenuExit.Size = new System.Drawing.Size(171, 26);
            this.subMenuExit.Text = "Exit";
            this.subMenuExit.Click += new System.EventHandler(this.subMenuExit_Click);
            // 
            // menuMaster
            // 
            this.menuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuKasir,
            this.subMenuSupplier,
            this.subMenuPelanggan,
            this.subMenuKue});
            this.menuMaster.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMaster.Name = "menuMaster";
            this.menuMaster.Size = new System.Drawing.Size(63, 25);
            this.menuMaster.Text = "&Master";
            // 
            // subMenuKasir
            // 
            this.subMenuKasir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuKasir.Image = global::Penjualan_Kue.Properties.Resources.icons8_User_96px;
            this.subMenuKasir.Name = "subMenuKasir";
            this.subMenuKasir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.subMenuKasir.Size = new System.Drawing.Size(189, 26);
            this.subMenuKasir.Text = "Kasir";
            this.subMenuKasir.Click += new System.EventHandler(this.subMenuKasir_Click);
            // 
            // subMenuSupplier
            // 
            this.subMenuSupplier.Image = global::Penjualan_Kue.Properties.Resources.icons8_Supplier_96px;
            this.subMenuSupplier.Name = "subMenuSupplier";
            this.subMenuSupplier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.subMenuSupplier.Size = new System.Drawing.Size(189, 26);
            this.subMenuSupplier.Text = "Supplier";
            this.subMenuSupplier.Click += new System.EventHandler(this.subMenuSupplier_Click);
            // 
            // subMenuPelanggan
            // 
            this.subMenuPelanggan.Image = global::Penjualan_Kue.Properties.Resources.icons8_Team_96px;
            this.subMenuPelanggan.Name = "subMenuPelanggan";
            this.subMenuPelanggan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.subMenuPelanggan.Size = new System.Drawing.Size(189, 26);
            this.subMenuPelanggan.Text = "Pelanggan";
            this.subMenuPelanggan.Click += new System.EventHandler(this.subMenuPelanggan_Click);
            // 
            // subMenuKue
            // 
            this.subMenuKue.Image = global::Penjualan_Kue.Properties.Resources.icons8_Cupcake_96px;
            this.subMenuKue.Name = "subMenuKue";
            this.subMenuKue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.subMenuKue.Size = new System.Drawing.Size(189, 26);
            this.subMenuKue.Text = "Kue";
            this.subMenuKue.Click += new System.EventHandler(this.subMenuKue_Click);
            // 
            // menuTransaction
            // 
            this.menuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPenyuplaian,
            this.subMenuPembelian});
            this.menuTransaction.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(93, 25);
            this.menuTransaction.Text = "&Transaction";
            // 
            // subMenuPenyuplaian
            // 
            this.subMenuPenyuplaian.Image = global::Penjualan_Kue.Properties.Resources.icons8_Sell_Stock_96px;
            this.subMenuPenyuplaian.Name = "subMenuPenyuplaian";
            this.subMenuPenyuplaian.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.subMenuPenyuplaian.Size = new System.Drawing.Size(201, 26);
            this.subMenuPenyuplaian.Text = "Penyuplaian";
            this.subMenuPenyuplaian.Click += new System.EventHandler(this.subMenuPenyuplaian_Click);
            // 
            // subMenuPembelian
            // 
            this.subMenuPembelian.Image = global::Penjualan_Kue.Properties.Resources.icons8_Shopping_Cart_96px;
            this.subMenuPembelian.Name = "subMenuPembelian";
            this.subMenuPembelian.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.subMenuPembelian.Size = new System.Drawing.Size(201, 26);
            this.subMenuPembelian.Text = "Pembelian";
            this.subMenuPembelian.Click += new System.EventHandler(this.subMenuPembelian_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAbout});
            this.menuTools.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(52, 25);
            this.menuTools.Text = "T&ools";
            // 
            // subMenuAbout
            // 
            this.subMenuAbout.Image = global::Penjualan_Kue.Properties.Resources.icons8_About_96px;
            this.subMenuAbout.Name = "subMenuAbout";
            this.subMenuAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.subMenuAbout.Size = new System.Drawing.Size(165, 26);
            this.subMenuAbout.Text = "About";
            this.subMenuAbout.Click += new System.EventHandler(this.subMenuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolKasir,
            this.toolSupplier,
            this.toolPelanggan,
            this.toolKue,
            this.toolStripSeparator1,
            this.toolPenyuplaian,
            this.toolPembelian,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(923, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolKasir
            // 
            this.toolKasir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKasir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolKasir.Image = global::Penjualan_Kue.Properties.Resources.icons8_User_96px;
            this.toolKasir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKasir.Name = "toolKasir";
            this.toolKasir.Size = new System.Drawing.Size(23, 22);
            this.toolKasir.Text = "toolStripButton1";
            this.toolKasir.ToolTipText = "Tampilkan data kasir";
            this.toolKasir.Click += new System.EventHandler(this.toolKasir_Click);
            // 
            // toolSupplier
            // 
            this.toolSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSupplier.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSupplier.Image = global::Penjualan_Kue.Properties.Resources.icons8_Supplier_96px;
            this.toolSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSupplier.Name = "toolSupplier";
            this.toolSupplier.Size = new System.Drawing.Size(23, 22);
            this.toolSupplier.Text = "toolStripButton1";
            this.toolSupplier.ToolTipText = "Tampilkan data supplier";
            this.toolSupplier.Click += new System.EventHandler(this.toolSupplier_Click);
            // 
            // toolPelanggan
            // 
            this.toolPelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPelanggan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPelanggan.Image = global::Penjualan_Kue.Properties.Resources.icons8_Team_96px;
            this.toolPelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPelanggan.Name = "toolPelanggan";
            this.toolPelanggan.Size = new System.Drawing.Size(23, 22);
            this.toolPelanggan.Text = "toolStripButton1";
            this.toolPelanggan.ToolTipText = "Tampilkan data pelanggan";
            this.toolPelanggan.Click += new System.EventHandler(this.toolPelanggan_Click);
            // 
            // toolKue
            // 
            this.toolKue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKue.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolKue.Image = global::Penjualan_Kue.Properties.Resources.icons8_Cupcake_96px;
            this.toolKue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKue.Name = "toolKue";
            this.toolKue.Size = new System.Drawing.Size(23, 22);
            this.toolKue.Text = "toolStripButton1";
            this.toolKue.ToolTipText = "Tampilkan data kue";
            this.toolKue.Click += new System.EventHandler(this.toolKue_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolPenyuplaian
            // 
            this.toolPenyuplaian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPenyuplaian.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPenyuplaian.Image = global::Penjualan_Kue.Properties.Resources.icons8_Sell_Stock_96px;
            this.toolPenyuplaian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPenyuplaian.Name = "toolPenyuplaian";
            this.toolPenyuplaian.Size = new System.Drawing.Size(23, 22);
            this.toolPenyuplaian.Text = "toolStripButton1";
            this.toolPenyuplaian.ToolTipText = "Tampilkan data transaksi penyuplaian";
            this.toolPenyuplaian.Click += new System.EventHandler(this.toolPenyuplaian_Click);
            // 
            // toolPembelian
            // 
            this.toolPembelian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPembelian.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPembelian.Image = global::Penjualan_Kue.Properties.Resources.icons8_Shopping_Cart_96px;
            this.toolPembelian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPembelian.Name = "toolPembelian";
            this.toolPembelian.Size = new System.Drawing.Size(23, 22);
            this.toolPembelian.Text = "toolStripButton2";
            this.toolPembelian.ToolTipText = "Tampilkan data transaksi pembelian";
            this.toolPembelian.Click += new System.EventHandler(this.toolPembelian_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolExit.Image = global::Penjualan_Kue.Properties.Resources.icons8_Exit_Sign_96px;
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(23, 22);
            this.toolExit.Text = "toolStripButton3";
            this.toolExit.ToolTipText = "Keluar Aplikasi";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // FMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penjualan_Kue.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 434);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Penjualan Kue ABC Store :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menuFile;
        public System.Windows.Forms.ToolStripMenuItem subMenuLogin;
        public System.Windows.Forms.ToolStripMenuItem subMenuLogout;
        public System.Windows.Forms.ToolStripMenuItem subMenuExit;
        public System.Windows.Forms.ToolStripMenuItem menuMaster;
        public System.Windows.Forms.ToolStripMenuItem menuTransaction;
        public System.Windows.Forms.ToolStripMenuItem menuTools;
        public System.Windows.Forms.ToolStripMenuItem subMenuKasir;
        public System.Windows.Forms.ToolStripMenuItem subMenuSupplier;
        public System.Windows.Forms.ToolStripMenuItem subMenuPelanggan;
        public System.Windows.Forms.ToolStripMenuItem subMenuKue;
        public System.Windows.Forms.ToolStripMenuItem subMenuPenyuplaian;
        public System.Windows.Forms.ToolStripMenuItem subMenuPembelian;
        public System.Windows.Forms.ToolStripMenuItem subMenuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolKasir;
        public System.Windows.Forms.ToolStripButton toolSupplier;
        public System.Windows.Forms.ToolStripButton toolPelanggan;
        public System.Windows.Forms.ToolStripButton toolKue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolPenyuplaian;
        public System.Windows.Forms.ToolStripButton toolPembelian;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
    }
}