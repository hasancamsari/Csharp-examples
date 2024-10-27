using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rndsay;
        void kartsec()
        {
            adres = "";
            int rndharf = rnd.Next(1, 4 + 1);
            switch (rndharf)
            {
                case 1:
                    diziharf = harf[0];
                    break;
                case 2:
                    diziharf = harf[1];
                    break;
                case 3:
                    diziharf = harf[2];
                    break;
                case 4:
                    diziharf = harf[3];
                    break;
                default:
                    break;
            }

            rndsay = rnd.Next(1, 14 + 1);
            kart = "";
            if (rndsay < 14)
            {
                kart += diziharf + rndsay;
            }
            else
            {
                kartsec();
            }

            adres = "cards/" + kart + ".png";
            deneme += " " + kart;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("cards/space.png");
            pictureBox3.Image = Image.FromFile("cards/space.png");
            pictureBox4.Image = Image.FromFile("cards/space.png");
            pictureBox5.Image = Image.FromFile("cards/space.png");
            pictureBox6.Image = Image.FromFile("cards/space.png");
            pictureBox7.Image = Image.FromFile("cards/space.png");
            pictureBox8.Image = Image.FromFile("cards/space.png");
            pictureBox9.Image = Image.FromFile("cards/space.png");
            pictureBox10.Image = Image.FromFile("cards/space.png");
            pictureBox11.Image = Image.FromFile("cards/space.png");
            pictureBox12.Image = Image.FromFile("cards/space.png");
            pictureBox13.Image = Image.FromFile("cards/space.png");

            label1.Text = "Bahis: 0";
            label2.Text = "Kasa: 50000";
            button6.Enabled = false;
            button7.Enabled = false;
            label3.Text = "Puan: -";
            label4.Text = "Puan: 0";
        }
        int bakiye = 50000;
        int bahis = 0;

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (500 <= bakiye)
            {
                bahis += 500;
                bakiye -= 500;
                label1.Text = "Bahis: " + bahis.ToString();
                label2.Text = "Bakiye: " + bakiye.ToString();
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (1000 <= bakiye)
            {
                bahis += 1000;
                bakiye -= 1000;
                label1.Text = "Bahis: " + bahis.ToString();
                label2.Text = "Bakiye: " + bakiye.ToString();
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (2000 <= bakiye)
            {
                bahis += 2000;
                bakiye -= 2000;
                label1.Text = "Bahis: " + bahis.ToString();
                label2.Text = "Bakiye: " + bakiye.ToString();
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (5000 <= bakiye)
            {
                bahis += 5000;
                bakiye -= 5000;
                label1.Text = "Bahis: " + bahis.ToString();
                label2.Text = "Bakiye: " + bakiye.ToString();
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int txbox;
            int.TryParse(textBox1.Text, out txbox);
            if (bakiye < 0 || bakiye < txbox)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }else if(textBox1.Text == "")
            {
                MessageBox.Show("Bahis giriniz.");
            }else
            {
                bahis += txbox;
                bakiye -= txbox;
                label1.Text = "Bahis: " + bahis.ToString();
                label2.Text = "Bakiye: " + bakiye.ToString();
                textBox1.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int txbox;
            int.TryParse(textBox1.Text, out txbox);
            if (bahis < 0 || bahis < txbox)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Bahis giriniz.");
            }
            else
            {
                bahis -= txbox;
                bakiye += txbox;
                label1.Text = "Bahis: " + bahis.ToString();
                label2.Text = "Bakiye: " + bakiye.ToString();
                textBox1.Text = "";
            }
        }

        Random rnd = new Random();
        string[] harf = {"k","h","s","m"};
        string diziharf;
        string kart;
        int krupiye;
        int player;
        string adres;
        int say = 1;
        string pbox5adres;
        int sigorta = 0;
        int playeras, krupiyeas;

        void ilkpuan()
        {   
            kartsec();
            if(rndsay > 10)
            {
                rndsay = 10;
            }
            krupiye += rndsay;
            if (rndsay == 1)
            {
                krupiyeas ++;
            }
            if (krupiye <= 11 && krupiyeas == 1)
            {
                krupiye += 10;
            }
            /*if(krupiye == 1)
            {
                askr++;
                sigorta++;
                if (askr == 1)
                {
                    krupiye+= 10;
                }
            }*/
            switch (say)
            {
                case 1:
                    pictureBox2.Image = Image.FromFile(adres);
                    say++;
                    break;
                case 3:
                    pbox5adres = adres;
                    pictureBox3.Image = Image.FromFile("cards/arka.png");
                    say++;
                    break;
                default:
                    break;
            }
            kartsec();
            if (rndsay > 10)
            {
                rndsay = 10;
            }else if(rndsay == 1)
            {
                playeras ++;
            }


            player += rndsay;
            if(player <= 11 && playeras == 1)
            {
                player += 10;
                if (player == 21)
                {
                    button6.Enabled = false;
                }
            }
            if (player == 21)
            {
                button6.Enabled = false;
            }

            /*look if (player == 1)
             {
                 aspl++;
                 if (aspl == 1)
                 {
                     player += 10;
                 }
             }*/
            switch (say)
            {
                case 2:
                    pictureBox8.Image = Image.FromFile(adres);
                    say++;
                    break;
                case 4:
                    pictureBox9.Image = Image.FromFile(adres);
                    say++;
                    break;
                default:
                    break;
            }
        }

        string deneme;
        int rehin;
        private void button5_Click(object sender, EventArgs e)
        {
            if (bahis != 0)
            {
                for (int i = 0; i < 2; i++ ) {
                    ilkpuan();
                }
                if (sigorta != 0)
                {
                    DialogResult secenek = MessageBox.Show("Bahsi Sigortala?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(secenek == DialogResult.Yes)
                    {
                        rehin = 1000;
                        bakiye -= 1000;
                        label2.Text = "Bakiye: "+bakiye;
                    }
                }
                //MessageBox.Show(krupiye.ToString() + " " + player.ToString()+"\n"+deneme+"\n"+pbox5adres);
                //{
                    label4.Text = "Puan: " + player;
                //}else if(rndsay == 1)
                //{
                //    label4.Text = "Puan: " + player + "/" + (player + 10);
                //}
                
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                if(player != 21){button6.Enabled = true;}
                button7.Enabled = true;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.ReadOnly = false;
            }
            else 
            {
                MessageBox.Show("Lütfen Bahis Girin!");
            }
        }

        int ceksay;
        void regamefonksiyon()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
            button9.Enabled = true;
            textBox1.ReadOnly = true;
            label1.Text = "Bahis: 0";
            pictureBox2.Image = Image.FromFile("cards/space.png");
            pictureBox3.Image = Image.FromFile("cards/space.png");
            pictureBox4.Image = Image.FromFile("cards/space.png");
            pictureBox5.Image = Image.FromFile("cards/space.png");
            pictureBox6.Image = Image.FromFile("cards/space.png");
            pictureBox7.Image = Image.FromFile("cards/space.png");
            pictureBox8.Image = Image.FromFile("cards/space.png");
            pictureBox9.Image = Image.FromFile("cards/space.png");
            pictureBox10.Image = Image.FromFile("cards/space.png");
            pictureBox11.Image = Image.FromFile("cards/space.png");
            pictureBox12.Image = Image.FromFile("cards/space.png");
            pictureBox13.Image = Image.FromFile("cards/space.png");
            rndsay = 0;
            player = 0;
            krupiye = 0;
            adres = "";
            diziharf = "";
            say = 1;
            ceksay = 0;
            kalsay = 0;
            bahis = 0;
            rehin = 0;
            playeras = 0;
            krupiyeas = 0;
            label3.Text = "Puan: 0";
            label4.Text = "Puan: 0";
        }
        void resetgame()
        {
            if (bakiye > 0)
            {
                regamefonksiyon();
            }
            else
            {
                regamefonksiyon();
                MessageBox.Show("BATTIN!");
                DialogResult battin = MessageBox.Show("Tekrar başlamak ister misin?","BATTIN",MessageBoxButtons.YesNo);
                if (battin == DialogResult.Yes)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    label1.Text = "Bahis: 0";
                    label2.Text = "Bakiye: 50000";
                    bakiye = 50000;
                    pictureBox2.Image = Image.FromFile("cards/space.png");
                    pictureBox3.Image = Image.FromFile("cards/space.png");
                    pictureBox4.Image = Image.FromFile("cards/space.png");
                    pictureBox5.Image = Image.FromFile("cards/space.png");
                    pictureBox6.Image = Image.FromFile("cards/space.png");
                    pictureBox7.Image = Image.FromFile("cards/space.png");
                    pictureBox8.Image = Image.FromFile("cards/space.png");
                    pictureBox9.Image = Image.FromFile("cards/space.png");
                    pictureBox10.Image = Image.FromFile("cards/space.png");
                    pictureBox11.Image = Image.FromFile("cards/space.png");
                    pictureBox12.Image = Image.FromFile("cards/space.png");
                    pictureBox13.Image = Image.FromFile("cards/space.png");
                    rndsay = 0;
                    player = 0;
                    krupiye = 0;
                    adres = "";
                    diziharf = "";
                    say = 1;
                    ceksay = 0;
                    kalsay = 0;
                    bahis = 0;
                    rehin = 0;
                    label3.Text = "Puan: 0";
                    label4.Text = "Puan: 0";
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kartsec();
            ceksay ++;
            if (rndsay > 10)
            {
                rndsay = 10;
            }
            if(rndsay == 1)
            {
                playeras++;
            }//  ?
            if (player <= 11 && playeras == 1)
            {
                player += 10;
            }else
            player += rndsay;
            label4.Text = "Puan: " + player;
            //if (playeras > 1)
            //{
            //    label4.Text = "Puan: " + player;
            //}
            //if(playeras == 1)
            //{
            //    label4.Text = "Puan: " + player + "/" + (player + 10);
            //}
            
            switch (ceksay)
            {
                case 1:
                    pictureBox10.Image = Image.FromFile(adres);
                    say++;
                    break;
                case 2:
                    pictureBox11.Image = Image.FromFile(adres);
                    say++;
                    break;
                case 3:
                    pictureBox12.Image = Image.FromFile(adres);
                    say++;
                    break;
                case 4:
                    pictureBox13.Image = Image.FromFile(adres);
                    say++;
                    break;
                default:
                    say = 1;
                    break;
            }
            if (player < 21 && say == 4)
            {
                say = 1;
            }
            else if (player == 21)
            {
                label4.Text = "Blackjack!";
                button6.Enabled = false;
            }
            else if (player > 21)
            {
                MessageBox.Show("Patladın!");
                resetgame();
            }

        }

        int kalsay;
        //krupiye
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(pbox5adres);
            button6.Enabled = false;
            while (true)
            {
                if (krupiye <= 16 || krupiye < player && sigorta == 0)
                {
                    kartsec();
                    kalsay++;
                    if (rndsay > 10)
                    {
                        rndsay = 10;
                    }
                    krupiye += rndsay;
                    label3.Text = "Puan: " + krupiye;
                    switch (kalsay)
                    {
                        case 1:
                            pictureBox4.Image = Image.FromFile(adres);
                            say++;
                            break;
                        case 2:
                            pictureBox5.Image = Image.FromFile(adres);
                            say++;
                            break;
                        case 3:
                            pictureBox6.Image = Image.FromFile(adres);
                            say++;
                            break;
                        case 4:
                            pictureBox7.Image = Image.FromFile(adres);
                            say++;
                            break;
                        default:
                            ceksay = 1;
                            break;
                    }
                    if (krupiye < 21 && krupiye > player)
                    {
                        MessageBox.Show("Krupiye Kazandı!");
                        resetgame();
                        break;
                    }
                    else if (krupiye > 21)
                    {
                        MessageBox.Show("Krupiye Patladı!");
                        bakiye += (bahis * 2);
                        bakiye += rehin;
                        label2.Text = "Bakiye: " + bakiye;
                        resetgame();
                        break;
                    }
                    else if (krupiye == 21)
                    {
                        MessageBox.Show("Blackjack Krupiyede");
                        if (player != 21)
                        {
                            MessageBox.Show("Krupiye Kazandı!");
                            resetgame();
                            break;
                        }
                        else //if (player == 21)
                        {
                            label3.Text = "Puan: " + krupiye;
                            MessageBox.Show("Berabere!");
                            bakiye += rehin;
                            bakiye += bahis;
                            label2.Text = "Bakiye: " + bakiye;
                            label3.Text = "Puan: " + krupiye;
                            resetgame();
                            break;
                        }
                        //break;
                    }
                    
                }else if(krupiye>=17 && krupiye == player)
                {

                    label3.Text = "Puan: " + krupiye;
                    MessageBox.Show("Berabere!");
                    bakiye += rehin;
                    bakiye += bahis;
                    label2.Text = "Bakiye: " + bakiye;
                    resetgame();
                    break;
                }
                else if (krupiye >= 17 && krupiye > player)
                {
                    label3.Text = "Puan: " + krupiye;
                    MessageBox.Show("Krupiye Kazandı!");
                    resetgame();
                    break;
                }
            }
        }
    }
}
