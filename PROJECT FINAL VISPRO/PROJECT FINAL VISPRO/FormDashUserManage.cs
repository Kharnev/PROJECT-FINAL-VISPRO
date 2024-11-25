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
    public partial class FormDashUserManage : Form
    {
        public FormDashUserManage()
        {
            InitializeComponent();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            FormDashUserManageDataDiri1 formdashUserManageDataDiri1 = new FormDashUserManageDataDiri1();
            formdashUserManageDataDiri1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashAdmin formDashAdmin = new FormDashAdmin();
            formDashAdmin.Show();
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

        private void btnFinance_Click(object sender, EventArgs e)
        {
            FormFinance formFinance = new FormFinance();
            formFinance.Show();
        }

        private void btnDorm_Click(object sender, EventArgs e)
        {
            FormDorm formDorm = new FormDorm();
            formDorm.Show();
        }

        private void FormDashUserManage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCRMahasiswa formCRMahasiswa = new FormCRMahasiswa();
            formCRMahasiswa.Show();
        }
    }
}
