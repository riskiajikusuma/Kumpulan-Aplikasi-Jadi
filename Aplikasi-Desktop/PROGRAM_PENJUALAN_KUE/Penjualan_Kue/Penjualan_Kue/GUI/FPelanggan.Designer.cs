namespace Penjualan_Kue.GUI
{
    partial class FPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPelanggan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoTelpPelanggan = new System.Windows.Forms.TextBox();
            this.txtAlamatPelanggan = new System.Windows.Forms.TextBox();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.txtIdPelanggan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listPelanggan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCariPelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPelanggan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNoTelpPelanggan);
            this.groupBox1.Controls.Add(this.txtAlamatPelanggan);
            this.groupBox1.Controls.Add(this.txtNamaPelanggan);
            this.groupBox1.Controls.Add(this.txtIdPelanggan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Pelanggan";
            // 
            // txtNoTelpPelanggan
            // 
            this.txtNoTelpPelanggan.Location = new System.Drawing.Point(171, 266);
            this.txtNoTelpPelanggan.Name = "txtNoTelpPelanggan";
            this.txtNoTelpPelanggan.Size = new System.Drawing.Size(237, 36);
            this.txtNoTelpPelanggan.TabIndex = 1;
            // 
            // txtAlamatPelanggan
            // 
            this.txtAlamatPelanggan.Location = new System.Drawing.Point(171, 143);
            this.txtAlamatPelanggan.Multiline = true;
            this.txtAlamatPelanggan.Name = "txtAlamatPelanggan";
            this.txtAlamatPelanggan.Size = new System.Drawing.Size(356, 110);
            this.txtAlamatPelanggan.TabIndex = 1;
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(171, 94);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(356, 36);
            this.txtNamaPelanggan.TabIndex = 1;
            // 
            // txtIdPelanggan
            // 
            this.txtIdPelanggan.Location = new System.Drawing.Point(171, 45);
            this.txtIdPelanggan.Name = "txtIdPelanggan";
            this.txtIdPelanggan.Size = new System.Drawing.Size(237, 36);
            this.txtIdPelanggan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nomor Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pelanggan";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listPelanggan);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(554, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 369);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Data Pelanggan";
            // 
            // listPelanggan
            // 
            this.listPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPelanggan.Location = new System.Drawing.Point(6, 23);
            this.listPelanggan.Name = "listPelanggan";
            this.listPelanggan.Size = new System.Drawing.Size(527, 340);
            this.listPelanggan.TabIndex = 0;
            this.listPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPelanggan_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnBaru);
            this.panel2.Location = new System.Drawing.Point(12, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 115);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSimpan);
            this.panel3.Location = new System.Drawing.Point(378, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 115);
            this.panel3.TabIndex = 4;
            // 
            // txtCariPelanggan
            // 
            this.txtCariPelanggan.Location = new System.Drawing.Point(752, 398);
            this.txtCariPelanggan.Name = "txtCariPelanggan";
            this.txtCariPelanggan.Size = new System.Drawing.Size(341, 36);
            this.txtCariPelanggan.TabIndex = 3;
            this.txtCariPelanggan.TextChanged += new System.EventHandler(this.txtCariPelanggan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(555, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cari Nama Pelanggan :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
            this.btnSimpan.Image = global::Penjualan_Kue.Properties.Resources.icons8_Save_48px_1;
            this.btnSimpan.Location = new System.Drawing.Point(12, 13);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(149, 90);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.Black;
            this.btnHapus.Image = global::Penjualan_Kue.Properties.Resources.icons8_Trash_32px_3;
            this.btnHapus.Location = new System.Drawing.Point(3, 61);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(171, 42);
            this.btnHapus.TabIndex = 0;
            this.btnHapus.Text = "&Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.ForeColor = System.Drawing.Color.Black;
            this.btnKeluar.Image = global::Penjualan_Kue.Properties.Resources.icons8_Exit_32px_2;
            this.btnKeluar.Location = new System.Drawing.Point(189, 61);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(171, 42);
            this.btnKeluar.TabIndex = 0;
            this.btnKeluar.Text = "  &Keluar";
            this.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::Penjualan_Kue.Properties.Resources.icons8_Edit_File_32px_3;
            this.btnEdit.Location = new System.Drawing.Point(189, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 42);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "  &Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaru.ForeColor = System.Drawing.Color.Black;
            this.btnBaru.Image = global::Penjualan_Kue.Properties.Resources.icons8_Add_New_32px_3;
            this.btnBaru.Location = new System.Drawing.Point(3, 13);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(171, 42);
            this.btnBaru.TabIndex = 0;
            this.btnBaru.Text = "  &Baru";
            this.btnBaru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // FPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1107, 468);
            this.Controls.Add(this.txtCariPelanggan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Form Pelanggan :.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listPelanggan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNoTelpPelanggan;
        private System.Windows.Forms.TextBox txtAlamatPelanggan;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.TextBox txtIdPelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listPelanggan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtCariPelanggan;
        private System.Windows.Forms.Label label4;

    }
}