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
    public partial class frmGovazd : Form
    {
        public static frmGovazd  fg = new frmGovazd();
        public string NameS = "Հարությունյան Դանիել Սևակի";
        public string TemayiAnvanum = "Տրված են n բնական թիվը և n տարր պարունակող X վեկտոր:\n" +
                          " Կազմել այնպիսի նոր Y վեկտորի ստացման և տպման ծրագիրը,\n" +
                          "որի տարրերը ստացվում են վեկտորի բոլոր դրական տարրերից, նրանց\n" +
                          "արժեքները մեծացնելով այդ նույն վեկտորից մեծագույն տարրի արժեքի չափով:";

        double dir, posy, posx;
        public frmGovazd()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            posy +=18;
            pictureBox1.Left = (int)posy;
            if(posy > 500)
            {
                pictureBox1.Left = 0;
                posy = 0;
                pictureBox1.Top += 150;
            }
           
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            frmGovazd fg = new frmGovazd();
            this.Hide();
            login.Show();
            timer1.Stop();
            timer2.Stop();
        }

        private void frmGovazd_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            lblName.Text = NameS;
            lblTema.Text = TemayiAnvanum;
            string date = DateTime.UtcNow.ToString("d");
            lblAmsativ.Text = date + "թթ․";

            posx = fg.Width / 2;
            dir = 3;
            posy = 0;
        }
    }
}
