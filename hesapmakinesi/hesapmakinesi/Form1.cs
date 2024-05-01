using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            button15.Click += Button_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                switch(clickedButton.Name)
                {
                    case "button1":
                        textBox1.Text += "1";
                        break;
                    case "button2":
                        textBox1.Text += "2";
                        break;
                    case "button3":
                        textBox1.Text += "3";
                        break;
                    case "button4":
                        textBox1.Text += "4";
                        break;
                    case "button5":
                        textBox1.Text += "5";
                        break;
                    case "button6":
                        textBox1.Text += "6";
                        break;
                    case "button7":
                        textBox1.Text += "7";
                        break;
                    case "button8":
                        textBox1.Text += "8";
                        break;
                    case "button9":
                        textBox1.Text += "9";
                        break;
                    case "button15":
                        textBox1.Text += "0";
                        break;
                    default:
                        break;
                }
                    
            }
        }

        double sayi1, sayi2;
        string islem;

        private void button11_Click(object sender, EventArgs e)
        {
            //topla
            sayi1 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = "";
            islem = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //çıkart
            sayi1 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = "";
            islem = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //çarp
            sayi1 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = "";
            islem = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //böl
            sayi1 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = "";
            islem = "/";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //%
            sayi1 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = "";
            islem = "yz";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //karekök
            sayi1 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = (Math.Sqrt(sayi1)).ToString();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            //sil
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //=
            sayi2 = Convert.ToDouble(textBox1.Text.Trim());
            textBox1.Text = "";
            switch(islem)
            {
                case "+":
                    textBox1.Text = (sayi1 + sayi2).ToString();
                    sayi2 = Convert.ToDouble(textBox1.Text.Trim());
                    //textBox1.Text = "";
                    break;
                case "-":
                    textBox1.Text = (sayi1 - sayi2).ToString();
                    sayi2 = Convert.ToDouble(textBox1.Text.Trim());
                    //textBox1.Text = "";
                    break;
                case "/":
                    textBox1.Text = (sayi1 / sayi2).ToString();
                    sayi2 = Convert.ToDouble(textBox1.Text.Trim());
                    //textBox1.Text = "";
                    break;
                case "*":
                    textBox1.Text = (sayi1 * sayi2).ToString();
                    sayi2 = Convert.ToDouble(textBox1.Text.Trim());
                    //textBox1.Text = "";
                    break;
                case "yz":
                    sayi2 = Convert.ToDouble(textBox1.Text.Trim());
                    textBox1.Text = (sayi1 / 100 * sayi2).ToString();
                    
                    //textBox1.Text = "";
                    break;

                default:
                    break;
            }
            
        }      

    }
}
