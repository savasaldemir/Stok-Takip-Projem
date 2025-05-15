using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Satış
{
    public partial class frmMusteriListeleme : Form
    {
        public frmMusteriListeleme()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        DataSet daset = new DataSet();

        private void frmMusteriListeleme_Load(object sender, EventArgs e)
        {
            kayıt_goster();
        }

        private void kayıt_goster()
        {
            daset.Clear();
            using (SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM musteri", baglanti))
            {
                adtr.Fill(daset, "musteri");
                dataGridView1.DataSource = daset.Tables["musteri"];
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
                txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
                txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
                txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE musteri SET adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email WHERE tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.ExecuteNonQuery();
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            daset.Tables["musteri"].Clear();
            kayıt_goster();
            MessageBox.Show("Müşteri kaydı güncellendi.");
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM musteri WHERE tc = @tc", baglanti);
                    komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                    komut.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message + baglanti);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            daset.Tables["musteri"].Clear();
            kayıt_goster();
            MessageBox.Show("Kayıt silindi.");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM musteri WHERE tc LIKE @arama", baglanti))
            {
                adtr.SelectCommand.Parameters.AddWithValue("@arama", "%" + txtTcAra.Text + "%");
                adtr.Fill(tablo);
            }
            dataGridView1.DataSource = tablo;
        }

        private void Temizle()
        {
            // GroupBox ya da Panel içindeki TextBox'lar da dahil!
            void ClearTextBoxes(Control control)
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl is TextBox tb)
                        tb.Text = "";
                    else if (ctrl.HasChildren)
                        ClearTextBoxes(ctrl);
                }
            }

            ClearTextBoxes(this); // this: form üzerindeki tüm kontroller
        }
    }
}
