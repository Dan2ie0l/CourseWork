using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursayin
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            string lines = File.ReadAllText(
             Path.Combine(Environment.CurrentDirectory, "help.txt"));
            pictureBox1.Image = (Image)new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawString(lines, new Font("Microsoft Sans Serif", 10), new SolidBrush(Color.Black), new Point(10, 10));
            g.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
