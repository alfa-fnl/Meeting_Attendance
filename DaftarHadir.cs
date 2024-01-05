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
using System.IO;

namespace Meeting_Attendance
{
    public partial class DaftarHadir : UserControl
    {
        Koneksi koneksi = new Koneksi();

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlCommand command;

        private string jumlahPesertaText;
        private string jumlahPesertaHadirText;

        public DaftarHadir()
        {
            InitializeComponent();

            LoadEventNames();
            LoadMemberEmails();
        }

        private void LoadEventNames()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                    string query = "SELECT [Nama Acara] FROM acara WHERE Operator = @OperatorEmail";
                    adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@OperatorEmail", UserSession.LoggedInUserEmail);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bersihkan item yang mungkin sudah ada di ComboBox
                    dh_listAcara.Items.Clear();

                    // Tambahkan nama acara ke dalam ComboBox
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dh_listAcara.Items.Add(row["Nama Acara"].ToString());
                    }

                    // Pilih item pertama jika ada
                    if (dh_listAcara.Items.Count > 0)
                    {
                        dh_listAcara.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadMemberEmails()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                    string query = "SELECT Email FROM users WHERE Jabatan = 'Peserta'";
                    adapter = new SqlDataAdapter(query, conn);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bersihkan item yang mungkin sudah ada di ComboBox
                    dh_email.Items.Clear();

                    // Tambahkan nama acara ke dalam ComboBox
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dh_email.Items.Add(row["Email"].ToString());
                    }

