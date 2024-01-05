using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Meeting_Attendance
{
    public partial class Form_Login : Form
    {
        Koneksi koneksi = new Koneksi();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetKoneksi();

            conn.Open();
            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Isi Email dan Password terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT email, password, jabatan FROM users WHERE email = '" + email.Text + "' AND password = '" + password.Text + "' ", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        // Set email pengguna yang sudah login ke UserSession
                        UserSession.SetLoggedInUserEmail(dr["email"].ToString());

                        if (dr["jabatan"].ToString() == "Admin")
                        {
                            this.Hide();
                            Admin admin = new Admin();
                            admin.Show();
                        }
                        else if (dr["jabatan"].ToString() == "Operator")
                        {
                            this.Hide();
                            Operator @operator = new Operator();
                            @operator.Show();
                        }
                        else if (dr["jabatan"].ToString() == "Peserta")
                        {
                            this.Hide();
                            Peserta peserta = new Peserta();
                            peserta.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email atau Password salah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void show_pw_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = show_pw.Checked ? '\0' : '*';
        }
    }
}
