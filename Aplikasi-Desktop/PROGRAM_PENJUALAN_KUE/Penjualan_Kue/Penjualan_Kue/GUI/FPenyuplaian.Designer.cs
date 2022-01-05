namespace Penjualan_Kue.GUI
{
    partial class FPenyuplaian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPenyuplaian));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTanggalPenyuplaian = new System.Windows.Forms.DateTimePicker();
            this.txtKodeSuplai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCariSupplier = new System.Windows.Forms.Button();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCariKue = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtJumlahSuplai = new System.Windows.Forms.TextBox();
            this.txtNamaKue = new System.Windows.Forms.TextBox();
            this.txtKodeKue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridPenyuplaian = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenyuplaian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTanggalPenyuplaian);
            this.groupBox1.Controls.Add(this.txtKodeSuplai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penyuplaian";
            // 
            // dtpTanggalPenyuplaian
            // 
            this.dtpTanggalPenyuplaian.CustomFormat = "MM/dd/yyyy";
            this.dtpTanggalPenyuplaian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPenyuplaian.Location = new System.Drawing.Point(421, 23);
            this.dtpTanggalPenyuplaian.Name = "dtpTanggalPenyuplaian";
            this.dtpTanggalPenyuplaian.Size = new System.Drawing.Size(212, 36);
            this.dtpTanggalPenyuplaian.TabIndex = 2;
            this.dtpTanggalPenyuplaian.Value = new System.DateTime(2018, 8, 26, 0, 0, 0, 0);
            // 
            // txtKodeSuplai
            // 
            this.txtKodeSuplai.Location = new System.Drawing.Point(161, 23);
            this.txtKodeSuplai.Name = "txtKodeSuplai";
            this.txtKodeSuplai.Size = new System.Drawing.Size(173, 36);
            this.txtKodeSuplai.TabIndex = 1;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Suplai";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCariSupplier);
            this.groupBox2.Controls.Add(this.txtNamaSupplier);
            this.groupBox2.Controls.Add(this.txtIdSupplier);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Supplier";
            // 
            // btnCariSupplier
            // 
            this.btnCariSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCariSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariSupplier.Image = global::Penjualan_Kue.Properties.Resources.icons8_Search_32px_2;
            this.btnCariSupplier.Location = new System.Drawing.Point(369, 23);
            this.btnCariSupplier.Name = "btnCariSupplier";
            this.btnCariSupplier.Size = new System.Drawing.Size(76, 36);
            this.btnCariSupplier.TabIndex = 2;
            this.btnCariSupplier.UseVisualStyleBackColor = true;
            this.btnCariSupplier.Click += new System.EventHandler(this.btnCariSupplier_Click);
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(161, 65);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(284, 36);
            this.txtNamaSupplier.TabIndex = 1;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Location = new System.Drawing.Point(161, 23);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(204, 36);
            this.txtIdSupplier.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nama Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Supplier";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnCariKue);
            this.groupBox4.Controls.Add(this.btnKurang);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.txtJumlahSuplai);
            this.groupBox4.Controls.Add(this.txtNamaKue);
            this.groupBox4.Controls.Add(this.txtKodeKue);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 179);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Barang";
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
            this.btnKurang.Location = new System.Drawing.Point(560, 116);
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
            this.btnTambah.Location = new System.Drawing.Point(481, 116);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(73, 46);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtJumlahSuplai
            // 
            this.txtJumlahSuplai.Location = new System.Drawing.Point(161, 103);
            this.txtJumlahSuplai.Name = "txtJumlahSuplai";
            this.txtJumlahSuplai.Size = new System.Drawing.Size(204, 36);
            this.txtJumlahSuplai.TabIndex = 1;
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
            this.label10.Location = new System.Drawing.Point(8, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Jumlah Suplai";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kode Barang";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBaru);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(12, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 88);
            this.panel2.TabIndex = 8;
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
            this.btnSimpan.Image = global::Penjualan_Kue.Properties.Resources.icons8_Save_48px_1;
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
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.dataGridPenyuplaian);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(661, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(663, 465);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Penyuplaian";
            // 
            // dataGridPenyuplaian
            // 
            this.dataGridPenyuplaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPenyuplaian.Location = new System.Drawing.Point(6, 26);
            this.dataGridPenyuplaian.Name = "dataGridPenyuplaian";
            this.dataGridPenyuplaian.Size = new System.Drawing.Size(651, 433);
            this.dataGridPenyuplaian.TabIndex = 0;
            this.dataGridPenyuplaian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPenyuplaian_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(620, 34);
            this.textBox1.TabIndex = 3;
            // 
            // FPenyuplaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1335, 486);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FPenyuplaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Form Penyuplaian :.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenyuplaian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalPenyuplaian;
        private System.Windows.Forms.TextBox txtKodeSuplai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCariSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCariKue;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtJumlahSuplai;
        private System.Windows.Forms.TextBox txtNamaKue;
        private System.Windows.Forms.TextBox txtKodeKue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridPenyuplaian;
        private System.Windows.Forms.TextBox textBox1;
    }
}