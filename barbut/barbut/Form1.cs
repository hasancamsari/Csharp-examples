using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bakiye = 10000;
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = bakiye.ToString("C2");
            pictureBox1.Image = Image.FromFile("0.png");
            pictureBox2.Image = Image.FromFile("0.png");
            pictureBox3.Image = Image.FromFile("0.png");
            pictureBox4.Image = Image.FromFile("0.png");
        }
        
        int zar1, zar2, zar3, zar4;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int pc = 0, player = 0, zar = 0, bahis=0;
            pc = 0;
            player = 0;
            zar1 = 0; zar2 = 0; zar3 = 0; zar4 = 0;
            if (textBox1.Text != "")
            {
                bahis = Convert.ToInt32(textBox1.Text.Trim());
            }

            if (textBox1.Text != "" && bakiye > 0 && bahis <= bakiye)
            {
                bakiye = bakiye - Convert.ToInt32(textBox1.Text.Trim());
                
                textBox1.Text = "";
                label4.Text = bakiye.ToString("C2");

                Random rnd = new Random();
                for (int i = 1; i < 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            zar = rnd.Next(1, 7);
                            pictureBox1.Image = Image.FromFile(zar + ".png");
                            pc += zar;
                            zar1 = zar;
                            break;
                        case 2:
                            zar = rnd.Next(1, 7);
                            pictureBox2.Image = Image.FromFile(zar + ".png");
                            pc += zar;
                            zar2 = zar;
                            break;
                        case 3:
                            zar = rnd.Next(1, 7);
                            pictureBox3.Image = Image.FromFile(zar + ".png");
                            player += zar;
                            zar3 = zar;
                            break;
                        case 4:
                            zar = rnd.Next(1, 7);
                            pictureBox4.Image = Image.FromFile(zar + ".png");
                            player += zar;
                            zar4 = zar;
                            break;
                        default:
                            break;
                    }
                }
       
                if(zar1 == 3 && zar2 == 3)
                {
                    bakiye = 0;
                    MessageBox.Show("Barbut! Kazanan: PC");
                    label4.Text = bakiye.ToString("C2");
                }
                else if (zar1 == 5 && zar2 == 5)
                {
                    bakiye = 0;
                    MessageBox.Show("Barbut! Kazanan: PC");
                    label4.Text = bakiye.ToString("C2");
                }
                else if (zar1 == 6 && zar2 == 6)
                {
                    bakiye = 0;
                    MessageBox.Show("Barbut! Kazanan: PC");
                    label4.Text = bakiye.ToString("C2");
                }
                else if (zar3 == 1 && zar4 == 1)
                {
                    bakiye = ((bakiye + bahis) * 2);
                    MessageBox.Show("Barbut! Kazanan: Player");
                    label4.Text = bakiye.ToString("C2");
                }
                else if (zar3 == 2 && zar4 == 2)
                {
                    bakiye = ((bakiye + bahis) * 2);
                    MessageBox.Show("Barbut! Kazanan: Player");
                    label4.Text = bakiye.ToString("C2");
                }
                else if (zar3 == 4 && zar4 == 4)
                {
                    bakiye = ((bakiye + bahis) * 2);
                    MessageBox.Show("Barbut! Kazanan: Player");
                    label4.Text = bakiye.ToString("C2");
                }
                else { 

                if(pc > player)
                {
                    MessageBox.Show("Kazanan: PC");
                    if (bakiye <= 0)
                    {
                        DialogResult sor = MessageBox.Show("Yeniden başlamak ister misin?", "Bakiye bitti!", MessageBoxButtons.YesNo);
                        if (sor == System.Windows.Forms.DialogResult.Yes)
                        {
                            bakiye = 10000;
                            label4.Text = bakiye.ToString("C");
                            pictureBox1.Image = Image.FromFile("0.png");
                            pictureBox2.Image = Image.FromFile("0.png");
                            pictureBox3.Image = Image.FromFile("0.png");
                            pictureBox4.Image = Image.FromFile("0.png");
                        }
                        else
                            Close();
                    }
                }else if(player > pc)
                {
                    MessageBox.Show("Kazanan: Player");
                    bakiye = (bakiye + (bahis * 2));
                    label4.Text = bakiye.ToString("C2");
                }
                else if (pc == player)
                {
                    MessageBox.Show("Berabere!");
                    bakiye = ( bakiye + bahis );
                    label4.Text = bakiye.ToString("C2");
                }
              }
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Bahis girin!");
            }else if(bahis > bakiye)
            {
                MessageBox.Show("Yetersiz Bakiye!");
            }
            pictureBox1.Image = Image.FromFile("0.png");
            pictureBox2.Image = Image.FromFile("0.png");
            pictureBox3.Image = Image.FromFile("0.png");
            pictureBox4.Image = Image.FromFile("0.png");
            
        }
    }
}
