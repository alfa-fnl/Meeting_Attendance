using System;
using System.Collections;
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
    public partial class ManajemenUser : UserControl
    {
        Koneksi koneksi = new Koneksi();

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlCommand command;

        public ManajemenUser()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            mu_email.Text = string.Empty;
            mu_nama.Text = string.Empty;
            mu_username.Text = string.Empty;
            mu_password.Text = string.Empty;
            mu_noTelpon.Text = string.Empty;
            mu_jabatan.SelectedIndex = -1;

            // Refresh DataGridView setelah membatalkan
            LoadUserData();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // Validasi data sebelum menambahkan
            if (string.IsNullOrEmpty(mu_email.Text) || string.IsNullOrEmpty(mu_nama.Text) || string.IsNullOrEmpty(mu_username.Text) ||
                string.IsNullOrEmpty(mu_password.Text) || string.IsNullOrEmpty(mu_noTelpon.Text) || mu_jabatan.SelectedIndex == -1)
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
                               "VALUES (@Email, @Nama, @Username, @Password, @NoTelpon, @Jabatan)";
                command = new SqlCommand(query, conn);

                // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                command.Parameters.AddWithValue("@Email", mu_email.Text);
                command.Parameters.AddWithValue("@Nama", mu_nama.Text);
                command.Parameters.AddWithValue("@Username", mu_username.Text);
                command.Parameters.AddWithValue("@Password", mu_password.Text);
                command.Parameters.AddWithValue("@NoTelpon", mu_noTelpon.Text);
                command.Parameters.AddWithValue("@Jabatan", mu_jabatan.SelectedItem.ToString());

                // Eksekusi perintah SQL untuk menambahkan data
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bersihkan input setelah data ditambahkan
                    mu_email.Text = string.Empty;
                    mu_nama.Text = string.Empty;
                    mu_username.Text = string.Empty;
                    mu_password.Text = string.Empty;
                    mu_noTelpon.Text = string.Empty;
                    mu_jabatan.SelectedIndex = -1;

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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Pastikan email tidak kosong
            if (string.IsNullOrEmpty(mu_email.Text))
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konfirmasi pembaruan
            DialogResult result = MessageBox.Show("Anda yakin ingin memperbarui data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lakukan pembaruan
                UpdateUser(mu_email.Text);

                // Bersihkan input setelah data diperbarui
                mu_email.Text = string.Empty;
                mu_nama.Text = string.Empty;
                mu_username.Text = string.Empty;
                mu_password.Text = string.Empty;
                mu_noTelpon.Text = string.Empty;
                mu_jabatan.SelectedIndex = -1;

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
                string query = "UPDATE users SET [Nama Lengkap] = @Nama, Username = @Username, " +
                               "Password = @Password, [No. Telepon] = @NoTelpon, Jabatan = @Jabatan " +
                               "WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@Nama", mu_nama.Text);
                    command.Parameters.AddWithValue("@Username", mu_username.Text);
                    command.Parameters.AddWithValue("@Password", mu_password.Text);
                    command.Parameters.AddWithValue("@NoTelpon", mu_noTelpon.Text);
                    command.Parameters.AddWithValue("@Jabatan", mu_jabatan.SelectedItem.ToString());
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

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            // Pastikan email tidak kosong
            if (string.IsNullOrEmpty(mu_email.Text))
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lakukan penghapusan
                DeleteUser(mu_email.Text);

                // Bersihkan input setelah data ditambahkan
                mu_email.Text = string.Empty;
                mu_nama.Text = string.Empty;
                mu_username.Text = string.Empty;
                mu_password.Text = string.Empty;
                mu_noTelpon.Text = string.Empty;
                mu_jabatan.SelectedIndex = -1;

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

        private void LoadUserData()
        {
            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                string query = "SELECT Email, [Nama Lengkap], Username, [No. Telepon], Jabatan FROM users WHERE Jabatan != 'Peserta'";
                adapter = new SqlDataAdapter(query, conn);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data ke DataGridView
                mu_tabel.DataSource = dataTable;
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

        private void mu_tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan tidak ada klik di header kolom
            if (e.RowIndex >= 0)
            {
                // Ambil data dari baris yang diklik
                DataGridViewRow row = mu_tabel.Rows[e.RowIndex];

                // Tampilkan data di TextBox dan ComboBox
                mu_email.Text = row.Cells["Email"].Value.ToString();
                mu_nama.Text = row.Cells["Nama Lengkap"].Value.ToString();
                mu_username.Text = row.Cells["Username"].Value.ToString();
                mu_noTelpon.Text = row.Cells["No. Telepon"].Value.ToString();
                mu_jabatan.SelectedItem = row.Cells["Jabatan"].Value.ToString();

                // Ambil dan tampilkan nilai password dari database untuk baris yang diklik
                string email = row.Cells["Email"].Value.ToString();
                string password = GetPasswordFromDatabase(email); // Fungsi untuk mengambil password dari database
                mu_password.Text = password;
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
    }
}
