using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursayin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            frmKursayinTema fkt = new frmKursayinTema();
            fkt.Show();
            fkt.MdiParent = this;
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            frmDailyAdvices dailyAdvices = new frmDailyAdvices();
            dailyAdvices.Show();
            dailyAdvices.MdiParent = this;
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            help.MdiParent = this;
        }

        private void հորիզոնականToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void հերթականությամբToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        private void ՈւղղահայացToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void minimizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.WindowState = FormWindowState.Minimized;
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
        }


        private void toolStripDropDownButton6_Click(object sender, EventArgs e)
        {
            frmAuthor author = new frmAuthor();
            author.Show();
            author.MdiParent = this;
        }

        private void toolStripDropDownButton7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Attention Please", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Exit();
        }
    }
}
