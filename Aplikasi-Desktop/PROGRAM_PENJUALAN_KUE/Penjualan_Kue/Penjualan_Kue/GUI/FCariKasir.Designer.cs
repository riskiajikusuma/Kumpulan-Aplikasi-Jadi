namespace Penjualan_Kue.GUI
{
    partial class FCariKasir
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
            this.dataGridKasir = new System.Windows.Forms.DataGridView();
            this.txtCariKasir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKasir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridKasir);
            this.groupBox1.Controls.Add(this.txtCariKasir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Kasir";
            // 
            // dataGridKasir
            // 
            this.dataGridKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKasir.Location = new System.Drawing.Point(6, 105);
            this.dataGridKasir.Name = "dataGridKasir";
            this.dataGridKasir.Size = new System.Drawing.Size(714, 330);
            this.dataGridKasir.TabIndex = 2;
            this.dataGridKasir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKasir_CellClick);
            // 
            // txtCariKasir
            // 
            this.txtCariKasir.Location = new System.Drawing.Point(6, 63);
            this.txtCariKasir.Name = "txtCariKasir";
            this.txtCariKasir.Size = new System.Drawing.Size(714, 36);
            this.txtCariKasir.TabIndex = 1;
            this.txtCariKasir.TextChanged += new System.EventHandler(this.txtCariKasir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan Kode / Nama Kasir :";
            // 
            // FCariKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 462);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FCariKasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCariKasir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKasir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridKasir;
        private System.Windows.Forms.TextBox txtCariKasir;
        private System.Windows.Forms.Label label1;
    }
}