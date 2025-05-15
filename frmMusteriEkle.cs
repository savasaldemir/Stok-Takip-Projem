using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Satış
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
       SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    "INSERT INTO musteri (tc,adsoyad,telefon,adres,email) VALUES (@tc,@adsoyad,@telefon,@adres,@email)",
                    baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Kaydı Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message + baglanti);
            }
            finally
            {
                baglanti.Close();
            }

            // Tüm TextBox'ları temizle
            Temizle(this);
        }

        // Tüm kontrolleri iç içe tarayıp TextBox'ları temizleyen yardımcı metot
        private void Temizle(Control kontrol)
        {
            foreach (Control item in kontrol.Controls)
            {
                if (item is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }

                if (item.HasChildren)
                {
                    Temizle(item); // iç içe kontrolleri de temizle
                }
            }
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
