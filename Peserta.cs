using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Attendance
{
    public partial class Peserta : Form
    {
        Koneksi koneksi = new Koneksi();

        private SqlCommand command;

        public Peserta()
        {
            InitializeComponent();

            loadNamaUser();
        }

        private void loadNamaUser()
        {
            // Mengisi nilai otomatis pada TextBox p_nama
            string userEmail = UserSession.LoggedInUserEmail;
            p_nama.Text = GetUserNameFromEmail(userEmail);
        }

        private void btn_presensi_Click(object sender, EventArgs e)
        {
            // Memastikan bahwa Nama Peserta dan Status Kehadiran sudah diisi
            if (string.IsNullOrEmpty(p_acara.Text) || p_status.SelectedItem == null)
            {
                MessageBox.Show("Nama Peserta dan Status Kehadiran harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Menyimpan data kehadiran ke database
            UpdateAttendanceData(UserSession.LoggedInUserEmail, p_acara.Text, p_status.SelectedItem.ToString(), DateTime.Now);

            // Membersihkan input setelah data ditambahkan
            p_acara.Text = string.Empty;
            p_status.SelectedIndex = -1;
        }

        private void UpdateAttendanceData(string userEmail, string IDAcara, string statusKehadiran, DateTime waktuKehadiran)
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Sesuaikan query dengan struktur tabel dan kolom di database Anda
                    string query = "UPDATE daftar_hadir " +
                                   "SET Status = @StatusKehadiran, Waktu = @WaktuKehadiran " +
                                   "WHERE AcaraID = @AcaraID AND Email = @Email";

                    command = new SqlCommand(query, conn);

                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@AcaraID", IDAcara);
                    command.Parameters.AddWithValue("@Email", userEmail); // Menggunakan metode GetUserNameFromEmail untuk mendapatkan nama lengkap
                    command.Parameters.AddWithValue("@StatusKehadiran", statusKehadiran);
                    command.Parameters.AddWithValue("@WaktuKehadiran", waktuKehadiran);

                    // Eksekusi perintah SQL untuk melakukan update data
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data kehadiran berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data kehadiran gagal diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private string GetUserNameFromEmail(string userEmail)
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Sesuaikan query dengan struktur tabel dan kolom di database Anda
                    string query = "SELECT [Nama Lengkap] FROM users WHERE Email = @UserEmail";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserEmail", userEmail);
                        object result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }
    }
}
