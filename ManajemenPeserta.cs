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
    public partial class ManajemenPeserta : UserControl
    {
        Koneksi koneksi = new Koneksi();

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlCommand command;

        public ManajemenPeserta()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            mp_email.Text = string.Empty;
            mp_nama.Text = string.Empty;
            mp_username.Text = string.Empty;
            mp_password.Text = string.Empty;
            mp_noTelpon.Text = string.Empty;

            // Refresh DataGridView setelah membatalkan
            LoadUserData();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // Validasi data sebelum menambahkan
            if (string.IsNullOrEmpty(mp_email.Text) || string.IsNullOrEmpty(mp_nama.Text) || string.IsNullOrEmpty(mp_username.Text) || string.IsNullOrEmpty(mp_password.Text) || string.IsNullOrEmpty(mp_noTelpon.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel di database Anda
                string query = "INSERT INTO users (Email, [Nama Lengkap], Username, Password, [No. Telepon], Jabatan) " +
                               "VALUES (@Email, @Nama, @Username, @Password, @NoTelpon, 'Peserta')";
                command = new SqlCommand(query, conn);

                // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                command.Parameters.AddWithValue("@Email", mp_email.Text);
                command.Parameters.AddWithValue("@Nama", mp_nama.Text);
                command.Parameters.AddWithValue("@Username", mp_username.Text);
                command.Parameters.AddWithValue("@Password", mp_password.Text);
                command.Parameters.AddWithValue("@NoTelpon", mp_noTelpon.Text);

                // Eksekusi perintah SQL untuk menambahkan data
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bersihkan input setelah data ditambahkan
                    mp_email.Text = string.Empty;
                    mp_nama.Text = string.Empty;
                    mp_username.Text = string.Empty;
                    mp_password.Text = string.Empty;
                    mp_noTelpon.Text = string.Empty;

                    // Refresh DataGridView setelah menambahkan data
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadUserData()
        {
            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                string query = "SELECT Email, [Nama Lengkap], Username, [No. Telepon] FROM users WHERE Jabatan = 'Peserta'";
                adapter = new SqlDataAdapter(query, conn);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data ke DataGridView
                mp_tabel.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void mp_tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan tidak ada klik di header kolom
            if (e.RowIndex >= 0)
            {
                // Ambil data dari baris yang diklik
                DataGridViewRow row = mp_tabel.Rows[e.RowIndex];

                // Tampilkan data di TextBox dan ComboBox
                mp_email.Text = row.Cells["Email"].Value.ToString();
                mp_nama.Text = row.Cells["Nama Lengkap"].Value.ToString();
                mp_username.Text = row.Cells["Username"].Value.ToString();
                mp_noTelpon.Text = row.Cells["No. Telepon"].Value.ToString();

                // Ambil dan tampilkan nilai password dari database untuk baris yang diklik
                string email = row.Cells["Email"].Value.ToString();
                string password = GetPasswordFromDatabase(email); // Fungsi untuk mengambil password dari database
                mp_password.Text = password;
            }
        }

        private string GetPasswordFromDatabase(string email)
        {
            // Fungsi ini mengambil password dari database berdasarkan username
            // Sesuaikan dengan struktur dan query database Anda
            using (SqlConnection conn = koneksi.GetKoneksi())
            {
                conn.Open();
                string query = "SELECT Password FROM users WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            // Pastikan email tidak kosong
            if (string.IsNullOrEmpty(mp_email.Text))
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lakukan penghapusan
                DeleteUser(mp_email.Text);

                // Bersihkan input setelah data ditambahkan
                mp_email.Text = string.Empty;
                mp_nama.Text = string.Empty;
                mp_username.Text = string.Empty;
                mp_password.Text = string.Empty;
                mp_noTelpon.Text = string.Empty;

                // Refresh DataGridView setelah penghapusan
                LoadUserData();
            }
        }

        private void DeleteUser(string email)
        {
            using (SqlConnection conn = koneksi.GetKoneksi())
            {
                conn.Open();
                // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                string query = "DELETE FROM users WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Pastikan email tidak kosong
            if (string.IsNullOrEmpty(mp_email.Text))
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konfirmasi pembaruan
            DialogResult result = MessageBox.Show("Anda yakin ingin memperbarui data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lakukan pembaruan
                UpdateUser(mp_email.Text);

                // Bersihkan input setelah data diperbarui
                mp_email.Text = string.Empty;
                mp_nama.Text = string.Empty;
                mp_username.Text = string.Empty;
                mp_password.Text = string.Empty;
                mp_noTelpon.Text = string.Empty;

                // Refresh DataGridView setelah pembaruan
                LoadUserData();
            }
        }

        private void UpdateUser(string email)
        {
            using (SqlConnection conn = koneksi.GetKoneksi())
            {
                conn.Open();
                // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                string query = "UPDATE users SET [Nama Lengkap] = @Nama, Username = @Username, Password = @Password, [No. Telepon] = @NoTelpon WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@Nama", mp_nama.Text);
                    command.Parameters.AddWithValue("@Username", mp_username.Text);
                    command.Parameters.AddWithValue("@Password", mp_password.Text);
                    command.Parameters.AddWithValue("@NoTelpon", mp_noTelpon.Text);
                    command.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diupdate. Pastikan tidak mengubah email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
