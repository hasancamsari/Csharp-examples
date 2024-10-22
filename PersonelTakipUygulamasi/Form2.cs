using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PersonelTakipUygulamasi
{
    public partial class Form2 : Form
    {
        public Form2(string id)
        {
            InitializeComponent();
            timer1.Start();

            f2id = id;
        }
        public string saatstring;
        private int hours  ;
        private int minutes;
        private int seconds;

        OleDbConnection baglan = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = personel.mdb");

        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM tablo1 WHERE ID ='" + f2id +"'", baglan);

            DataTable tab = new DataTable();
            adap.Fill(tab);

            foreach (DataRow row in tab.Rows)
            {
                f2ad = row["AD"].ToString();
                f2soyad = row["SOYAD"].ToString();
                f2istanim = row["ISTANIM"].ToString();
            }
            label2.Text = f2ad + " " + f2soyad + " HOŞGELDİNİZ";
        }

        string f2id;
        string f2ad;
        string f2soyad;
        string f2istanim;

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }
            
            label1.Text = hours.ToString("D2") + " : " + minutes.ToString("D2") + " : " + seconds.ToString("D2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.BackColor = Color.AliceBlue;
        }

        public DateTime tarih;
        public string saat;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sor = MessageBox.Show("Günü biritmek istediğinide emin misiniz?","DİKKAT!", MessageBoxButtons.YesNo);

            if(sor == System.Windows.Forms.DialogResult.Yes)
            {
                //timer1.Stop();
                //label1.BackColor = Color.DarkGray;

                tarih = Convert.ToDateTime(label1.Text);
                saat = tarih.ToString("HH:mm:ss");

                Form3 form3 = new Form3(f2id, saat);
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }
    }
}
