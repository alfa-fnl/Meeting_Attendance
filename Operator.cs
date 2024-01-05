using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Attendance
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        private UserControl currentControl;

        private void ManajemenPesertaToPanel()
        {
            // Hapus user control saat ini (jika ada)
            if (currentControl != null)
            {
                panel1.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            // Buat dan tambahkan user control baru
            ManajemenPeserta manajemenPeserta = new ManajemenPeserta();
            panel1.Controls.Add(manajemenPeserta);

            // Tetapkan user control saat ini
            currentControl = manajemenPeserta;
        }

        private void DaftarHadirToPanel()
        {
            // Hapus user control saat ini (jika ada)
            if (currentControl != null)
            {
                panel1.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            // Buat dan tambahkan user control baru
            DaftarHadir daftarHadir = new DaftarHadir();
            panel1.Controls.Add(daftarHadir);

            // Tetapkan user control saat ini
            currentControl = daftarHadir;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }

        private void btn_peserta_Click(object sender, EventArgs e)
        {
            ManajemenPesertaToPanel();
        }

        private void btn_kehadiran_Click(object sender, EventArgs e)
        {
            DaftarHadirToPanel();
        }
    }
}
