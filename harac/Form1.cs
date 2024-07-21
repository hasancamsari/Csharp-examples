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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hazine = 0;
        int isgal = 0;
        string devlet, bayrak, parabirimi;
        int venezuelaisgal = 100    ,
              romanyaisgal = 1000   ,
               israilisgal = 5000   ,
              polonyaisgal = 10000  ,
                 iranisgal = 15000  ,
                rusyaisgal = 20000  ,
               italyaisgal = 30000  ,
               fransaisgal = 50000  ,
            ingiltereisgal = 75000  ,
            hindistanisgal = 100000 ,
              almanyaisgal = 150000 ,
              japonyaisgal = 250000 ,
                  cinisgal = 500000 ,
              amerikaisgal = 1000000,
           
            venezuelaganimet = 20   ,
              romanyaganimet = 50   ,
               israilganimet = 200  ,
              polonyaganimet = 300  ,
                 iranganimet = 400  ,
                rusyaganimet = 600  ,
               italyaganimet = 1000 ,
               fransaganimet = 1500 ,
            ingiltereganimet = 2000 ,
            hindistanganimet = 3000 ,
              almanyaganimet = 5000 ,
              japonyaganimet = 10000,
                  cinganimet = 20000,
              amerikaganimet = 50000;

        void ganimetyaz()
        { 
            label4.Text  = "GANİMET: "+venezuelaganimet.ToString()+" "+parabirimi;
            label6.Text  = "GANİMET: "+  romanyaganimet.ToString()+" "+parabirimi;
            label8.Text  = "GANİMET: "+   israilganimet.ToString()+" "+parabirimi;
            label10.Text = "GANİMET: "+  polonyaganimet.ToString()+" "+parabirimi;
            label12.Text = "GANİMET: "+     iranganimet.ToString()+" "+parabirimi;
            label14.Text = "GANİMET: "+    rusyaganimet.ToString()+" "+parabirimi;
            label16.Text = "GANİMET: "+   italyaganimet.ToString()+" "+parabirimi;
            label18.Text = "GANİMET: "+   fransaganimet.ToString()+" "+parabirimi;
            label20.Text = "GANİMET: "+ingiltereganimet.ToString()+" "+parabirimi;
            label22.Text = "GANİMET: "+hindistanganimet.ToString()+" "+parabirimi;
            label24.Text = "GANİMET: "+  almanyaganimet.ToString()+" "+parabirimi;
            label26.Text = "GANİMET: "+  japonyaganimet.ToString()+" "+parabirimi;
            label28.Text = "GANİMET: "+      cinganimet.ToString()+" "+parabirimi;
            label30.Text = "GANİMET: "+  amerikaganimet.ToString()+" "+parabirimi;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hazine = 100;
            parabirimi = Form2.para;
            devlet = Form2.isim;
            bayrak = Form2.renk;
            label2.Text = devlet;
            label1.Text = "HAZİNE: " + hazine.ToString() +" "+ parabirimi;
            switch (bayrak)
            {
                case "Red":
                    pictureBox15.BackColor = Color.Red;
                    break;
                case "Blue":
                    pictureBox15.BackColor = Color.Blue;
                    break;
                case "Green":
                    pictureBox15.BackColor = Color.Green;
                    break;
                case "Yellow":
                    pictureBox15.BackColor = Color.Yellow;
                    break;
                case "Orange":
                    pictureBox15.BackColor = Color.Orange;
                    break;
                case "Purple":
                    pictureBox15.BackColor = Color.Purple;
                    break;
                default:
                    break;
            }

            pictureBox1.Image  = Image.FromFile(@"flags/venezuela.png");
            pictureBox2.Image  = Image.FromFile(@"flags/romanya.png");
            pictureBox3.Image  = Image.FromFile(@"flags/israil.png");
            pictureBox4.Image  = Image.FromFile(@"flags/polonya.png");
            pictureBox5.Image  = Image.FromFile(@"flags/iran.png");
            pictureBox6.Image  = Image.FromFile(@"flags/rusya.png");
            pictureBox7.Image  = Image.FromFile(@"flags/italya.png");
            pictureBox8.Image  = Image.FromFile(@"flags/fransa.png");
            pictureBox9.Image  = Image.FromFile(@"flags/ingiltere.png");
            pictureBox10.Image = Image.FromFile(@"flags/hindistan.png");
            pictureBox11.Image = Image.FromFile(@"flags/almanya.png");
            pictureBox12.Image = Image.FromFile(@"flags/japonya.png");
            pictureBox13.Image = Image.FromFile(@"flags/cin.png");
            pictureBox14.Image = Image.FromFile(@"flags/amerika.png");

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox3.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox4.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox5.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox6.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox7.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox8.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox9.BorderStyle  = BorderStyle.FixedSingle;
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel7.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel10.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel11.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel12.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel13.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel14.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel15.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel16.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel17.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel18.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel19.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel20.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel21.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel22.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel23.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel24.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel25.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel26.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel27.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel28.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel29.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            label3.Text  = "İŞGAL ÜCRETİ: "+venezuelaisgal.ToString()+" "+parabirimi;
            label5.Text  = "İŞGAL ÜCRETİ: "+  romanyaisgal.ToString()+" "+parabirimi;
            label7.Text  = "İŞGAL ÜCRETİ: "+   israilisgal.ToString()+" "+parabirimi;
            label9.Text  = "İŞGAL ÜCRETİ: "+  polonyaisgal.ToString()+" "+parabirimi;
            label11.Text = "İŞGAL ÜCRETİ: "+     iranisgal.ToString()+" "+parabirimi;
            label13.Text = "İŞGAL ÜCRETİ: "+    rusyaisgal.ToString()+" "+parabirimi;
            label15.Text = "İŞGAL ÜCRETİ: "+   italyaisgal.ToString()+" "+parabirimi;
            label17.Text = "İŞGAL ÜCRETİ: "+   fransaisgal.ToString()+" "+parabirimi;
            label19.Text = "İŞGAL ÜCRETİ: "+ingiltereisgal.ToString()+" "+parabirimi;
            label21.Text = "İŞGAL ÜCRETİ: "+hindistanisgal.ToString()+" "+parabirimi;
            label23.Text = "İŞGAL ÜCRETİ: "+  almanyaisgal.ToString()+" "+parabirimi;
            label25.Text = "İŞGAL ÜCRETİ: "+  japonyaisgal.ToString()+" "+parabirimi;
            label27.Text = "İŞGAL ÜCRETİ: "+      cinisgal.ToString()+" "+parabirimi;
            label29.Text = "İŞGAL ÜCRETİ: "+  amerikaisgal.ToString()+" "+parabirimi;

            ganimetyaz();


        }

        Graphics g;
        void isgalet()
        {
            Color transparentRed = Color.FromArgb(128, 255, 0, 0);
            SolidBrush brush = new SolidBrush(transparentRed);
            Rectangle rect = new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height);
            g.FillRectangle(brush, rect);
            //brush.Dispose();
            //g.Dispose();
        }

        //------------------------------------------------------------------------------
        bool venezuela = false;
        bool romanya = false;
        bool israil = false;
        bool polonya = false;
        bool iran = false;
        bool rusya = false;
        bool italya = false;
        bool fransa = false;
        bool ingiltere = false;
        bool hindistan = false;
        bool almanya = false;
        bool japonya = false;
        bool cin = false;
        bool amerika = false;
        //------------------------------------------------------------------------------

        int isgal_edilen = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hazine >= 100 && venezuela == false)
            {
                hazine -= 100;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                venezuela = true;
                isgal_edilen++;

                g = pictureBox1.CreateGraphics();
                isgalet();
            }
            else if (venezuela == true)
            {
                hazine += 20;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (hazine >= 1000 && romanya == false)
            {
                hazine -= 1000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                romanya = true;
                isgal_edilen++;

                g = pictureBox2.CreateGraphics();
                isgalet();
            }
            else if (romanya == true)
            {
                hazine += 50;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (hazine >= 5000 && israil == false)
            {
                hazine -= 5000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                israil = true;
                isgal_edilen++;

                g = pictureBox3.CreateGraphics();
                isgalet();
            }
            else if (israil == true)
            {
                hazine += 200;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (hazine >= 10000 && polonya == false)
            {
                hazine -= 10000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                polonya = true;
                isgal_edilen++;

                g = pictureBox4.CreateGraphics();
                isgalet();
            }
            else if (polonya == true)
            {
                hazine += 300;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (hazine >= 15000 && iran == false)
            {
                hazine -= 15000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                iran = true;
                isgal_edilen++;

                g = pictureBox5.CreateGraphics();
                isgalet();
            }
            else if (iran == true)
            {
                hazine += 400;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (hazine >= 20000 && rusya == false)
            {
                hazine -= 20000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                rusya = true;
                isgal_edilen++;

                g = pictureBox6.CreateGraphics();
                isgalet();
            }
            else if (rusya == true)
            {
                hazine += 600;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (hazine >= 30000 && italya == false)
            {
                hazine -= 30000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                italya = true;
                isgal_edilen++;

                g = pictureBox7.CreateGraphics();
                isgalet();
            }
            else if (italya == true)
            {
                hazine += 1000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (hazine >= 50000 && fransa == false)
            {
                hazine -= 50000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                fransa = true;
                isgal_edilen++;

                g = pictureBox8.CreateGraphics();
                isgalet();
            }
            else if (fransa == true)
            {
                hazine += 1500;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (hazine >= 75000 && ingiltere == false)
            {
                hazine -= 75000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                ingiltere = true;
                isgal_edilen++;

                g = pictureBox9.CreateGraphics();
                isgalet();
            }
            else if (ingiltere == true)
            {
                hazine += 2000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (hazine >= 100000 && hindistan == false)
            {
                hazine -= 100000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                hindistan = true;
                isgal_edilen++;

                g = pictureBox10.CreateGraphics();
                isgalet();
            }
            else if (hindistan == true)
            {
                hazine += 3000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (hazine >= 150000 && almanya == false)
            {
                hazine -= 150000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                almanya = true;

                isgal_edilen++;
                g = pictureBox11.CreateGraphics();
                isgalet();
            }
            else if (almanya == true)
            {
                hazine += 5000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (hazine >= 250000 && japonya == false)
            {
                hazine -= 250000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                japonya = true;
                isgal_edilen++;

                g = pictureBox12.CreateGraphics();
                isgalet();
            }
            else if (hindistan == true)
            {
                hazine += 10000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (hazine >= 500000 && cin == false)
            {
                hazine -= 500000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                cin = true;
                isgal_edilen++;

                g = pictureBox13.CreateGraphics();
                isgalet();
            }
            else if (cin == true)
            {
                hazine += 20000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (hazine >= 1000000 && amerika == false)
            {
                hazine -= 1000000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
                amerika = true;
                isgal_edilen++;

                g = pictureBox14.CreateGraphics();
                isgalet();
            }
            else if (amerika == true)
            {
                hazine += 50000;
                label1.Text = "HAZİNE: " + hazine.ToString() + " " + parabirimi;
            }
        }        
    }
}
