using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormDashUserManageDataDiri : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormDashUserManageDataDiri()
        {
            alamat = "server=localhost; database=db_booking_asrama; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void picDataDiri_Click(object sender, EventArgs e)
        {

        }

        private void btnInputDataDiri_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamaSiswa.Text != "" && txtNoregis.Text != "" && txtNIM.Text != "" && cmbFakultas.Text != "" && cmbJurusan.Text != "" && cmbAgama.Text != "" && cmbGender.Text != "" && txtTempat.Text != "" && dtTanggal.Text != "" && txtTelp.Text != "" && txtEmailSiswa.Text != "")
                {

                    query = string.Format("insert into tbl_mahasiswa values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}');", txtIDSiswa.Text, txtNamaSiswa.Text, txtNoregis.Text, txtNIM.Text, cmbFakultas.Text, cmbJurusan.Text, cmbAgama.Text, cmbGender.Text, txtTempat.Text, dtTanggal.Text, txtTelp.Text, txtEmailSiswa.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        FormDashUserManageBooking formDashUserManageBooking = new FormDashUserManageBooking();
                        formDashUserManageBooking.Show();
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormResProf formResProf = new FormResProf();
            formResProf.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            FormDashAdmin formDashAdmin = new FormDashAdmin();
            formDashAdmin.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashUserManage formDashUserManage = new FormDashUserManage();
            formDashUserManage.Show();
        }
    }
}
