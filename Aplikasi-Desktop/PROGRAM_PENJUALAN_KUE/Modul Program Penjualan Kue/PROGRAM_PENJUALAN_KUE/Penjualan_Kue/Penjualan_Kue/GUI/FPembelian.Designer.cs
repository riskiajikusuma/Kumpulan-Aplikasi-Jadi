﻿namespace Penjualan_Kue.GUI
{
    partial class FPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPembelian));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCariPelanggan = new System.Windows.Forms.Button();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.txtIdPelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCariKasir = new System.Windows.Forms.Button();
            this.txtNamaKasir = new System.Windows.Forms.TextBox();
            this.txtIdKasir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCariKue = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtJumlahBeli = new System.Windows.Forms.TextBox();
            this.txtHargaKue = new System.Windows.Forms.TextBox();
            this.txtNamaKue = new System.Windows.Forms.TextBox();
            this.txtKodeKue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridPembelian = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodeBeli = new System.Windows.Forms.TextBox();
            this.dtpTanggalPembelian = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPembelian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCariPelanggan);
            this.groupBox2.Controls.Add(this.txtNamaPelanggan);
            this.groupBox2.Controls.Add(this.txtIdPelanggan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Pelanggan";
            // 
            // btnCariPelanggan
            // 
            this.btnCariPelanggan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCariPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariPelanggan.Image = global::Penjualan_Kue.Properties.Resources.icons8_Search_32px_2;
            this.btnCariPelanggan.Location = new System.Drawing.Point(369, 23);
            this.btnCariPelanggan.Name = "btnCariPelanggan";
            this.btnCariPelanggan.Size = new System.Drawing.Size(76, 36);
            this.btnCariPelanggan.TabIndex = 2;
            this.btnCariPelanggan.UseVisualStyleBackColor = true;
            this.btnCariPelanggan.Click += new System.EventHandler(this.btnCariPelanggan_Click);
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(161, 65);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(284, 36);
            this.txtNamaPelanggan.TabIndex = 1;
            // 
            // txtIdPelanggan
            // 
            this.txtIdPelanggan.Location = new System.Drawing.Point(161, 23);
            this.txtIdPelanggan.Name = "txtIdPelanggan";
            this.txtIdPelanggan.Size = new System.Drawing.Size(204, 36);
            this.txtIdPelanggan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nama Pelanggan";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Pelanggan";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnCariKasir);
            this.groupBox3.Controls.Add(this.txtNamaKasir);
            this.groupBox3.Controls.Add(this.txtIdKasir);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Kasir";
            // 
            // btnCariKasir
            // 
            this.btnCariKasir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCariKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariKasir.Image = global::Penjualan_Kue.Properties.Resources.icons8_Search_32px_2;
            this.btnCariKasir.Location = new System.Drawing.Point(369, 22);
            this.btnCariKasir.Name = "btnCariKasir";
            this.btnCariKasir.Size = new System.Drawing.Size(76, 36);
            this.btnCariKasir.TabIndex = 2;
            this.btnCariKasir.UseVisualStyleBackColor = true;
            this.btnCariKasir.Click += new System.EventHandler(this.btnCariKasir_Click);
            // 
            // txtNamaKasir
            // 
            this.txtNamaKasir.Location = new System.Drawing.Point(161, 67);
            this.txtNamaKasir.Name = "txtNamaKasir";
            this.txtNamaKasir.Size = new System.Drawing.Size(284, 36);
            this.txtNamaKasir.TabIndex = 1;
            // 
            // txtIdKasir
            // 
            this.txtIdKasir.Location = new System.Drawing.Point(161, 23);
            this.txtIdKasir.Name = "txtIdKasir";
            this.txtIdKasir.Size = new System.Drawing.Size(204, 36);
            this.txtIdKasir.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nama Kasir";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id Kasir";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnCariKue);
            this.groupBox4.Controls.Add(this.btnKurang);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.txtJumlahBeli);
            this.groupBox4.Controls.Add(this.txtHargaKue);
            this.groupBox4.Controls.Add(this.txtNamaKue);
            this.groupBox4.Controls.Add(this.txtKodeKue);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 198);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Kue";
            // 
            // btnCariKue
            // 
            this.btnCariKue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCariKue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariKue.Image = global::Penjualan_Kue.Properties.Resources.icons8_Search_32px_2;
            this.btnCariKue.Location = new System.Drawing.Point(371, 19);
            this.btnCariKue.Name = "btnCariKue";
            this.btnCariKue.Size = new System.Drawing.Size(76, 36);
            this.btnCariKue.TabIndex = 3;
            this.btnCariKue.UseVisualStyleBackColor = true;
            this.btnCariKue.Click += new System.EventHandler(this.btnCariKue_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKurang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKurang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKurang.Image = global::Penjualan_Kue.Properties.Resources.icons8_Close_Window_48px;
            this.btnKurang.Location = new System.Drawing.Point(560, 141);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(73, 46);
            this.btnKurang.TabIndex = 2;
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Image = global::Penjualan_Kue.Properties.Resources.icons8_Plus_48px;
            this.btnTambah.Location = new System.Drawing.Point(481, 141);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(73, 46);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtJumlahBeli
            // 
            this.txtJumlahBeli.Location = new System.Drawing.Point(161, 147);
            this.txtJumlahBeli.Name = "txtJumlahBeli";
            this.txtJumlahBeli.Size = new System.Drawing.Size(204, 36);
            this.txtJumlahBeli.TabIndex = 1;
            // 
            // txtHargaKue
            // 
            this.txtHargaKue.Location = new System.Drawing.Point(161, 105);
            this.txtHargaKue.Name = "txtHargaKue";
            this.txtHargaKue.Size = new System.Drawing.Size(284, 36);
            this.txtHargaKue.TabIndex = 1;
            // 
            // txtNamaKue
            // 
            this.txtNamaKue.Location = new System.Drawing.Point(161, 61);
            this.txtNamaKue.Name = "txtNamaKue";
            this.txtNamaKue.Size = new System.Drawing.Size(349, 36);
            this.txtNamaKue.TabIndex = 1;
            // 
            // txtKodeKue
            // 
            this.txtKodeKue.Location = new System.Drawing.Point(161, 19);
            this.txtKodeKue.Name = "txtKodeKue";
            this.txtKodeKue.Size = new System.Drawing.Size(204, 36);
            this.txtKodeKue.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Jumlah Beli";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Harga Kue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama Kue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kode Kue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Bayar";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBaru);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(12, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 88);
            this.panel2.TabIndex = 7;
            // 
            // btnBaru
            // 
            this.btnBaru.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaru.ForeColor = System.Drawing.Color.Black;
            this.btnBaru.Image = global::Penjualan_Kue.Properties.Resources.icons8_Add_List_48px;
            this.btnBaru.Location = new System.Drawing.Point(11, 14);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(175, 58);
            this.btnBaru.TabIndex = 2;
            this.btnBaru.Text = "&Baru";
            this.btnBaru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
            this.btnSimpan.Image = global::Penjualan_Kue.Properties.Resources.icons8_Save_48px_11;
            this.btnSimpan.Location = new System.Drawing.Point(192, 14);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(164, 58);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.ForeColor = System.Drawing.Color.Black;
            this.btnKeluar.Image = global::Penjualan_Kue.Properties.Resources.icons8_Exit_48px_1;
            this.btnKeluar.Location = new System.Drawing.Point(458, 14);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(175, 58);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "&Keluar";
            this.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.dataGridPembelian);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(661, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(663, 645);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Pembelian";
            // 
            // dataGridPembelian
            // 
            this.dataGridPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPembelian.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPembelian.Location = new System.Drawing.Point(6, 23);
            this.dataGridPembelian.Name = "dataGridPembelian";
            this.dataGridPembelian.Size = new System.Drawing.Size(651, 616);
            this.dataGridPembelian.TabIndex = 0;
            this.dataGridPembelian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPembelian_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(166, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 42);
            this.label12.TabIndex = 9;
            this.label12.Text = "Rp. ";
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBayar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBayar.Location = new System.Drawing.Point(247, 521);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(180, 42);
            this.lblTotalBayar.TabIndex = 9;
            this.lblTotalBayar.Text = "lblTotalBayar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Beli";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKodeBeli
            // 
            this.txtKodeBeli.Location = new System.Drawing.Point(161, 23);
            this.txtKodeBeli.Name = "txtKodeBeli";
            this.txtKodeBeli.Size = new System.Drawing.Size(173, 36);
            this.txtKodeBeli.TabIndex = 1;
            // 
            // dtpTanggalPembelian
            // 
            this.dtpTanggalPembelian.CustomFormat = "MM/dd/yyyy";
            this.dtpTanggalPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPembelian.Location = new System.Drawing.Point(421, 23);
            this.dtpTanggalPembelian.Name = "dtpTanggalPembelian";
            this.dtpTanggalPembelian.Size = new System.Drawing.Size(212, 36);
            this.dtpTanggalPembelian.TabIndex = 2;
            this.dtpTanggalPembelian.Value = new System.DateTime(2018, 8, 26, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTanggalPembelian);
            this.groupBox1.Controls.Add(this.txtKodeBeli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pembelian";
            // 
            // FPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1335, 672);
            this.Controls.Add(this.lblTotalBayar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Form Pembelian :.";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPembelian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.TextBox txtIdPelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNamaKasir;
        private System.Windows.Forms.TextBox txtIdKasir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJumlahBeli;
        private System.Windows.Forms.TextBox txtHargaKue;
        private System.Windows.Forms.TextBox txtNamaKue;
        private System.Windows.Forms.TextBox txtKodeKue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.DataGridView dataGridPembelian;
        private System.Windows.Forms.Button btnCariPelanggan;
        private System.Windows.Forms.Button btnCariKasir;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTanggalPembelian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCariKue;
        public System.Windows.Forms.TextBox txtKodeBeli;
    }
}