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
    public partial class ManajemenAcara : UserControl
    {
        Koneksi koneksi = new Koneksi();

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlCommand command;

        public ManajemenAcara()
        {
            InitializeComponent();

            LoadDataAcara();
            LoadOperatorData();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            ma_ID.Text = string.Empty;
            ma_nama.Text = string.Empty;
            ma_tanggal.Value = DateTime.Now;
            ma_Stime.Value = DateTime.Now;
            ma_Ntime.Value = DateTime.Now;
            ma_lokasi.Text = string.Empty;
            ma_deskripsi.Text = string.Empty;
            ma_operator.SelectedIndex = -1;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // Validasi data sebelum menambahkan
            if (string.IsNullOrEmpty(ma_nama.Text) || ma_tanggal.Value == null || ma_Stime.Value == null || ma_Ntime.Value == null || string.IsNullOrEmpty(ma_lokasi.Text) || string.IsNullOrEmpty(ma_deskripsi.Text) || ma_operator.SelectedIndex == -1)
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel di database Anda
                string query = "INSERT INTO acara ([Nama Acara], Tanggal, [Waktu Mulai], [Waktu Selesai], Lokasi, Deskripsi, Operator) " +
                               "VALUES (@Nama, @Tanggal, @WaktuMulai, @WaktuSelesai, @Lokasi, @Deskripsi, @Operator)";
                command = new SqlCommand(query, conn);

                // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                command.Parameters.AddWithValue("@Nama", ma_nama.Text);
                command.Parameters.AddWithValue("@Tanggal", ma_tanggal.Value.Date);
                command.Parameters.AddWithValue("@WaktuMulai", ma_Stime.Value.TimeOfDay);
                command.Parameters.AddWithValue("@WaktuSelesai", ma_Ntime.Value.TimeOfDay);
                command.Parameters.AddWithValue("@Lokasi", ma_lokasi.Text);
                command.Parameters.AddWithValue("@Deskripsi", ma_deskripsi.Text);
                command.Parameters.AddWithValue("@Operator", ma_operator.SelectedItem.ToString());

                // Eksekusi perintah SQL untuk menambahkan data
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bersihkan input setelah data ditambahkan
                    ma_ID.Text = string.Empty;
                    ma_nama.Text = string.Empty;
                    ma_tanggal.Value = DateTime.Now;
                    ma_Stime.Value = DateTime.Now;
                    ma_Ntime.Value = DateTime.Now;
                    ma_lokasi.Text = string.Empty;
                    ma_deskripsi.Text = string.Empty;
                    ma_operator.SelectedIndex = -1;

                    // Refresh DataGridView setelah menambahkan data
                    LoadDataAcara();
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

        private void LoadDataAcara()
        {
            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                string query = "SELECT ID, [Nama Acara], Tanggal, CONVERT(varchar(5), [Waktu Mulai], 108) AS [Waktu Mulai], CONVERT(varchar(5), [Waktu Selesai], 108) AS [Waktu Selesai], Lokasi, Deskripsi, Operator FROM acara";
                adapter = new SqlDataAdapter(query, conn);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data ke DataGridView
                ma_tabel.DataSource = dataTable;

                foreach (DataGridViewColumn column in ma_tabel.Columns)
                {
                    // Mengecualikan kolom "Deskripsi" dari penyesuaian otomatis
                    if (column.Name == "Deskripsi")
                    {
                        // Mengatur lebar kolom "Deskripsi" secara manual
                        column.Width = 200; // Ganti nilai sesuai kebutuhan
                    }
                    else if (column.Name == "Lokasi")
                    {
                        // Mengatur lebar kolom "Deskripsi" secara manual
                        column.Width = 150; // Ganti nilai sesuai kebutuhan
                    }
                    else
                    {
                        // Set AutoSizeMode ke AllCells untuk membuat lebar kolom mengikuti data di dalamnya
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
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

        private void LoadOperatorData()
        {
            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                string query = "SELECT Email FROM users WHERE Jabatan = 'operator'";
                adapter = new SqlDataAdapter(query, conn);

                DataTable operatorDataTable = new DataTable();
                adapter.Fill(operatorDataTable);

                // Bersihkan item yang mungkin sudah ada di ComboBox Operator
                ma_operator.Items.Clear();

                // Tambahkan nama pengguna ke dalam ComboBox Operator
                foreach (DataRow row in operatorDataTable.Rows)
                {
                    ma_operator.Items.Add(row["Email"].ToString());
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


        private void ma_tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan tidak ada klik di header kolom
            if (e.RowIndex >= 0)
            {
                // Ambil data dari baris yang diklik
                DataGridViewRow row = ma_tabel.Rows[e.RowIndex];

                // Tampilkan data di TextBox dan ComboBox
                ma_ID.Text = row.Cells["ID"].Value.ToString();
                ma_nama.Text = row.Cells["Nama Acara"].Value.ToString();

                // Konversi nilai dari sel Tanggal ke DateTime dan tetapkan ke DateTimePicker
                if (DateTime.TryParse(row.Cells["Tanggal"].Value.ToString(), out DateTime tanggal))
                {
                    ma_tanggal.Value = tanggal;
                }

                // Konversi nilai dari sel Waktu ke DateTime dan ambil bagian waktu
                if (DateTime.TryParse(row.Cells["Waktu Mulai"].Value.ToString(), out DateTime waktuMulai))
                {
                    ma_Stime.Value = waktuMulai;
                }

                if (DateTime.TryParse(row.Cells["Waktu Selesai"].Value.ToString(), out DateTime waktuSelesai))
                {
                    ma_Ntime.Value = waktuSelesai;
                }

                ma_lokasi.Text = row.Cells["Lokasi"].Value.ToString();
                ma_deskripsi.Text = row.Cells["Deskripsi"].Value.ToString();
                ma_operator.SelectedItem = row.Cells["Operator"].Value.ToString();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (ma_tabel.SelectedRows.Count > 0)
            {
                // Ambil ID atau kunci unik dari baris yang dipilih
                int selectedRowID = Convert.ToInt32(ma_tabel.SelectedRows[0].Cells["ID"].Value);

                // Hapus data dari database
                if (DeleteUserData(selectedRowID))
                {
                    MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ma_ID.Text = string.Empty;
                    ma_nama.Text = string.Empty;
                    ma_tanggal.Value = DateTime.Now;
                    ma_Stime.Value = DateTime.Now;
                    ma_Ntime.Value = DateTime.Now;
                    ma_lokasi.Text = string.Empty;
                    ma_deskripsi.Text = string.Empty;
                    ma_operator.SelectedIndex = -1;

                    // Refresh DataGridView setelah menghapus data
                    LoadDataAcara();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteUserData(int id)
        {
            SqlConnection conn = koneksi.GetKoneksi();

            try
            {
                conn.Open();

                // Gantilah query sesuai dengan struktur tabel di database Anda
                string query = "DELETE FROM acara WHERE ID = @ID";
                command = new SqlCommand(query, conn);

                // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                command.Parameters.AddWithValue("@ID", id);

                // Eksekusi perintah SQL untuk menghapus data
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (ma_tabel.SelectedRows.Count > 0)
            {
                // Ambil ID atau kunci unik dari baris yang dipilih
                int selectedRowID = Convert.ToInt32(ma_tabel.SelectedRows[0].Cells["ID"].Value);

                // Validasi data sebelum melakukan update
                if (string.IsNullOrEmpty(ma_nama.Text) || ma_tanggal.Value == null || ma_Stime.Value == null || ma_Ntime.Value == null || string.IsNullOrEmpty(ma_lokasi.Text) || string.IsNullOrEmpty(ma_deskripsi.Text) || ma_operator.SelectedIndex == -1)
                {
                    MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = koneksi.GetKoneksi();

                try
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel di database Anda
                    string query = "UPDATE acara SET [Nama Acara] = @Nama, Tanggal = @Tanggal, [Waktu Mulai] = @WaktuMulai, [Waktu Selesai] = @WaktuSelesai, Lokasi = @Lokasi, Deskripsi = @Deskripsi, Operator = @Operator " +
                                   "WHERE ID = @ID";
                    command = new SqlCommand(query, conn);

                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@ID", selectedRowID);
                    command.Parameters.AddWithValue("@Nama", ma_nama.Text);
                    command.Parameters.AddWithValue("@Tanggal", ma_tanggal.Value.Date);
                    command.Parameters.AddWithValue("@WaktuMulai", ma_Stime.Value.TimeOfDay);
                    command.Parameters.AddWithValue("@WaktuSelesai", ma_Ntime.Value.TimeOfDay);
                    command.Parameters.AddWithValue("@Lokasi", ma_lokasi.Text);
                    command.Parameters.AddWithValue("@Deskripsi", ma_deskripsi.Text);
                    command.Parameters.AddWithValue("@Operator", ma_operator.SelectedItem.ToString());

                    // Eksekusi perintah SQL untuk melakukan update data
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Bersihkan input setelah data diperbarui
                        ma_ID.Text = string.Empty;
                        ma_nama.Text = string.Empty;
                        ma_tanggal.Value = DateTime.Now;
                        ma_Stime.Value = DateTime.Now;
                        ma_Ntime.Value = DateTime.Now;
                        ma_lokasi.Text = string.Empty;
                        ma_deskripsi.Text = string.Empty;
                        ma_operator.SelectedIndex = -1;

                        // Refresh DataGridView setelah melakukan update data
                        LoadDataAcara();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diperbarui.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Pilih baris yang ingin diperbarui.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
