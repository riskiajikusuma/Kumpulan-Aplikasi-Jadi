namespace Penjualan_Kue.GUI
{
    partial class FCariPelanggan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridPelanggan = new System.Windows.Forms.DataGridView();
            this.txtCariPelanggan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridPelanggan);
            this.groupBox1.Controls.Add(this.txtCariPelanggan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pelanggan";
            // 
            // dataGridPelanggan
            // 
            this.dataGridPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPelanggan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPelanggan.Location = new System.Drawing.Point(6, 105);
            this.dataGridPelanggan.Name = "dataGridPelanggan";
            this.dataGridPelanggan.Size = new System.Drawing.Size(714, 330);
            this.dataGridPelanggan.TabIndex = 2;
            this.dataGridPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPelanggan_CellClick);
            // 
            // txtCariPelanggan
            // 
            this.txtCariPelanggan.Location = new System.Drawing.Point(6, 63);
            this.txtCariPelanggan.Name = "txtCariPelanggan";
            this.txtCariPelanggan.Size = new System.Drawing.Size(714, 36);
            this.txtCariPelanggan.TabIndex = 1;
            this.txtCariPelanggan.TextChanged += new System.EventHandler(this.txtCariPelanggan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan Kode / Nama Pelanggan :";
            // 
            // FCariPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(749, 465);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FCariPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCariPelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridPelanggan;
        private System.Windows.Forms.TextBox txtCariPelanggan;
        private System.Windows.Forms.Label label1;

    }
}