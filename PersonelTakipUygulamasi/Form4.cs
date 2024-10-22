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
    public partial class Form4 : Form
    {
        public Form4(string ad, string soyad)
        {
            InitializeComponent();

            label2.Text = ad + " " + soyad + " HOŞGELDİNİZ.";
            f4ad = ad;
            f4sad = soyad;
        }
        string f4ad, f4sad;
 
        OleDbConnection baglan = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = bilgiler.mdb");

        private void Form4_Load(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from tablo1",baglan);
            DataTable tab = new DataTable();
            adap.Fill(tab);

            dataGridView1.DataSource = tab;
            baglan.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            baglan.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM tablo1 WHERE TARIH ='" + tarih + "'", baglan);
            DataTable tab = new DataTable();
            adap.Fill(tab);

            dataGridView1.DataSource = tab;
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from tablo1", baglan);
            DataTable tab = new DataTable();
            adap.Fill(tab);

            dataGridView1.DataSource = tab;
            baglan.Close();
        }
    }
}
