namespace Meeting_Attendance
{
    partial class DaftarHadir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dh_listAcara = new System.Windows.Forms.ComboBox();
            this.btn_eksport = new System.Windows.Forms.Button();
            this.dh_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dh_sumHadir = new System.Windows.Forms.Label();
            this.dh_tabel = new System.Windows.Forms.DataGridView();
            this.dh_sumPeserta = new System.Windows.Forms.Label();
            this.dh_ID = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.dh_email = new System.Windows.Forms.ComboBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dh_tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.DarkGray;
            this.btn_batal.FlatAppearance.BorderSize = 0;
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(1095, 83);
            this.btn_batal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(150, 46);
            this.btn_batal.TabIndex = 47;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Gold;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(1095, 27);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 46);
            this.btn_edit.TabIndex = 45;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Email";
            // 
            // dh_listAcara
            // 
            this.dh_listAcara.FormattingEnabled = true;
            this.dh_listAcara.Location = new System.Drawing.Point(228, 142);
            this.dh_listAcara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dh_listAcara.Name = "dh_listAcara";
            this.dh_listAcara.Size = new System.Drawing.Size(859, 33);
            this.dh_listAcara.TabIndex = 49;
            this.dh_listAcara.SelectedIndexChanged += new System.EventHandler(this.dh_listAcara_SelectedIndexChanged);
            // 
            // btn_eksport
            // 
            this.btn_eksport.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_eksport.FlatAppearance.BorderSize = 0;
            this.btn_eksport.ForeColor = System.Drawing.Color.White;
            this.btn_eksport.Location = new System.Drawing.Point(1095, 138);
            this.btn_eksport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eksport.Name = "btn_eksport";
            this.btn_eksport.Size = new System.Drawing.Size(150, 46);
            this.btn_eksport.TabIndex = 50;
            this.btn_eksport.Text = "Ekspor";
            this.btn_eksport.UseVisualStyleBackColor = false;
            this.btn_eksport.Click += new System.EventHandler(this.btn_eksport_Click);
            // 
            // dh_status
            // 
            this.dh_status.FormattingEnabled = true;
            this.dh_status.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Sakit",
            "Tanpa Keterangan"});
            this.dh_status.Location = new System.Drawing.Point(228, 75);
            this.dh_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dh_status.Name = "dh_status";
            this.dh_status.Size = new System.Drawing.Size(444, 33);
            this.dh_status.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nama Acara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dh_sumHadir);
            this.groupBox2.Controls.Add(this.dh_tabel);
            this.groupBox2.Controls.Add(this.dh_sumPeserta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1216, 585);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Hadir";
            // 
            // dh_sumHadir
            // 
            this.dh_sumHadir.AutoSize = true;
            this.dh_sumHadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh_sumHadir.Location = new System.Drawing.Point(332, 542);
            this.dh_sumHadir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dh_sumHadir.Name = "dh_sumHadir";
            this.dh_sumHadir.Size = new System.Drawing.Size(149, 25);
            this.dh_sumHadir.TabIndex = 56;
            this.dh_sumHadir.Text = "Total Hadir : ";
            // 
            // dh_tabel
            // 
            this.dh_tabel.AllowUserToAddRows = false;
            this.dh_tabel.AllowUserToDeleteRows = false;
            this.dh_tabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dh_tabel.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dh_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dh_tabel.DefaultCellStyle = dataGridViewCellStyle6;
            this.dh_tabel.Location = new System.Drawing.Point(16, 42);
            this.dh_tabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dh_tabel.Name = "dh_tabel";
            this.dh_tabel.ReadOnly = true;
            this.dh_tabel.RowHeadersWidth = 82;
            this.dh_tabel.RowTemplate.Height = 33;
            this.dh_tabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dh_tabel.Size = new System.Drawing.Size(1184, 487);
            this.dh_tabel.TabIndex = 0;
            this.dh_tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dh_tabel_CellContentClick);
            // 
            // dh_sumPeserta
            // 
            this.dh_sumPeserta.AutoSize = true;
            this.dh_sumPeserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh_sumPeserta.Location = new System.Drawing.Point(32, 542);
            this.dh_sumPeserta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dh_sumPeserta.Name = "dh_sumPeserta";
            this.dh_sumPeserta.Size = new System.Drawing.Size(196, 25);
            this.dh_sumPeserta.TabIndex = 55;
            this.dh_sumPeserta.Text = "Jumlah Peserta : ";
            // 
            // dh_ID
            // 
            this.dh_ID.Location = new System.Drawing.Point(718, 33);
            this.dh_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dh_ID.Name = "dh_ID";
            this.dh_ID.Size = new System.Drawing.Size(100, 31);
            this.dh_ID.TabIndex = 54;
            this.dh_ID.Visible = false;
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.ForeColor = System.Drawing.Color.White;
            this.btn_tambah.Location = new System.Drawing.Point(937, 27);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(150, 46);
            this.btn_tambah.TabIndex = 55;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // dh_email
            // 
            this.dh_email.FormattingEnabled = true;
            this.dh_email.Location = new System.Drawing.Point(228, 33);
            this.dh_email.Name = "dh_email";
            this.dh_email.Size = new System.Drawing.Size(444, 33);
            this.dh_email.TabIndex = 56;
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Red;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Location = new System.Drawing.Point(937, 83);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(150, 46);
            this.btn_hapus.TabIndex = 57;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // DaftarHadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.dh_email);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.dh_ID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dh_status);
            this.Controls.Add(this.btn_eksport);
            this.Controls.Add(this.dh_listAcara);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DaftarHadir";
            this.Size = new System.Drawing.Size(1288, 794);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dh_tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dh_listAcara;
        private System.Windows.Forms.Button btn_eksport;
        private System.Windows.Forms.ComboBox dh_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dh_tabel;
        private System.Windows.Forms.TextBox dh_ID;
        private System.Windows.Forms.Label dh_sumHadir;
        private System.Windows.Forms.Label dh_sumPeserta;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.ComboBox dh_email;
        private System.Windows.Forms.Button btn_hapus;
    }
}
