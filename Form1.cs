
using System.Data;
using Microsoft.Data.SqlClient;

namespace Satış
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            //DataGridWiev de üç kolonu gizledik
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            baglanti.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriListeleme listele = new frmMusteriListeleme();
            listele.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmUrunEkle urunEkle = new frmUrunEkle();
            urunEkle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunListele listele = new frmUrunListele();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT sum(toplamfiyati) FROM sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM musteri WHERE tc like '" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }

        //private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        //{
        //    Temizle();
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno like '" + txtBarkodNo.Text + "'", baglanti);
        //    SqlDataReader read = komut.ExecuteReader();
        //    while (read.Read())
        //    {
        //        txtUrunAdi.Text = read["urunadi"].ToString();
        //        txtSatisFiyati.Text = read["satisfiyati"].ToString();

        //    }
        //    baglanti.Close();

        //}




        //****************    


        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text.Length >= 1) // örnek olarak en az 1 karakterlik barkod varsayalım
            {
                Temizle();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno = @barkod", baglanti);
                komut.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtUrunAdi.Text = read["urunadi"].ToString();
                    txtSatisFiyati.Text = read["satisfiyati"].ToString();
                }
                baglanti.Close();
            }
        }


        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                //sepette var olan miktari alt alta eklemek yerine toplayarak ekleme
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                //barkod.text boş olma durumunu kontrol etme mantığı
                //Eşit Değil Değilse Sonraki if 'e geç
                //Eşit Değile Eşitse else geç
                if (txtBarkodNo.Text != "")
                {
                    barkodkontrol(); // bu metod 'durum' değişkenini belirliyor

                    if (durum) // sepette yoksa ekle
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("INSERT INTO sepet(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) VALUES(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);
                        komut.Parameters.AddWithValue("@tc", txtTc.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                        komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                        komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                        komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                        komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else // sepette varsa miktarı ve toplam fiyatı güncelle
                    {
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("UPDATE sepet SET miktari = miktari + @ekMiktar WHERE barkodno = @barkod", baglanti);
                        komut2.Parameters.AddWithValue("@ekMiktar", int.Parse(txtMiktar.Text));
                        komut2.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                        komut2.ExecuteNonQuery();

                        SqlCommand komut3 = new SqlCommand("UPDATE sepet SET toplamfiyati = miktari * satisfiyati WHERE barkodno = @barkod", baglanti);
                        komut3.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    hesapla();
                    txtMiktar.Text = "1";
                    daset.Tables["sepet"].Clear();
                    sepetlistele();
                    hesapla();//satis tamamen doğru bir satış olduğunda devreye girmeli

                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is TextBox && item != txtMiktar)
                        {
                            item.Text = "";
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Barkod Giriniz");
                    //Application.Restart();
                }

            }
            catch (Exception)
            {

                ;
            }

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM sepet WHERE barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Sepetten Çıkarıldı");
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();

                if (komut != komut)
                {
                    MessageBox.Show("Ürün seçilmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Huupppsss Silme işleminde bir hata var işelemlerini kontrol ediniz !!!" + ex);
            }
            finally
            {
                baglanti.Close();
            }
            
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatisListele listele = new frmSatisListele();
            listele.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)//-1 dataGridWiev de son satırın boş olması anlamına gelir
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO satis(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) VALUES(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("UPDATE urun SET miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' WHERE barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("DELETE FROM sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();//satis tamamen doğru bir satış olduğunda devreye girmeli
        }
    }
}
