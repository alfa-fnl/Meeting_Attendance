namespace Meeting_Attendance
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_acara = new System.Windows.Forms.Button();
            this.btn_pengguna = new System.Windows.Forms.Button();
            this.btn_laporan = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrator";
            // 
            // btn_acara
            // 
            this.btn_acara.Location = new System.Drawing.Point(11, 65);
            this.btn_acara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_acara.Name = "btn_acara";
            this.btn_acara.Size = new System.Drawing.Size(122, 22);
            this.btn_acara.TabIndex = 4;
            this.btn_acara.Text = "Manajemen Acara";
            this.btn_acara.UseVisualStyleBackColor = true;
            this.btn_acara.Click += new System.EventHandler(this.btn_acara_Click);
            // 
            // btn_pengguna
            // 
            this.btn_pengguna.Location = new System.Drawing.Point(11, 97);
            this.btn_pengguna.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pengguna.Name = "btn_pengguna";
            this.btn_pengguna.Size = new System.Drawing.Size(122, 22);
            this.btn_pengguna.TabIndex = 5;
            this.btn_pengguna.Text = "Manajemen Pengguna";
            this.btn_pengguna.UseVisualStyleBackColor = true;
            this.btn_pengguna.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.Location = new System.Drawing.Point(11, 129);
            this.btn_laporan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(122, 22);
            this.btn_laporan.TabIndex = 7;
            this.btn_laporan.Text = "Laporan Kehadiran";
            this.btn_laporan.UseVisualStyleBackColor = true;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(11, 160);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(122, 22);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(144, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 413);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(0, 54);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(789, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(789, 44);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 414);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 458);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_laporan);
            this.Controls.Add(this.btn_pengguna);
            this.Controls.Add(this.btn_acara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_acara;
        private System.Windows.Forms.Button btn_pengguna;
        private System.Windows.Forms.Button btn_laporan;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1;
    }
}