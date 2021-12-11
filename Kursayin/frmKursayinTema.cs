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
    public partial class frmKursayinTema : Form
    {
        public frmKursayinTema()
        {
            InitializeComponent();
        }

      

        private int Max( int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        private void btnGtnel_Click(object sender, EventArgs e)
        {
         
            int n = int.Parse(txtN.Text);
            Random rnd = new Random();
            int l = 0;
            int[] arr = new int[n];
          
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-50, 51);
                lbVektor1.Items.Add(arr[i].ToString());
                if (arr[i] > 0)
                {
                    l++;
                }
            }
            
            int[] arr2 = new int[n];
            int max = Max(arr);
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    arr2[j] = arr[i] * max;
                    lbVektor2.Items.Add(arr2[j].ToString());
                    j++;
                }
         
            }
        }
    }
}
