using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_E_sport
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void allPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromAllPlayer fromAllPlayer = new FromAllPlayer();
            fromAllPlayer.MdiParent = this;
            fromAllPlayer.Show();

        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
