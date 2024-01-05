using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Attendance
{
    public partial class LaporanAdmin : UserControl
    {
        Koneksi koneksi = new Koneksi();

        private SqlDataAdapter adapter;
        private DataTable dataTable;

        private string jumlahPesertaText;
        private string jumlahPesertaHadirText;

        public LaporanAdmin()
        {
            InitializeComponent();

            LoadEventNames();
            LoadAttendanceData();
        }

        private void LoadEventNames()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Gantilah query sesuai dengan struktur tabel dan kolom di database Anda
                    string query = "SELECT [Nama Acara] FROM acara";
                    adapter = new SqlDataAdapter(query, conn);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bersihkan item yang mungkin sudah ada di ComboBox
                    la_listAcara.Items.Clear();

                    // Tambahkan nama acara ke dalam ComboBox
                    foreach (DataRow row in dataTable.Rows)
                    {
                        la_listAcara.Items.Add(row["Nama Acara"].ToString());
                    }

                    // Pilih item pertama jika ada
                    if (la_listAcara.Items.Count > 0)
                    {
                        la_listAcara.SelectedIndex = 0;
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
                    string selectedEvent = la_listAcara.SelectedItem.ToString();
                    string query = "SELECT ID, Email, Status, CONVERT(varchar(5), Waktu, 108) AS Waktu FROM daftar_hadir " +
                                   "WHERE AcaraID = (SELECT ID FROM acara WHERE [Nama Acara] = @SelectedEvent)";
                    adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SelectedEvent", selectedEvent);

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind data ke DataGridView
                    la_tabel.DataSource = dataTable;

                    // Hitung jumlah peserta total
                    int jumlahPeserta = dataTable.Rows.Count;

                    // Hitung jumlah peserta dengan status hadir
                    int jumlahPesertaHadir = dataTable.AsEnumerable().Count(row => row.Field<string>("Status") == "Hadir");

                    // Tampilkan jumlah peserta di label
                    la_sumPeserta.Text = "Jumlah Peserta: " + jumlahPeserta.ToString();
                    la_sumHadir.Text = "Total Hadir: " + jumlahPesertaHadir.ToString();

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

        private void la_listAcara_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
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
    }
}
