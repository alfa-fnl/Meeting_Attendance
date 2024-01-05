namespace Meeting_Attendance
{
    partial class ManajemenPeserta
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
            this.mp_tabel = new System.Windows.Forms.DataGridView();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.mp_noTelpon = new System.Windows.Forms.TextBox();
            this.mp_password = new System.Windows.Forms.TextBox();
            this.mp_username = new System.Windows.Forms.TextBox();
            this.mp_nama = new System.Windows.Forms.TextBox();
            this.mp_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mp_tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mp_tabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 260);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Peserta";
            // 
            // mp_tabel
            // 
            this.mp_tabel.AllowUserToAddRows = false;
            this.mp_tabel.AllowUserToDeleteRows = false;
            this.mp_tabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mp_tabel.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.mp_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mp_tabel.DefaultCellStyle = dataGridViewCellStyle1;
            this.mp_tabel.Location = new System.Drawing.Point(8, 19);
            this.mp_tabel.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tabel.Name = "mp_tabel";
            this.mp_tabel.ReadOnly = true;
            this.mp_tabel.RowHeadersWidth = 82;
            this.mp_tabel.RowTemplate.Height = 33;
            this.mp_tabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mp_tabel.Size = new System.Drawing.Size(592, 231);
            this.mp_tabel.TabIndex = 0;
            this.mp_tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mp_tabel_CellContentClick);
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
            this.btn_batal.TabIndex = 32;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Red;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Location = new System.Drawing.Point(354, 44);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 24);
            this.btn_hapus.TabIndex = 31;
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
            this.btn_edit.TabIndex = 30;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.ForeColor = System.Drawing.Color.White;
            this.btn_tambah.Location = new System.Drawing.Point(354, 17);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 24);
            this.btn_tambah.TabIndex = 29;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // mp_noTelpon
            // 
            this.mp_noTelpon.Location = new System.Drawing.Point(114, 106);
            this.mp_noTelpon.Margin = new System.Windows.Forms.Padding(2);
            this.mp_noTelpon.Name = "mp_noTelpon";
            this.mp_noTelpon.Size = new System.Drawing.Size(224, 20);
            this.mp_noTelpon.TabIndex = 28;
            // 
            // mp_password
            // 
            this.mp_password.Location = new System.Drawing.Point(114, 83);
            this.mp_password.Margin = new System.Windows.Forms.Padding(2);
            this.mp_password.Name = "mp_password";
            this.mp_password.Size = new System.Drawing.Size(224, 20);
            this.mp_password.TabIndex = 27;
            // 
            // mp_username
            // 
            this.mp_username.Location = new System.Drawing.Point(114, 61);
            this.mp_username.Margin = new System.Windows.Forms.Padding(2);
            this.mp_username.Name = "mp_username";
            this.mp_username.Size = new System.Drawing.Size(224, 20);
            this.mp_username.TabIndex = 26;
            // 
            // mp_nama
            // 
            this.mp_nama.Location = new System.Drawing.Point(114, 39);
            this.mp_nama.Margin = new System.Windows.Forms.Padding(2);
            this.mp_nama.Name = "mp_nama";
            this.mp_nama.Size = new System.Drawing.Size(224, 20);
            this.mp_nama.TabIndex = 25;
            // 
            // mp_email
            // 
            this.mp_email.Location = new System.Drawing.Point(114, 17);
            this.mp_email.Margin = new System.Windows.Forms.Padding(2);
            this.mp_email.Name = "mp_email";
            this.mp_email.Size = new System.Drawing.Size(224, 20);
            this.mp_email.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "No. Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email";
            // 
            // ManajemenPeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.mp_noTelpon);
            this.Controls.Add(this.mp_password);
            this.Controls.Add(this.mp_username);
            this.Controls.Add(this.mp_nama);
            this.Controls.Add(this.mp_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManajemenPeserta";
            this.Size = new System.Drawing.Size(644, 413);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mp_tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView mp_tabel;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox mp_noTelpon;
        private System.Windows.Forms.TextBox mp_password;
        private System.Windows.Forms.TextBox mp_username;
        private System.Windows.Forms.TextBox mp_nama;
        private System.Windows.Forms.TextBox mp_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
