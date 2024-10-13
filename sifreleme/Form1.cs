using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sezar şifrelemeye hoşgeldin!");
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.Enabled = false;
            button1.Enabled = false;
            richTextBox1.ReadOnly = true;
        }

        bool anahtar;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                comboBox1.Enabled = true;
                anahtar = true;
                button1.Enabled = true;
                richTextBox1.Clear();
                richTextBox1.ReadOnly = false;
                richTextBox2.Clear();
            }
            else
                button1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                comboBox1.Enabled = false;
                anahtar = false;
                button1.Enabled = true;
                richTextBox1.Clear();
                richTextBox1.ReadOnly = false;
                richTextBox2.Clear();
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (anahtar == true)
            {
                int kaydirma = Convert.ToInt32(comboBox1.SelectedItem);
                comboBox1.SelectedIndex = -1;
                string giris = richTextBox1.Text;
                StringBuilder cikis = new StringBuilder();

                foreach (char c in giris)
                {
                    char newChar = (char)(c + kaydirma);
                    cikis.Append(newChar);
                }

                richTextBox2.Text = cikis.ToString();
            }
            else
            {
                string giris = richTextBox1.Text;
                StringBuilder cikis = new StringBuilder();

                for (int i = 1; i <= 20; i++)
                {
                    cikis.Append(i + " --> ");
                    foreach (char c in giris)
                    {
                        char newChar = (char)(c - i);
                        cikis.Append(newChar);
                    }

                    richTextBox2.Text = cikis.ToString();
                    cikis.Append(" <--");
                    cikis.Append(Environment.NewLine);
                    cikis.Append(Environment.NewLine);
                }
                
            }
        }
    }
}
