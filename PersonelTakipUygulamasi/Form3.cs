using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PersonelTakipUygulamasi
{
    public partial class Form3 : Form
    {
        public Form3(string id, string saat)
        {
            InitializeComponent();

            f3id = id;
            f3saat = saat;

            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM tablo1 WHERE ID ='" + f3id + "'", baglan2);

            DataTable tab = new DataTable();
            adap.Fill(tab);

            foreach (DataRow row in tab.Rows)
            {
                f3ad = row["AD"].ToString();
                f3soyad = row["SOYAD"].ToString();
                f3istanim = row["ISTANIM"].ToString();
            }
        }
        
        public string saatstr;

        OleDbConnection baglan = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = bilgiler.mdb");
        OleDbConnection baglan2 = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = personel.mdb");

        string f3id;
        string f3saat;
        string f3ad;
        string f3soyad;
        string f3istanim;

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ofiste");
            comboBox1.Items.Add("Remote");
            comboBox1.Text = "Seçim Yapınız";
            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = Color.Red;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                richTextBox1.ReadOnly = false;
                richTextBox1.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                OleDbCommand ekle = new OleDbCommand("insert into tablo1 values (@id,@ad,@soyad,@istanim,@saat,@aktivite,@calisma,@tarih)", baglan);
                ekle.Parameters.AddWithValue("id", f3id);
                ekle.Parameters.AddWithValue("ad", f3ad);
                ekle.Parameters.AddWithValue("soyad", f3soyad);
                ekle.Parameters.AddWithValue("istanim", f3istanim);
                ekle.Parameters.AddWithValue("saat", f3saat);
                ekle.Parameters.AddWithValue("aktivite", richTextBox1.Text);
                ekle.Parameters.AddWithValue("calisma", comboBox1.Text);
                ekle.Parameters.AddWithValue("tarih", DateTime.Now.ToString("yyyy-MM-dd"));
                baglan.Open();
                ekle.ExecuteNonQuery();
                baglan.Close();

                richTextBox1.Clear();
                comboBox1.SelectedIndex = -1;

                MessageBox.Show("Kayıt yapıldı.");

                //DialogResult sor = MessageBox.Show("Kayıt yapıldı. İyi akşamlar.", "Kayıt Tamamlandı", MessageBoxButtons.OK);
                //if(sor == System.Windows.Forms.DialogResult.OK)
                //{
                //    this.Close();
                //}

            }
            else
                MessageBox.Show("Aktivite giriniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(f3id);
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
