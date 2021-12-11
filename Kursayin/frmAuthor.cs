using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursayin
{
    public partial class frmAuthor : Form
    {
        public int z;
        public frmAuthor()
        {
            InitializeComponent();
        }

        private async void frmAuthor_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Enabled = true;
            
            lblKurs.Text = "Կուրսային աշխատանք";

           
            lblName.Text = "Հարությունյան Դանիել Սևակի";

       
            lblQolej.Text = "Երևանի Ինֆորմատիկայի Պետական Քոլեջ\n" +
                             "14/12/2021թ";
           
            lblTema.Text = "Տրված են n բնական թիվը և n տարր պարունակող X վեկտոր:\n" +
                          " Կազմել այնպիսի նոր Y վեկտորի ստացման և տպման ծրագիրը,\n" +
                          "որի տարրերը ստացվում են վեկտորի բոլոր դրական տարրերից, նրանց\n" +
                          "արժեքները մեծացնելով այդ նույն վեկտորից մեծագույն տարրի արժեքի չափով:";

            z = 10;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 256);
            int b = rnd.Next(0, 256);
            int c = rnd.Next(0, 256);
            int d = rnd.Next(0, 256);

            lblKurs.Visible = false;
            lblKurs.ForeColor = Color.FromArgb(a, b, c, d);
            lblKurs.Visible = true;

        }
    }
}
