using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20215802031odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            double fiyat;
            DateTime tarih;

            tarih = Form1.tarih;
            fiyat = Form1.fiyat;

            for ( int i = 1; i <= Form1.taksit; i++ )
            {
                tarih = tarih.AddMonths(1);
                switch (tarih.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        tarih = tarih.AddDays(2);
                        break;

                    case DayOfWeek.Sunday:
                        tarih = tarih.AddDays(1);
                        break;
                }

                listBox1.Items.Add(tarih.ToLongDateString() + "\t" + fiyat.ToString("C2"));
            }

            

        }
    }
}
