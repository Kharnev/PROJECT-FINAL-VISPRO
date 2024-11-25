using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_FINAL_VISPRO
{
    public partial class FormDorm : Form
    {
        public FormDorm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDormCrystal formDormCrystal = new FormDormCrystal();
            formDormCrystal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDormJasmineI formDormJasmineI = new FormDormJasmineI();
            formDormJasmineI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDormJasmineII formDormJasmineII = new FormDormJasmineII();
            formDormJasmineII.Show();
        }

        private void btnDormGenset_Click(object sender, EventArgs e)
        {
            FormDormGenset formDormGenset = new FormDormGenset();
            formDormGenset.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDormGuest formDormGuest = new FormDormGuest();
            formDormGuest.Show();
        }

        private void btnDormEdel_Click(object sender, EventArgs e)
        {
            FormDormEdel formDormEdel = new FormDormEdel();
            formDormEdel.Show();
        }

        private void btnDormBougenville_Click(object sender, EventArgs e)
        {
            FormDormBougenville formDormBougenville = new FormDormBougenville();
            formDormBougenville.Show();
        }

        private void btnDormAnnex_Click(object sender, EventArgs e)
        {
            FormDormAnnex formDormAnnex = new FormDormAnnex();
            formDormAnnex.Show();
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
    }
}
