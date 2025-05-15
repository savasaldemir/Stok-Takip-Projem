namespace Satış
{
    partial class frmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatisFiyati = new TextBox();
            txtMiktar = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblGenelToplam = new Label();
            label9 = new Label();
            btnSatisYap = new Button();
            btnEkle = new Button();
            panel2 = new Panel();
            btnSatisIptal = new Button();
            btnSil = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnKategori = new Button();
            btnMarka = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri işlemleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold);
            label3.Location = new Point(30, 89);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 3;
            label1.Text = "TC";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(133, 84);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(133, 55);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(133, 26);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 23);
            txtTc.TabIndex = 0;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatisFiyati);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(txtUrunAdi);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 199);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün işlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F, FontStyle.Bold);
            label8.Location = new Point(6, 146);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 9;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Bold);
            label7.Location = new Point(20, 117);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 8;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold);
            label6.Location = new Point(61, 88);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 7;
            label6.Text = "Miktar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold);
            label5.Location = new Point(40, 59);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 6;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold);
            label4.Location = new Point(30, 30);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 5;
            label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(133, 140);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(100, 23);
            txtToplamFiyat.TabIndex = 4;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(133, 111);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(100, 23);
            txtSatisFiyati.TabIndex = 3;
            txtSatisFiyati.TextChanged += txtSatisFiyati_TextChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(133, 82);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 2;
            txtMiktar.Text = "1";
            txtMiktar.TextAlign = HorizontalAlignment.Center;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(133, 53);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(100, 23);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(133, 24);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 0;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Controls.Add(groupBox2);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 50);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(258, 482);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblGenelToplam);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnSatisYap);
            panel1.Controls.Add(btnEkle);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(258, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 66);
            panel1.TabIndex = 6;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Century", 12F, FontStyle.Bold);
            lblGenelToplam.Location = new Point(407, 34);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(0, 20);
            lblGenelToplam.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F, FontStyle.Bold);
            label9.Location = new Point(263, 34);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 4;
            label9.Text = "Genel Toplam";
            // 
            // btnSatisYap
            // 
            btnSatisYap.Font = new Font("Century", 9F, FontStyle.Bold);
            btnSatisYap.Location = new Point(697, 21);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(94, 33);
            btnSatisYap.TabIndex = 3;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Century", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(16, 21);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(88, 33);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSatisIptal);
            panel2.Controls.Add(btnSil);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(972, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 416);
            panel2.TabIndex = 7;
            // 
            // btnSatisIptal
            // 
            btnSatisIptal.Font = new Font("Century", 9F, FontStyle.Bold);
            btnSatisIptal.Location = new Point(6, 112);
            btnSatisIptal.Name = "btnSatisIptal";
            btnSatisIptal.Size = new Size(99, 35);
            btnSatisIptal.TabIndex = 2;
            btnSatisIptal.Text = "Satış İptal";
            btnSatisIptal.UseVisualStyleBackColor = true;
            btnSatisIptal.Click += btnSatisIptal_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Century", 9F, FontStyle.Bold);
            btnSil.Location = new Point(8, 29);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(97, 37);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(258, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 416);
            panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(714, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button5
            // 
            button5.Font = new Font("Century", 9F, FontStyle.Bold);
            button5.Location = new Point(103, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 41);
            button5.TabIndex = 4;
            button5.Text = "Müşteri Listeleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Century", 9F, FontStyle.Bold);
            button6.Location = new Point(403, 3);
            button6.Name = "button6";
            button6.Size = new Size(94, 41);
            button6.TabIndex = 5;
            button6.Text = "Satışları Listeleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Century", 9F, FontStyle.Bold);
            button7.Location = new Point(303, 3);
            button7.Name = "button7";
            button7.Size = new Size(94, 41);
            button7.TabIndex = 6;
            button7.Text = "Ürün Listeleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Century", 9F, FontStyle.Bold);
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(94, 41);
            button8.TabIndex = 7;
            button8.Text = "Müşteri Ekleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Century", 9F, FontStyle.Bold);
            button9.Location = new Point(203, 3);
            button9.Name = "button9";
            button9.Size = new Size(94, 41);
            button9.TabIndex = 8;
            button9.Text = "Ürün Ekleme";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(btnKategori);
            flowLayoutPanel1.Controls.Add(btnMarka);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1084, 50);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnKategori
            // 
            btnKategori.Font = new Font("Century", 9F, FontStyle.Bold);
            btnKategori.Location = new Point(503, 3);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(94, 41);
            btnKategori.TabIndex = 9;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = true;
            btnKategori.Click += button1_Click;
            // 
            // btnMarka
            // 
            btnMarka.Font = new Font("Century", 9F, FontStyle.Bold);
            btnMarka.Location = new Point(603, 3);
            btnMarka.Name = "btnMarka";
            btnMarka.Size = new Size(94, 41);
            btnMarka.TabIndex = 10;
            btnMarka.Text = "Marka";
            btnMarka.UseVisualStyleBackColor = true;
            btnMarka.Click += button2_Click;
            // 
            // frmSatis
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1084, 532);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "frmSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private GroupBox groupBox2;
        private TextBox txtToplamFiyat;
        private TextBox txtSatisFiyati;
        private TextBox txtMiktar;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button btnSatisYap;
        private Button btnEkle;
        private Button btnSatisIptal;
        private Button btnSil;
        private Label lblGenelToplam;
        private Label label9;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnKategori;
        private Button btnMarka;
    }
}
