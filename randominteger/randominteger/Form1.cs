using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randominteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
        }

        private void zarat_Click(object sender, EventArgs e)
        {
            Random zar1 = new Random();
            int number1 = zar1.Next(7);
            int number2 = zar1.Next(7);

            
            switch (number1)
            {
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 2:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 3:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 4:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 5:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 6:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                default:
                    break;
            }

            switch (number2)
            {
                case 1:
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible  = false;
                    pictureBox8.Visible  = false;
                    pictureBox7.Visible  = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 2:
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible  = false;
                    pictureBox8.Visible  = false;
                    pictureBox7.Visible  = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 3:
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = true;
                    pictureBox9.Visible  = false;
                    pictureBox8.Visible  = false;
                    pictureBox7.Visible  = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 4:
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible  = true;
                    pictureBox8.Visible  = false;
                    pictureBox7.Visible  = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 5:
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible  = false;
                    pictureBox8.Visible  = true;
                    pictureBox7.Visible  = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                case 6:
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible  = false;
                    pictureBox8.Visible  = false;
                    pictureBox7.Visible  = true;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    break;
                default:
                    break;
            }

        }

    }
}
