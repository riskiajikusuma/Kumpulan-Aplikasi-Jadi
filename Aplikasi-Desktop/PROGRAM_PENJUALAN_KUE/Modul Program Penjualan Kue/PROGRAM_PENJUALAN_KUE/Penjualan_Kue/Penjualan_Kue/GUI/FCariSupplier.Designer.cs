namespace Penjualan_Kue.GUI
{
    partial class FCariSupplier
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
            this.dataGridSupplier = new System.Windows.Forms.DataGridView();
            this.txtCariSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridSupplier);
            this.groupBox1.Controls.Add(this.txtCariSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 441);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Supplier";
            // 
            // dataGridSupplier
            // 
            this.dataGridSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSupplier.Location = new System.Drawing.Point(6, 105);
            this.dataGridSupplier.Name = "dataGridSupplier";
            this.dataGridSupplier.Size = new System.Drawing.Size(714, 330);
            this.dataGridSupplier.TabIndex = 2;
            this.dataGridSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSupplier_CellClick);
            // 
            // txtCariSupplier
            // 
            this.txtCariSupplier.Location = new System.Drawing.Point(6, 63);
            this.txtCariSupplier.Name = "txtCariSupplier";
            this.txtCariSupplier.Size = new System.Drawing.Size(714, 36);
            this.txtCariSupplier.TabIndex = 1;
            this.txtCariSupplier.TextChanged += new System.EventHandler(this.txtCariSupplier_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan Kode / Nama Supplier :";
            // 
            // FCariSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(747, 464);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCariSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCariSupplier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridSupplier;
        private System.Windows.Forms.TextBox txtCariSupplier;
        private System.Windows.Forms.Label label1;
    }
}