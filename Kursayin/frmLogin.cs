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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Enter_MainForm()
        {
            string[] lines = File.ReadAllLines(
                Path.Combine(Environment.CurrentDirectory, "user.txt"));

            string username = lines[0];
            string password = lines[1];

            if (txtlogin.Text == username && txtpassword.Text == password)
            {
                frmMain fm = new frmMain();
                this.Hide();
                fm.Show();
            }
            else
            {
                chShowPass.Checked = false;
                txtpassword.Clear();
                txtlogin.Clear();
                MessageBox.Show("Wrong username or password!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }
       
        

        private void chShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPass.Checked == true)
                txtpassword.PasswordChar = '\0';
            else
                txtpassword.PasswordChar = '*';
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Enter_MainForm();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Enter_MainForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
