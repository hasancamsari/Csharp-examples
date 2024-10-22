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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = personel.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                (checkBox1.Checked || checkBox2.Checked))
            {
                OleDbCommand ekle = new OleDbCommand("insert into tablo1 values (@id,@sifre,@ad,@soyad,@istanim,@konum)", baglan);
                ekle.Parameters.AddWithValue("id", textBox1.Text);
                ekle.Parameters.AddWithValue("sifre", textBox2.Text);
                ekle.Parameters.AddWithValue("ad", textBox3.Text);
                ekle.Parameters.AddWithValue("soyad", textBox4.Text);
                ekle.Parameters.AddWithValue("istanim", comboBox1.Text);
                ekle.Parameters.AddWithValue("konum",konum);
                baglan.Open();
                ekle.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Personel Kaydı Yapıldı!");
                enbuyukid();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
                MessageBox.Show("Tüm verileri eksiksiz girin.");
            
        }
       

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("CEO");
            comboBox1.Items.Add("YAZILIM GELİŞTİRİCİ");
            comboBox1.Items.Add("KIDEMLİ YAZILIM GELİŞTİRİCİ");
            comboBox1.Items.Add("YAZILIM MÜHENDİSİ");
            comboBox1.Items.Add("SİSTEM MÜHENDİSİ");
            comboBox1.Items.Add("VERİTABANI YÖNETİCİSİ");
            comboBox1.Items.Add("FRONTEND GELİŞTİRİCİ");
            comboBox1.Items.Add("BACKEND GELİŞTİRİCİ");
            comboBox1.Items.Add("TAM YIĞIN GELİŞTİRİCİ");
            comboBox1.Items.Add("TEST MÜHENDİSİ");
            comboBox1.Items.Add("ÜRÜN YÖNETİCİSİ");
            comboBox1.Items.Add("PROJE YÖNETİCİSİ");
            comboBox1.Items.Add("UX/UI TASARIMCISI");
            comboBox1.Items.Add("DEVOPS MÜHENDİSİ");
            comboBox1.Items.Add("AĞ MÜHENDİSİ");
            comboBox1.Items.Add("MUHASEBECİ");
            

            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            enbuyukid();
            
        }

        void enbuyukid()
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT MAX(ID) AS MaxID FROM tablo1", baglan);
            DataTable tab = new DataTable();
            adap.Fill(tab);

            foreach (DataRow row in tab.Rows)
            {
                textBox1.ReadOnly = false;
                textBox1.Text = (Convert.ToInt32(row[0].ToString()) + 1).ToString("D4");
                textBox1.ReadOnly = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox4.Focus();
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBox1.Focus();
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Focus();
        }

        string konum;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                konum = "P";
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                konum = "Y";
                checkBox1.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}