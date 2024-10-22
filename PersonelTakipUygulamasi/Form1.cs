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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = personel.mdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        string pozisyon;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            pozisyon = "p";
            label3.Text = "Personel";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            pozisyon = "y";
            label3.Text = "Yönetici";
            textBox1.Focus();
        }

        string f2id;
        string f2sifre;
        string f2ad;
        string f2soyad;
        string f2istanim;
        string f2kod;

        private void button3_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            password = textBox2.Text;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (pozisyon == "p")
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM tablo1 WHERE ID ='"+textBox1.Text+"' AND SIFRE ='"+textBox2.Text+"'", baglan);

                    DataTable tab = new DataTable();
                    adap.Fill(tab);

                    foreach (DataRow row in tab.Rows)
                    {
                        f2id = row["ID"].ToString();
                        f2sifre = row["SIFRE"].ToString();
                        f2ad = row["AD"].ToString();
                        f2soyad = row["SOYAD"].ToString();
                        f2istanim = row["ISTANIM"].ToString();
                        f2kod = row["KOD"].ToString();
                    }
                    
                    Form2 frm = new Form2(f2id);

                    if (f2id != null)
                    {
                        //if (f2kod == "P")
                        //{
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                        //}
                        //else
                        //  MessageBox.Show("Yönetici Seçimini Yapınız.");
                    }
                    else
                        MessageBox.Show("Kullanıcı bulunamadı.");                    
                }
                else
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM tablo1 WHERE ID ='" + textBox1.Text + "' AND SIFRE ='" + textBox2.Text + "'", baglan);

                    DataTable tab = new DataTable();
                    adap.Fill(tab);

                    foreach (DataRow row in tab.Rows)
                    {
                        f2id = row["ID"].ToString();
                        f2ad = row["AD"].ToString();
                        f2soyad = row["SOYAD"].ToString();
                        f2kod = row["KOD"].ToString();
                    }

                    Form2 frm = new Form2(f2id);

                    if (f2id != null)
                    {
                        if (f2kod == "Y")
                        {
                            Form4 frm4 = new Form4(f2ad, f2soyad);
                            this.Hide();
                            frm4.ShowDialog();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Personel Seçimini Yapınız.");
                    }
                    else
                        MessageBox.Show("Kullanıcı bulunamadı.");  
                }
            }
            else if(textBox1.Text == "")
                {
                    MessageBox.Show("ID giriniz.");
                    textBox1.Focus();
                }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifre giriniz.");
                textBox2.Focus();
            }
            
        }

        string id, password;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                password = textBox2.Text;
                button3_Click(sender, e);
            }
            //if (!char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    textBox2.AppendText("*");
            //}

            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    button3_Click(sender,e);
            //}
        }
    }
}
