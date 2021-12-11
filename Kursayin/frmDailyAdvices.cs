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
    public partial class frmDailyAdvices : Form
    {
        string[] lines = File.ReadAllLines(
              Path.Combine(Environment.CurrentDirectory, "advice.txt"));
        int i = 2;
        public frmDailyAdvices()
        {
            InitializeComponent();
        }

        private void frmDailyAdvices_Load(object sender, EventArgs e)
        {
            string advice = lines[0] + lines[1];
            lblAdvice.Text = advice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string advice = "";
            while (i <= lines.Count() - 1)
            {
                advice = lines[i] + lines[i + 1];
                i += 2;
                break;
            }
            if (i == 12)
                i = 0;

            lblAdvice.Text = advice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
