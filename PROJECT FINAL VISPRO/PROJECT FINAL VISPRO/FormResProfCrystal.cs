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
    public partial class FormResProfCrystal : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormResProfCrystal()
        {
            alamat = "server=localhost; database=db_booking_asrama; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormResProf formResProf = new FormResProf();
            formResProf.Show();
        }

        private void txtNoKamarBoo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCrystal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResNamaCrystal.Text != "")
                {
                    query = string.Format("select * from tbl_crystal where username = '{0}', '{1}'", txtResIDAnakCrystal.Text, txtResNamaCrystal.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[1].Rows)
                        {
                            txtResIDAnakCrystal.Text = kolom["id_pengguna"].ToString();
                            txtResNamaCrystal.Text = kolom["nama_mahasiswa"].ToString();

                        }
                        txtResNamaCrystal.Enabled = false;
                        dgvResCrystal.DataSource = ds.Tables[0];
                        btnResSearchCrystal.Enabled = false;
                        btnResClearCrystal.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnResClearCrystal_Click(object sender, EventArgs e)
        {
            FormResProfCrystal formResProfCrystal = new FormResProfCrystal();
            formResProfCrystal.Show();
        }

        private void picResProfCrystal_Click(object sender, EventArgs e)
        {

        }
    }
}
