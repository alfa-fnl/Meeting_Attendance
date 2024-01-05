using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meeting_Attendance;

namespace Meeting_Attendance
{
    public partial class Admin : Form
    {
        Koneksi koneksi = new Koneksi();

        public Admin()
        {
            InitializeComponent();
        }

        private UserControl currentControl;

        private void ManajemenPenggunaToPanel()
        {
            // Hapus user control saat ini (jika ada)
            if (currentControl != null)
            {
                panel1.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            // Buat dan tambahkan user control baru
            ManajemenUser manajemenUser = new ManajemenUser();
            panel1.Controls.Add(manajemenUser);

            // Tetapkan user control saat ini
            currentControl = manajemenUser;
        }

        private void ManajemenAcaraToPanel()
        {
            if (currentControl != null)
            {
                panel1.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            ManajemenAcara manajemenAcara = new ManajemenAcara();
            panel1.Controls.Add(manajemenAcara);

            currentControl = manajemenAcara;
        }

        private void LaporanAdminToPanel()
        {
            if (currentControl != null)
            {
                panel1.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            LaporanAdmin laporanAdmin = new LaporanAdmin();
            panel1.Controls.Add(laporanAdmin);

            currentControl = laporanAdmin;
        }

        //btn_pengguna
        private void button3_Click(object sender, EventArgs e)
        {
            ManajemenPenggunaToPanel();
        }

        private void btn_acara_Click(object sender, EventArgs e)
        {
            ManajemenAcaraToPanel();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            LaporanAdminToPanel();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }
    }
}
