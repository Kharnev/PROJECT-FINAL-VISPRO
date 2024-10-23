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
    public partial class FormDashAdmin : Form
    {
        public FormDashAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            FormDashUserManage formDashUserManage = new FormDashUserManage();
            formDashUserManage.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {

        }

        private void btnResProf_Click(object sender, EventArgs e)
        {
            FormResProf formResProf = new FormResProf();
            formResProf.Show();
        }
    }
}
