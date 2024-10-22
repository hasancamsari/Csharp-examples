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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source = personel.mdb");

        private void Form6_Load(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select ID, AD, SOYAD, ISTANIM from tablo1", baglan);
            DataTable tab = new DataTable();
            adap.Fill(tab);

            dataGridView1.DataSource = tab;
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sor = MessageBox.Show("Personeli Çıkarmak İstediğinize Emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo);

            if (sor == System.Windows.Forms.DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int silinecekid = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                    baglan.Open();
                    OleDbCommand sil = new OleDbCommand("delete from tablo1 where ID='" + silinecekid.ToString("D4") + "'", baglan);
                    sil.Parameters.AddWithValue("@id", silinecekid);
                    sil.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            else
                MessageBox.Show("İptal edildi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
