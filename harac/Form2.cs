using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            Color[] renkler = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Purple };
            foreach (Color renk in renkler)
            {
                comboBox1.Items.Add(renk);
            }

            comboBox1.DrawItem += comboBox1_DrawItem;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        bool mesaj = false;
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Color renk = (Color)comboBox1.Items[e.Index];
                e.DrawBackground();
                using (SolidBrush brush = new SolidBrush(renk))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds.Left + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4);
                }
                e.Graphics.DrawString(renk.Name, comboBox1.Font, Brushes.Black, e.Bounds.Left + 25, e.Bounds.Top + 2);
            }
            
            if(mesaj == false)
            {
                MessageBox.Show("Merhaba, Sömürge'ye hoşgeldin!\nDevletini isimlendir, bayrağını seç, para birimini seç ve sömürmeye başla. \nElindeki hazine ile başla ve ilk ülkeyi işgal et\nEdindiğin ganimetle güçlen ve fetihlere devam et!", "Sömürge'ye Hoşgeldin!");
            }
            mesaj = true;
        }
        Color comborenk;
        public static string para, isim, renk;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" &&
                comboBox1.SelectedIndex >= 0 &&
                (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                
                if (radioButton1.Checked)
                {
                    para = "₺";
                }
                else if (radioButton2.Checked)
                {
                    para = "$";
                }
                else if (radioButton3.Checked)
                {
                    para = "€";
                }
                isim = textBox1.Text;
                comborenk = (Color)comboBox1.SelectedItem;
                renk = comborenk.Name;
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bütün verileri giriniz!");
            }

        }
    }
}
