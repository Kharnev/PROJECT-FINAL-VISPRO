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
    public partial class FormDashUserManageBooking : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormDashUserManageBooking()
        {
            alamat = "server=localhost; database=db_booking_asrama; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnInputDataDiri_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamaSiswaAsrama.Text != "" && cmbGedungBoo.Text != "" && txtNoKamarBoo.Text != "" )
                {

                    query = string.Format("insert into tbl_anak_asrama values ('{0}','{1}','{2}','{3}');", txtIDAnakAsrama.Text, txtNamaSiswaAsrama.Text, cmbGedungBoo.Text, txtNoKamarBoo.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        FormDashUserManage formDashUserManage = new FormDashUserManage();
                        formDashUserManage.Show();
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

        private void picBooking_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
