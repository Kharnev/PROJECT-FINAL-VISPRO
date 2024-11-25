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
    public partial class FormCrystal1_2 : Form
    {
        public FormCrystal1_2()
        {
            InitializeComponent();
        }

        private void btnInputBooking_Click(object sender, EventArgs e)
        {
            FormResProfCrystal formResProfCrystal = new FormResProfCrystal();
            formResProfCrystal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormResProfCrystal2 formResProfCrystal2 = new FormResProfCrystal2();
            formResProfCrystal2.Show();
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
            FormDormCrystal formDormCrystal = new FormDormCrystal();
            formDormCrystal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormResProfCrystal3 formResProfCrystal3 = new FormResProfCrystal3();
            formResProfCrystal3.Show();
        }
    }
}
