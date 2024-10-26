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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toyota Corolla");
            comboBox1.Items.Add("Ford Mustang GT");
            comboBox1.Items.Add("BMW 320i");
            comboBox1.Items.Add("Mercedes-Benz C300");
            comboBox1.Items.Add("Honda Civic EX");
            comboBox1.Items.Add("Volkswagen Golf GTI");
            comboBox1.Items.Add("Audi A4 Premium");
            comboBox1.Items.Add("Nissan Qashqai Tekna");
            comboBox1.Items.Add("Hyundai Tucson Ultimate");
            comboBox1.Items.Add("Kia Sportage GT-Line");
            comboBox2.SelectedIndex = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    comboBox2.Items.Add(i.ToString());
            //}
        }

        public static string ad, urun;
        public static int adet;
        public static double fiyat, ucret, taksit;
        public static DateTime tarih;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { taksit = 2; }
            if (radioButton2.Checked) { taksit = 3; }
            if (radioButton3.Checked) { taksit = 4; }
            if (radioButton4.Checked) { taksit = 5; }
            if (radioButton5.Checked) { taksit = 6; }

            if (textBox1.Text != "" && comboBox1.SelectedIndex > -1 && taksit > 1)
            {
                ad = textBox1.Text;
                urun = comboBox1.SelectedItem.ToString();
                adet = Convert.ToInt32(comboBox2.SelectedItem);
                ucret = Convert.ToInt32(textBox2.Text);
    
                ucret += (ucret * taksit) / 100;
    
                fiyat = ucret / taksit;
                fiyat = Math.Round(fiyat,2);
    
                tarih = dateTimePicker1.Value;
    
                DialogResult sor = MessageBox.Show("Sayın "+ad+" "+adet.ToString()+" adet "+urun+" aracınız için "+ucret.ToString("C2")+" tutarındaki borç "+taksit.ToString()+" ay taksit ile aylık "+fiyat.ToString("C2")+" olarak taksitlendirilecektir. Onaylıyor musunuz?","TAKSİT",MessageBoxButtons.YesNo);
    
                if(sor == System.Windows.Forms.DialogResult.Yes)
                {
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                    textBox1.Clear();
                    textBox2.Clear();
                    radioButton1.Checked = true;
                    radioButton1.Checked = false;
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = 0;
                }
    
            }
            else
                MessageBox.Show("Tüm verileri eksiksiz doldurun!");

        }
        int model;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox2.Text = (120000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 120000;
                    break;
                case 1:
                    textBox2.Text = (100000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 100000;
                    break;
                case 2:
                    textBox2.Text = (90000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 90000;
                    break;
                case 3:
                    textBox2.Text = (45000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 45000;
                    break;
                case 4:
                    textBox2.Text = (60000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 60000;
                    break;
                case 5:
                    textBox2.Text = (200000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 200000;
                    break;
                case 6:
                    textBox2.Text = (90000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 90000;
                    break;
                case 7:
                    textBox2.Text = (120000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 120000;
                    break;
                case 8:
                    textBox2.Text = (110000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 110000;
                    break;
                case 9:
                    textBox2.Text = (102000 * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    model = 102000;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    textBox2.Text = (model * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    break;
                case 1:
                    textBox2.Text = (model * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    break;
                case 2:
                    textBox2.Text = (model * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    break;
                case 3:
                    textBox2.Text = (model * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    break;
                case 4:
                    textBox2.Text = (model * Convert.ToInt32(comboBox2.SelectedItem)).ToString();
                    break;
            }
        }
    }
}