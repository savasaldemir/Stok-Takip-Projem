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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                //aranan kayıt veri tabaanında var ise False yap Eklenmesin
                if (comboBox1.Text==read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text=="" || textBox1.Text == "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();//işlemi onyalama komutu
                baglanti.Close();
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir marka ve kategori var","UYARI");
            }
            
            textBox1.Text = "";
            comboBox1.Text = "";
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();//kategor bilgilerinin okuma işlemini onayladık
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
