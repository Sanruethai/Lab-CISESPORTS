using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_E_sport
{
    public partial class FromAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        public FromAllPlayer()
        {
            InitializeComponent();


            dataGridView1.DataSource = listPlayer;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FromInfo frominfo = new FromInfo();
            frominfo.ShowDialog();

            if (frominfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer = frominfo.getPlayer();
                this.listPlayer.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                frominfo.Close();
            }


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
