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
    public partial class FormResProf : Form
    {
        public FormResProf()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDashAdmin formDashAdmin = new FormDashAdmin();
            formDashAdmin.Show();
        }

        private void btnResProf_Click(object sender, EventArgs e)
        {
            FormResProf formResProf = new FormResProf();
            formResProf.Show();
        }

        private void btnResCrystal_Click(object sender, EventArgs e)
        {
            FormResProfCrystal formResProfCrystal = new FormResProfCrystal();
            formResProfCrystal.Show();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            FormFinance formFinance = new FormFinance();
            formFinance.Show();
        }

        private void btnDormJasmineII_Click(object sender, EventArgs e)
        {
            FormResProfJasmineII formResProfJasmineII = new FormResProfJasmineII();
            formResProfJasmineII.Show();
        }

        private void picResProf_Click(object sender, EventArgs e)
        {

        }

        private void btnDormCrystal_Click(object sender, EventArgs e)
        {
            FormResProfCrystal123 formResProfCrystal12 = new FormResProfCrystal123();
            formResProfCrystal12.Show();
        }

        private void btnDorm_Click(object sender, EventArgs e)
        {
            FormDorm formDorm = new FormDorm();
            formDorm.Show();
        }

        private void btnDormAnnex_Click(object sender, EventArgs e)
        {
            FormResProfAnnex formResProfAnnex = new FormResProfAnnex();
            formResProfAnnex.Show();
        }

        private void btnDormBougenville_Click(object sender, EventArgs e)
        {
            FormResProfBougenville formResProfBougenville = new FormResProfBougenville();
            formResProfBougenville.Show();
        }

        private void btnDormJasmineI_Click(object sender, EventArgs e)
        {
            FormResProfJasmineI formResProfJasmineI = new FormResProfJasmineI();
            formResProfJasmineI.Show();
        }

        private void btnDormGenset_Click(object sender, EventArgs e)
        {
            FormResProfGenset formResProfGenset = new FormResProfGenset();
            formResProfGenset.Show();
        }

        private void btnDormGuest_Click(object sender, EventArgs e)
        {
            FormResProfGuest formResProfGuest = new FormResProfGuest();
            formResProfGuest.Show();
        }

        private void btnDormEdel_Click(object sender, EventArgs e)
        {
            FormResProfEdel formResProfEdel = new FormResProfEdel();
            formResProfEdel.Show();
        }
    }
}
