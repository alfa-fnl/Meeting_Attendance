namespace Meeting_Attendance
{
    partial class Peserta
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
            this.p_acara = new System.Windows.Forms.TextBox();
            this.p_nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_presensi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p_status = new System.Windows.Forms.ComboBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // p_acara
            // 
            this.p_acara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_acara.Location = new System.Drawing.Point(329, 214);
            this.p_acara.Margin = new System.Windows.Forms.Padding(2);
            this.p_acara.Name = "p_acara";
            this.p_acara.Size = new System.Drawing.Size(222, 20);
            this.p_acara.TabIndex = 45;
            // 
            // p_nama
            // 
            this.p_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_nama.Location = new System.Drawing.Point(329, 191);
            this.p_nama.Margin = new System.Windows.Forms.Padding(2);
            this.p_nama.Name = "p_nama";
            this.p_nama.ReadOnly = true;
            this.p_nama.Size = new System.Drawing.Size(222, 20);
            this.p_nama.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID Acara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nama Lengkap";
            // 
            // btn_presensi
            // 
            this.btn_presensi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_presensi.FlatAppearance.BorderSize = 0;
            this.btn_presensi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_presensi.ForeColor = System.Drawing.Color.White;
            this.btn_presensi.Location = new System.Drawing.Point(241, 282);
            this.btn_presensi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_presensi.Name = "btn_presensi";
            this.btn_presensi.Size = new System.Drawing.Size(310, 24);
            this.btn_presensi.TabIndex = 46;
            this.btn_presensi.Text = "Tambah";
            this.btn_presensi.UseVisualStyleBackColor = false;
            this.btn_presensi.Click += new System.EventHandler(this.btn_presensi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Status";
            // 
            // p_status
            // 
            this.p_status.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.p_status.FormattingEnabled = true;
            this.p_status.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Sakit",
            "Tanpa Keterangan"});
            this.p_status.Location = new System.Drawing.Point(329, 237);
            this.p_status.Margin = new System.Windows.Forms.Padding(2);
            this.p_status.Name = "p_status";
            this.p_status.Size = new System.Drawing.Size(222, 21);
            this.p_status.TabIndex = 48;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(692, 17);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 24);
            this.btn_logout.TabIndex = 49;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(225, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 193);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Presensi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Meeting_Attendance.Properties.Resources.Icon;
            this.pictureBox2.Location = new System.Drawing.Point(316, 155);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Peserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(789, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.p_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_presensi);
            this.Controls.Add(this.p_acara);
            this.Controls.Add(this.p_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(727, 461);
            this.Name = "Peserta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peserta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p_acara;
        private System.Windows.Forms.TextBox p_nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_presensi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox p_status;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}