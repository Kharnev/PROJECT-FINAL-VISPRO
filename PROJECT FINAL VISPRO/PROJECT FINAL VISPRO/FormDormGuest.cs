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
    public partial class FormDormGuest : Form
    {
        public FormDormGuest()
        {
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
            FormDorm formDorm = new FormDorm();
            formDorm.Show();
        }

        private void btnInputBooking_Click(object sender, EventArgs e)
        {
            FormResProfGuest formResProfGuest = new FormResProfGuest();
            formResProfGuest.Show();
        }
    }
}
