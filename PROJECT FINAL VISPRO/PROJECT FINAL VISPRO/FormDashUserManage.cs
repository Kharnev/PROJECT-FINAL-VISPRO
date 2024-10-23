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
            FormDashUserManageDataDiri formDashUserManageDataDiri = new FormDashUserManageDataDiri();
            formDashUserManageDataDiri.Show();
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
    }
}