                    // Pilih item pertama jika ada
                    if (dh_email.Items.Count > 0)
                    {
                        dh_email.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadAttendanceData()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                    string selectedEvent = dh_listAcara.SelectedItem.ToString();
                    string query = "SELECT ID, Email, Status, CONVERT(varchar(5), Waktu, 108) AS Waktu FROM daftar_hadir " +
                                   "WHERE AcaraID = (SELECT ID FROM acara WHERE [Nama Acara] = @SelectedEvent)";
                    adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SelectedEvent", selectedEvent);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind data ke DataGridView
                    dh_tabel.DataSource = dataTable;

                    // Hitung jumlah peserta total
                    int jumlahPeserta = dataTable.Rows.Count;

                    // Hitung jumlah peserta dengan status hadir
                    int jumlahPesertaHadir = dataTable.AsEnumerable().Count(row => row.Field<string>("Status") == "Hadir");

                    // Tampilkan jumlah peserta di label
                    dh_sumPeserta.Text = "Jumlah Peserta: " + jumlahPeserta.ToString();
                    dh_sumHadir.Text = "Total Hadir: " + jumlahPesertaHadir.ToString();

                    // Tampilkan jumlah peserta di ekspor
                    jumlahPesertaText = "Jumlah Peserta: " + jumlahPeserta.ToString();
                    jumlahPesertaHadirText = "Total Hadir: " + jumlahPesertaHadir.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dh_listAcara_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (dh_tabel.SelectedRows.Count > 0)
            {
                // Ambil ID atau kunci unik dari baris yang dipilih
                int selectedRowID = Convert.ToInt32(dh_tabel.SelectedRows[0].Cells["ID"].Value);

                // Ambil nilai dari TextBox dan ComboBox
                string email = dh_email.SelectedItem?.ToString();
                string status = dh_status.SelectedItem?.ToString();

                // Update data ke database
                if (UpdateAttendanceData(selectedRowID, email, status))
                {
                    MessageBox.Show("Data berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dh_ID.Text = string.Empty;
                    dh_email.SelectedIndex = -1;
                    dh_status.SelectedIndex = -1;

                    // Refresh DataGridView setelah mengupdate data
                    LoadAttendanceData();
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateAttendanceData(int id, string email, string status)
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel di database Anda
                    string query = "UPDATE daftar_hadir SET Email = @Email, Status = @Status WHERE ID = @ID";
                    command = new SqlCommand(query, conn);

                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ID", id);

                    // Eksekusi perintah SQL untuk mengupdate data
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            // Bersihkan nilai di TextBox dan ComboBox
            dh_ID.Text = string.Empty;
            dh_email.SelectedIndex = -1;
            dh_status.SelectedIndex = -1;
        }

        private void btn_eksport_Click(object sender, EventArgs e)
        {
            try
            {
                // Menampilkan dialog penyimpanan file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files|*.csv";
                saveFileDialog.Title = "Export to CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Panggil fungsi ekspor dengan nama file yang dipilih oleh pengguna
                    ExportToCSV(dataTable, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCSV(DataTable dataTable, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Tulis data dari label
                    writer.WriteLine(jumlahPesertaText);
                    writer.WriteLine(jumlahPesertaHadirText);
                    writer.WriteLine();

                    // Tulis header kolom
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        // Menambahkan karakter kutip pada setiap nama kolom
                        writer.Write($"\"{column.ColumnName}\";");
                    }
                    writer.WriteLine();

                    // Tulis data
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            // Menambahkan karakter kutip pada setiap nilai dan menggunakan titik koma sebagai pemisah
                            writer.Write($"\"{item.ToString()}\";");
                        }
                        writer.WriteLine();
                    }

                    MessageBox.Show("Data berhasil diekspor ke file CSV.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dh_tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dh_tabel.Rows[e.RowIndex];

                // Tampilkan data di TextBox dan ComboBox
                string ID = row.Cells["ID"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                // Menetapkan nilai ke TextBox dan ComboBox
                dh_ID.Text = ID;
                dh_email.Text = email;
                dh_status.SelectedItem = status;
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari ComboBox yang dipilih
                string selectedEvent = dh_listAcara.SelectedItem.ToString();
                string selectedEmail = dh_email.SelectedItem.ToString();

                // Ambil ID Acara berdasarkan Nama Acara
                int acaraID = GetAcaraID(selectedEvent);

                // Ambil waktu mulai acara berdasarkan ID Acara
                DateTime waktuMulai = GetWaktuMulai(acaraID);

                // Set status default menjadi "Tanpa Keterangan"
                string status = "Tanpa Keterangan";

                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel di database Anda
                    string query = "INSERT INTO daftar_hadir (AcaraID, Email, Status, Waktu) " +
                                   "VALUES (@AcaraID, @Email, @Status, @Waktu)";
                    command = new SqlCommand(query, conn);

                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@AcaraID", acaraID);
                    command.Parameters.AddWithValue("@Email", selectedEmail);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Waktu", waktuMulai);

                    // Eksekusi perintah SQL untuk menambahkan data baru
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh DataGridView setelah menambahkan data
                        LoadAttendanceData();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal ditambahkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetAcaraID(string namaAcara)
        {
            // Mengambil ID Acara berdasarkan Nama Acara
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "SELECT ID FROM acara WHERE [Nama Acara] = @NamaAcara";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@NamaAcara", namaAcara);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Jika terjadi kesalahan, kembalikan nilai -1
        }

        private DateTime GetWaktuMulai(int acaraID)
        {
            // Mengambil waktu mulai acara berdasarkan ID Acara
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "SELECT [Waktu Mulai] FROM acara WHERE ID = @AcaraID";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@AcaraID", acaraID);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        if (result is TimeSpan)
                        {
                            // Lakukan konversi jika hasilnya berupa TimeSpan
                            TimeSpan timeSpan = (TimeSpan)result;
                            DateTime baseDate = DateTime.MinValue; // Tentukan tanggal dasar, misalnya 1 Januari 0001
                            return baseDate.Add(timeSpan);
                        }
                        else if (result is DateTime)
                        {
                            // Jika hasilnya sudah langsung DateTime, kembalikan nilainya
                            return (DateTime)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return DateTime.MinValue; // Jika terjadi kesalahan, kembalikan nilai DateTime.MinValue
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan ada baris yang dipilih
                if (dh_tabel.SelectedRows.Count > 0)
                {
                    // Konfirmasi pengguna sebelum menghapus
                    DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Ambil ID atau kunci unik dari baris yang dipilih
                        int selectedRowID = Convert.ToInt32(dh_tabel.SelectedRows[0].Cells["ID"].Value);

                        // Hapus data dari database
                        if (DeleteAttendanceData(selectedRowID))
                        {
                            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh DataGridView setelah menghapus data
                            LoadAttendanceData();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih baris yang ingin dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteAttendanceData(int id)
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel di database Anda
                    string query = "DELETE FROM daftar_hadir WHERE ID = @ID";
                    command = new SqlCommand(query, conn);

                    // Ganti parameter dengan nama parameter yang sesuai dengan struktur tabel di database Anda
                    command.Parameters.AddWithValue("@ID", id);

                    // Eksekusi perintah SQL untuk menghapus data
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
