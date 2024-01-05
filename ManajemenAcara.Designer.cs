namespace Meeting_Attendance
{
    partial class ManajemenAcara
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
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.ma_deskripsi = new System.Windows.Forms.TextBox();
            this.ma_lokasi = new System.Windows.Forms.TextBox();
            this.ma_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ma_tanggal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ma_tabel = new System.Windows.Forms.DataGridView();
            this.ma_Stime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ma_Ntime = new System.Windows.Forms.DateTimePicker();
            this.ma_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ma_operator = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma_tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.DarkGray;
            this.btn_batal.FlatAppearance.BorderSize = 0;
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(434, 44);
            this.btn_batal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 24);
            this.btn_batal.TabIndex = 27;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Red;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Location = new System.Drawing.Point(355, 44);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 24);
            this.btn_hapus.TabIndex = 26;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Gold;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(434, 17);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 24);
            this.btn_edit.TabIndex = 25;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.ForeColor = System.Drawing.Color.White;
            this.btn_tambah.Location = new System.Drawing.Point(355, 17);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 24);
            this.btn_tambah.TabIndex = 24;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // ma_deskripsi
            // 
            this.ma_deskripsi.Location = new System.Drawing.Point(115, 110);
            this.ma_deskripsi.Margin = new System.Windows.Forms.Padding(2);
            this.ma_deskripsi.Multiline = true;
            this.ma_deskripsi.Name = "ma_deskripsi";
            this.ma_deskripsi.Size = new System.Drawing.Size(396, 41);
            this.ma_deskripsi.TabIndex = 23;
            // 
            // ma_lokasi
            // 
            this.ma_lokasi.Location = new System.Drawing.Point(115, 87);
            this.ma_lokasi.Margin = new System.Windows.Forms.Padding(2);
            this.ma_lokasi.Name = "ma_lokasi";
            this.ma_lokasi.Size = new System.Drawing.Size(224, 20);
            this.ma_lokasi.TabIndex = 22;
            // 
            // ma_nama
            // 
            this.ma_nama.Location = new System.Drawing.Point(115, 17);
            this.ma_nama.Margin = new System.Windows.Forms.Padding(2);
            this.ma_nama.Name = "ma_nama";
            this.ma_nama.Size = new System.Drawing.Size(224, 20);
            this.ma_nama.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Deskripsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lokasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nama Acara";
            // 
            // ma_tanggal
            // 
            this.ma_tanggal.Location = new System.Drawing.Point(115, 40);
            this.ma_tanggal.Margin = new System.Windows.Forms.Padding(2);
            this.ma_tanggal.Name = "ma_tanggal";
            this.ma_tanggal.Size = new System.Drawing.Size(224, 20);
            this.ma_tanggal.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ma_tabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 214);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Acara";
            // 
            // ma_tabel
            // 
            this.ma_tabel.AllowUserToAddRows = false;
            this.ma_tabel.AllowUserToDeleteRows = false;
            this.ma_tabel.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ma_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ma_tabel.DefaultCellStyle = dataGridViewCellStyle1;
            this.ma_tabel.Location = new System.Drawing.Point(8, 19);
            this.ma_tabel.Margin = new System.Windows.Forms.Padding(2);
            this.ma_tabel.Name = "ma_tabel";
            this.ma_tabel.ReadOnly = true;
            this.ma_tabel.RowHeadersWidth = 82;
            this.ma_tabel.RowTemplate.Height = 33;
            this.ma_tabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ma_tabel.Size = new System.Drawing.Size(592, 185);
            this.ma_tabel.TabIndex = 0;
            this.ma_tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ma_tabel_CellContentClick);
            // 
            // ma_Stime
            // 
            this.ma_Stime.CustomFormat = "HH.mm";
            this.ma_Stime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ma_Stime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ma_Stime.Location = new System.Drawing.Point(115, 63);
            this.ma_Stime.Margin = new System.Windows.Forms.Padding(2);
            this.ma_Stime.Name = "ma_Stime";
            this.ma_Stime.ShowUpDown = true;
            this.ma_Stime.Size = new System.Drawing.Size(110, 20);
            this.ma_Stime.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Waktu";
            // 
            // ma_Ntime
            // 
            this.ma_Ntime.CustomFormat = "HH.mm";
            this.ma_Ntime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ma_Ntime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ma_Ntime.Location = new System.Drawing.Point(229, 63);
            this.ma_Ntime.Margin = new System.Windows.Forms.Padding(2);
            this.ma_Ntime.Name = "ma_Ntime";
            this.ma_Ntime.ShowUpDown = true;
            this.ma_Ntime.Size = new System.Drawing.Size(110, 20);
            this.ma_Ntime.TabIndex = 33;
            // 
            // ma_ID
            // 
            this.ma_ID.Location = new System.Drawing.Point(552, 21);
            this.ma_ID.Margin = new System.Windows.Forms.Padding(2);
            this.ma_ID.Name = "ma_ID";
            this.ma_ID.Size = new System.Drawing.Size(71, 20);
            this.ma_ID.TabIndex = 34;
            this.ma_ID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Operator";
            // 
            // ma_operator
            // 
            this.ma_operator.FormattingEnabled = true;
            this.ma_operator.Location = new System.Drawing.Point(115, 155);
            this.ma_operator.Margin = new System.Windows.Forms.Padding(2);
            this.ma_operator.Name = "ma_operator";
            this.ma_operator.Size = new System.Drawing.Size(224, 21);
            this.ma_operator.TabIndex = 37;
            // 
            // ManajemenAcara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ma_operator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ma_ID);
            this.Controls.Add(this.ma_Ntime);
            this.Controls.Add(this.ma_Stime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ma_tanggal);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.ma_deskripsi);
            this.Controls.Add(this.ma_lokasi);
            this.Controls.Add(this.ma_nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManajemenAcara";
            this.Size = new System.Drawing.Size(644, 413);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ma_tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox ma_deskripsi;
        private System.Windows.Forms.TextBox ma_lokasi;
        private System.Windows.Forms.TextBox ma_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ma_tanggal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ma_tabel;
        private System.Windows.Forms.DateTimePicker ma_Stime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ma_Ntime;
        private System.Windows.Forms.TextBox ma_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ma_operator;
    }
}
