using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Satış
{
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }
        // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        DataSet daset = new DataSet();// verilerin geçici tutlması

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();//kategori bilgilerinin okuma işlemini onayladık
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            urunListele();
            kategorigetir();

        }
        private void urunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(@"SELECT * FROM urun ", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];//Geçici verilerin urun Tablosuna aktarılması
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString();
            kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            urunAditxt.Text = dataGridView1.CurrentRow.Cells["urunAdi"].Value.ToString();
            miktaritxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            alisFiyatitxt.Text = dataGridView1.CurrentRow.Cells["alisFiyati"].Value.ToString();
            satisFiaytitxt.Text = dataGridView1.CurrentRow.Cells["satisFiyati"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (barkodNotxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET urunAdi=@urunAdi,miktari=@miktari,alisFiyati=@alisFiyati,satisFiyati=@satisFiyati WHERE barkodNo=@barkodNo", baglanti);

                komut.Parameters.AddWithValue("@barkodNo", barkodNotxt.Text);
                komut.Parameters.AddWithValue("@urunAdi", urunAditxt.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(miktaritxt.Text));
                komut.Parameters.AddWithValue("@alisFiyati", double.Parse(alisFiyatitxt.Text));
                komut.Parameters.AddWithValue("@satisFiyati", double.Parse(satisFiaytitxt.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme Yapıldı !!!");

                daset.Tables["urun"].Clear();
                urunListele();
            }
            else
            {
                MessageBox.Show("Barkod No Boş Bırakılamaz !!!");
            }
            //Form Textlerini temizleme
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (barkodNotxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET kategori=@kategori,marka=@marka WHERE barkodNo=@barkodNo", baglanti);

                komut.Parameters.AddWithValue("@barkodNo", barkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı !!!");
                daset.Tables["urun"].Clear();
                urunListele();
            }
            else
            {
                MessageBox.Show("Barkod No Boş Olamaz !!!");
            }
            //Form Textlerini temizleme
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }
        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori", baglanti);
            komut.Parameters.AddWithValue("@kategori", comboKategori.SelectedItem.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM urun WHERE barkodNo='" + dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            urunListele();
            MessageBox.Show("Kayıt Silindi !!");
        }
        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM urun WHERE barkodNo like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void barkodNotxt_TextChanged(object sender, EventArgs e)
        {
            //Urun eklemede barkod okuyucu özelliği yok
            if (barkodNotxt.Text.Length >= 1) // örnek olarak en az 1 karakterlik barkod varsayalım
            {

            }
        }
    }
}
