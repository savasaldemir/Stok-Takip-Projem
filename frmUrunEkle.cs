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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Satış
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                //aranan kayıt veri tabaanında var ise False yap Eklenmesin
                if (txtBarkodNo.Text == read["barkodno"].ToString() || txtBarkodNo.Text == "")//Veri tabanı kontrol
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
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

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                //Ekleme komutu
                SqlCommand komut = new SqlCommand("INSERT INTO urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) VALUES(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);//Ekleme Komutu
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böylbir barkod No var", "UYARI");
            }

            comboMarka.Items.Clear();
            //groub box1 deki verileri temizleme
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void barkodNotxt_TextChanged(object sender, EventArgs e)
        {
            //GruopBox2 txt leri temizleme
            if (barkodNotxt.Text == "")
            {
                lblMiktar.Text = ""; //Label miktarı temizleme
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            if (barkodNotxt.Text.Length >= 1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno like '" + barkodNotxt.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();

                while (read.Read())
                {
                    kategoritxt.Text = read["kategori"].ToString();
                    markatxt.Text = read["marka"].ToString();
                    urunAditxt.Text = read["urunadi"].ToString();
                    lblMiktar.Text = read["miktari"].ToString();
                    alisFiyatitxt.Text = read["alisfiyati"].ToString();
                    satisFiaytitxt.Text = read["satisfiyati"].ToString();
                }
                baglanti.Close();
            }

            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno like '" + barkodNotxt.Text + "'", baglanti);
            //SqlDataReader read = komut.ExecuteReader();

            //while (read.Read())
            //{
            //    kategoritxt.Text = read["kategori"].ToString();
            //    markatxt.Text = read["marka"].ToString();
            //    urunAditxt.Text = read["urunadi"].ToString();
            //    lblMiktar.Text = read["miktari"].ToString();
            //    alisFiyatitxt.Text = read["alisfiyati"].ToString();
            //    satisFiaytitxt.Text = read["satisfiyati"].ToString();
            //}
            //baglanti.Close();
        }

        private void btnVarOlanEkle_Click(object sender, EventArgs e)
        {
            if (barkodNotxt.Text != "")
            {
                //Var ola ürünü güncelleme groupBox2
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET miktari=miktari+'" + int.Parse(miktaritxt.Text) + "' WHERE barkodno='" + barkodNotxt.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Var olan ürüne ekleme yapıldı");
            }
            else
            {
                MessageBox.Show("UUUPPPPSSS Barkod No Nerede ?????");
            }


            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            //Urun eklemede barkod okuyucu özelliği yok
            if (txtBarkodNo.Text.Length >= 1) // örnek olarak en az 1 karakterlik barkod varsayalım
            {

            }
        }
    }
}
