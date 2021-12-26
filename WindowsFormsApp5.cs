using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] indexNO = new string[dataTXT.Text.Length];
            int sira = 0;

            for(int x=0;x<= dataTXT.Text.Length-1;x++)
            {
               if(dataTXT.Text.Substring(x,1)=="a")

                {
                    indexNO[sira] = x.ToString();
                    sira++;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] isim = new int[30];

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sayi1.Text = sayi1.Text.Replace(".", ",");
            sayi2.Text = sayi2.Text.Replace(".", ",");
            double s1 = Convert.ToDouble(sayi1.Text);
            double s2 = Convert.ToDouble(sayi2.Text);
            double deger = s1 / s2;
            sonuc.Text=deger.ToString();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if ((eposta.Text != "")&&(sifre.Text!=""))
            {

            }
            else
            {
                MessageBox.Show("eposta ve şifrenizi giriniz");
            }
           
        }
        
            
    }
}
