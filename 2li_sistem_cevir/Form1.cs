using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2li_sistem_cevir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string metin;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            double sayi;
            sayi = Convert.ToDouble(textBox1.Text);
            int i = 1;
            int index = 0;
            int binyaz = 0;
            List<int> dizi = new List<int>();

            while (i <= sayi)
            {
                if (sayi % 2 == 0)
                {
                    binyaz = 0;
                    sayi = Math.Floor((sayi / 2));
                    index ++;
                    dizi.Add(binyaz);
                }
                else
                {
                    sayi = Math.Floor((sayi / 2));
                    binyaz = 1;
                    index ++;
                    dizi.Add(binyaz);
                }
            }

            dizi.Reverse();
            foreach (int chr in dizi)
            {
                metin += chr.ToString();
                richTextBox1.AppendText(chr.ToString());
            }

        }
    }
}
