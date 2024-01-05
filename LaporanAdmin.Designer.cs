namespace Meeting_Attendance
{
    partial class LaporanAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.la_sumHadir = new System.Windows.Forms.Label();
            this.la_sumPeserta = new System.Windows.Forms.Label();
            this.la_tabel = new System.Windows.Forms.DataGridView();
            this.btn_eksport = new System.Windows.Forms.Button();
            this.la_listAcara = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.la_tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.la_sumHadir);
            this.groupBox1.Controls.Add(this.la_sumPeserta);
            this.groupBox1.Controls.Add(this.la_tabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 352);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laporan Kehadiran";
            // 
            // la_sumHadir
            // 
            this.la_sumHadir.AutoSize = true;
            this.la_sumHadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_sumHadir.Location = new System.Drawing.Point(166, 333);
            this.la_sumHadir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.la_sumHadir.Name = "la_sumHadir";
            this.la_sumHadir.Size = new System.Drawing.Size(82, 13);
            this.la_sumHadir.TabIndex = 2;
            this.la_sumHadir.Text = "Total Hadir : ";
            // 
            // la_sumPeserta
            // 
            this.la_sumPeserta.AutoSize = true;
            this.la_sumPeserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_sumPeserta.Location = new System.Drawing.Point(16, 333);
            this.la_sumPeserta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.la_sumPeserta.Name = "la_sumPeserta";
            this.la_sumPeserta.Size = new System.Drawing.Size(105, 13);
            this.la_sumPeserta.TabIndex = 1;
            this.la_sumPeserta.Text = "Jumlah Peserta : ";
            // 
            // la_tabel
            // 
            this.la_tabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.la_tabel.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.la_tabel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.la_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.la_tabel.Location = new System.Drawing.Point(8, 22);
            this.la_tabel.Margin = new System.Windows.Forms.Padding(2);
            this.la_tabel.Name = "la_tabel";
            this.la_tabel.RowHeadersWidth = 82;
            this.la_tabel.RowTemplate.Height = 33;
            this.la_tabel.Size = new System.Drawing.Size(592, 301);
            this.la_tabel.TabIndex = 0;
            // 
            // btn_eksport
            // 
            this.btn_eksport.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_eksport.FlatAppearance.BorderSize = 0;
            this.btn_eksport.ForeColor = System.Drawing.Color.White;
            this.btn_eksport.Location = new System.Drawing.Point(268, 16);
            this.btn_eksport.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eksport.Name = "btn_eksport";
            this.btn_eksport.Size = new System.Drawing.Size(75, 24);
            this.btn_eksport.TabIndex = 32;
            this.btn_eksport.Text = "Ekspor";
            this.btn_eksport.UseVisualStyleBackColor = false;
            this.btn_eksport.Click += new System.EventHandler(this.btn_eksport_Click);
            // 
            // la_listAcara
            // 
            this.la_listAcara.FormattingEnabled = true;
            this.la_listAcara.Location = new System.Drawing.Point(24, 18);
            this.la_listAcara.Margin = new System.Windows.Forms.Padding(2);
            this.la_listAcara.Name = "la_listAcara";
            this.la_listAcara.Size = new System.Drawing.Size(229, 21);
            this.la_listAcara.TabIndex = 33;
            this.la_listAcara.SelectedIndexChanged += new System.EventHandler(this.la_listAcara_SelectedIndexChanged);
            // 
            // LaporanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.la_listAcara);
            this.Controls.Add(this.btn_eksport);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LaporanAdmin";
            this.Size = new System.Drawing.Size(644, 413);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.la_tabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView la_tabel;
        private System.Windows.Forms.Button btn_eksport;
        private System.Windows.Forms.ComboBox la_listAcara;
        private System.Windows.Forms.Label la_sumHadir;
        private System.Windows.Forms.Label la_sumPeserta;
    }
}
