using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PROJECT_FINAL_VISPRO
{
    public partial class FormDashUserManageDataDiri1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        // Tambahkan data fakultas dan program studi
        private Dictionary<string, List<string>> dataFakultas = new Dictionary<string, List<string>>()
        {
            { "FAKULTAS FILSAFAT", new List<string> { "PRODI FILSAFAT AGAMA" } },
            { "FAKULTAS KEGURUAN DAN ILMU PENDIDIKAN", new List<string> { "PRODI PENDIDIKAN KEAGAMAAN KRISTEN", "PRODI PENDIDIKAN BAHASA INGGRIS", "PRODI PENDIDIKAN EKONOMI" } },
            { "FAKULTAS EKONOMI DAN BISNIS", new List<string> { "PRODI INTERNATIONAL BUSINESS PROG.", "PRODI AKUTANSI", "PRODI MANAJEMEN", "PROGRAM DIPLLOMA SEKRETARI" } },
            { "FAKULTAS PERTANIAN", new List<string> { "PRODI AGROTEKNOLOGI" } },
            { "FAKULTAS ILMU KOMPUTER", new List<string> { "PRODI INFORMATIKA", "PRODI SISTEM INFORMASI", "PRODI TEKNOLOGI INFORMASI" } },
            { "FAKULTAS KEPERAWATAN", new List<string> { "PRODI ILMU KEPERAWATAN" } },
            { "FAKULTAS TEKNIK", new List<string> { "PRODI TEKNIK ARSITEK" } }
        };

        public FormDashUserManageDataDiri1()
        {
            alamat = "server=localhost; database=db_booking_asrama; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void FormDashUserManageDataDiri1_Load(object sender, EventArgs e)
        {
            // Atur format tanggal di DateTimePicker
            dtTanggal.Format = DateTimePickerFormat.Custom;
            dtTanggal.CustomFormat = "yyyy/MM/dd";

            // Isi ComboBox Fakultas
            cmbFakultas.DataSource = dataFakultas.Keys.ToList();
            cmbFakultas.SelectedIndex = -1; // Tidak ada yang dipilih di awal
        }

        private void cmbFakultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil nama fakultas yang dipilih
            string selectedFakultas = cmbFakultas.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedFakultas) && dataFakultas.ContainsKey(selectedFakultas))
            {
                // Ambil program studi berdasarkan fakultas yang dipilih
                List<string> programStudi = dataFakultas[selectedFakultas];
                programStudi.Sort(); // Urutkan alfabetis

                // Isi ComboBox Jurusan
                cmbJurusan.DataSource = programStudi;
                cmbJurusan.SelectedIndex = -1; // Reset pilihan awal
            }
            else
            {
                // Jika tidak ada fakultas yang dipilih, kosongkan ComboBox Jurusan
                cmbJurusan.DataSource = null;
            }
        }

        private void btnInputDataDiri_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input pengguna
                if (txtNamaSiswa.Text != "" && txtNoregis.Text != "" && txtNIM.Text != "" && cmbFakultas.Text != "" && cmbJurusan.Text != "" && cmbAgama.Text != "" && cmbGender.Text != "" && txtTempat.Text != "" && dtTanggal.Text != "" && txtTelp.Text != "" && txtEmailSiswa.Text != "")
                {
                    string formattedDate = dtTanggal.Value.ToString("yyyy-MM-dd");

                    // Gunakan parameterized query untuk mencegah SQL Injection
                    query = "INSERT INTO tbl_mahasiswa (ID_mahasiswa, nama, no_regis, nim, fakultas, jurusan, agama, jenis_kelamin, tempat_lahir, tanggal_lahir, no_telp, email) " +
                            "VALUES (@id, @nama, @no_regis, @nim, @fakultas, @jurusan, @agama, @jenis_kelamin, @tempat_lahir, @tanggal_lahir, @no_telp, @email);";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);

                    // Tambahkan parameter ke query
                    perintah.Parameters.AddWithValue("@id", txtIDSiswa.Text);
                    perintah.Parameters.AddWithValue("@nama", txtNamaSiswa.Text);
                    perintah.Parameters.AddWithValue("@no_regis", txtNoregis.Text);
                    perintah.Parameters.AddWithValue("@nim", txtNIM.Text);
                    perintah.Parameters.AddWithValue("@fakultas", cmbFakultas.Text);
                    perintah.Parameters.AddWithValue("@jurusan", cmbJurusan.Text);
                    perintah.Parameters.AddWithValue("@agama", cmbAgama.Text);
                    perintah.Parameters.AddWithValue("@jenis_kelamin", cmbGender.Text);
                    perintah.Parameters.AddWithValue("@tempat_lahir", txtTempat.Text);
                    perintah.Parameters.AddWithValue("@tanggal_lahir", formattedDate);
                    perintah.Parameters.AddWithValue("@no_telp", txtTelp.Text);
                    perintah.Parameters.AddWithValue("@email", txtEmailSiswa.Text);

                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Sukses ...");
                        FormDashUserManage formDashUserManage = new FormDashUserManage();
                        formDashUserManage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Gagal Insert Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNamaSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtIDSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            FormDashAdmin formDashAdmin = new FormDashAdmin();
            formDashAdmin.Show();
        }

        private void btnResProf_Click(object sender, EventArgs e)
        {
            FormResProf formResProf = new FormResProf();
            formResProf.Show();
        }

        private void btnDorm_Click(object sender, EventArgs e)
        {
            FormDorm formDorm = new FormDorm();
            formDorm.Show();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            FormFinance formFinance = new FormFinance();
            formFinance.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashUserManage formDashUserManage = new FormDashUserManage();
            formDashUserManage.Show();
        }

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
