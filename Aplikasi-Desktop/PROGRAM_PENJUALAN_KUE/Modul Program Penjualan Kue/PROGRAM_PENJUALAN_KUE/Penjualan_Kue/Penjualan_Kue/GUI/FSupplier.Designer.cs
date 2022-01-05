namespace Penjualan_Kue.GUI
{
    partial class FSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSupplier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoTelpSupplier = new System.Windows.Forms.TextBox();
            this.txtAlamatSupplier = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listSupplier = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtCariSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSupplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNoTelpSupplier);
            this.groupBox1.Controls.Add(this.txtAlamatSupplier);
            this.groupBox1.Controls.Add(this.txtNamaSupplier);
            this.groupBox1.Controls.Add(this.txtIdSupplier);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 322);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Supplier";
            // 
            // txtNoTelpSupplier
            // 
            this.txtNoTelpSupplier.Location = new System.Drawing.Point(171, 266);
            this.txtNoTelpSupplier.Name = "txtNoTelpSupplier";
            this.txtNoTelpSupplier.Size = new System.Drawing.Size(237, 36);
            this.txtNoTelpSupplier.TabIndex = 1;
            // 
            // txtAlamatSupplier
            // 
            this.txtAlamatSupplier.Location = new System.Drawing.Point(171, 143);
            this.txtAlamatSupplier.Multiline = true;
            this.txtAlamatSupplier.Name = "txtAlamatSupplier";
            this.txtAlamatSupplier.Size = new System.Drawing.Size(356, 110);
            this.txtAlamatSupplier.TabIndex = 1;
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(171, 94);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(356, 36);
            this.txtNamaSupplier.TabIndex = 1;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Location = new System.Drawing.Point(171, 45);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(237, 36);
            this.txtIdSupplier.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Supplier";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listSupplier);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(554, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 383);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Data Supplier";
            // 
            // listSupplier
            // 
            this.listSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listSupplier.BackgroundColor = System.Drawing.Color.White;
            this.listSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSupplier.Location = new System.Drawing.Point(6, 23);
            this.listSupplier.Name = "listSupplier";
            this.listSupplier.Size = new System.Drawing.Size(527, 354);
            this.listSupplier.TabIndex = 0;
            this.listSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listSupplier_CellClick);
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
            this.panel2.TabIndex = 6;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSimpan);
            this.panel3.Location = new System.Drawing.Point(378, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 115);
            this.panel3.TabIndex = 6;
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
            // txtCariSupplier
            // 
            this.txtCariSupplier.Location = new System.Drawing.Point(736, 405);
            this.txtCariSupplier.Name = "txtCariSupplier";
            this.txtCariSupplier.Size = new System.Drawing.Size(357, 36);
            this.txtCariSupplier.TabIndex = 7;
            this.txtCariSupplier.TextChanged += new System.EventHandler(this.txtCariSupplier_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(549, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cari Nama Supplier :";
            // 
            // FSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1103, 467);
            this.Controls.Add(this.txtCariSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Form Supplier :.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSupplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNoTelpSupplier;
        private System.Windows.Forms.TextBox txtAlamatSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtCariSupplier;
        private System.Windows.Forms.Label label4;
    }
}