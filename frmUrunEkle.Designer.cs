namespace Satış
{
    partial class frmUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnYeniEkle = new Button();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboMarka = new ComboBox();
            comboKategori = new ComboBox();
            txtSatisFiyati = new TextBox();
            txtAlisFiyati = new TextBox();
            txtMiktar = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            groupBox2 = new GroupBox();
            lblMiktar = new Label();
            btnExit = new Button();
            satisFiaytitxt = new TextBox();
            alisFiyatitxt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnVarOlanEkle = new Button();
            miktaritxt = new TextBox();
            urunAditxt = new TextBox();
            markatxt = new TextBox();
            kategoritxt = new TextBox();
            barkodNotxt = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboMarka);
            groupBox1.Controls.Add(comboKategori);
            groupBox1.Controls.Add(txtSatisFiyati);
            groupBox1.Controls.Add(txtAlisFiyati);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 431);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.FlatAppearance.BorderSize = 0;
            btnYeniEkle.FlatAppearance.MouseDownBackColor = Color.Red;
            btnYeniEkle.FlatAppearance.MouseOverBackColor = Color.Green;
            btnYeniEkle.FlatStyle = FlatStyle.Flat;
            btnYeniEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnYeniEkle.Location = new Point(207, 372);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(75, 23);
            btnYeniEkle.TabIndex = 4;
            btnYeniEkle.Text = "EKLE";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label7.Location = new Point(43, 333);
            label7.Name = "label7";
            label7.Size = new Size(101, 18);
            label7.TabIndex = 15;
            label7.Text = "Satış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label5.Location = new Point(81, 257);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 14;
            label5.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label6.Location = new Point(51, 295);
            label6.Name = "label6";
            label6.Size = new Size(93, 18);
            label6.TabIndex = 13;
            label6.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label3.Location = new Point(85, 181);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 12;
            label3.Text = "Marka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label4.Location = new Point(62, 219);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 11;
            label4.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label2.Location = new Point(66, 128);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 10;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label1.Location = new Point(51, 90);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 4;
            label1.Text = "Barkod No";
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(161, 176);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(121, 26);
            comboMarka.TabIndex = 9;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(161, 123);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(121, 26);
            comboKategori.TabIndex = 4;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(161, 328);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(121, 26);
            txtSatisFiyati.TabIndex = 8;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(161, 290);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(121, 26);
            txtAlisFiyati.TabIndex = 7;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(161, 252);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(121, 26);
            txtMiktar.TabIndex = 6;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(161, 214);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(121, 26);
            txtUrunAdi.TabIndex = 5;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(161, 85);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(121, 26);
            txtBarkodNo.TabIndex = 4;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMiktar);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(satisFiaytitxt);
            groupBox2.Controls.Add(alisFiyatitxt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(btnVarOlanEkle);
            groupBox2.Controls.Add(miktaritxt);
            groupBox2.Controls.Add(urunAditxt);
            groupBox2.Controls.Add(markatxt);
            groupBox2.Controls.Add(kategoritxt);
            groupBox2.Controls.Add(barkodNotxt);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Century", 11.25F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 431);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürüne Ekle";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(46, 385);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(0, 18);
            lblMiktar.TabIndex = 27;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(292, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 32);
            btnExit.TabIndex = 26;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // satisFiaytitxt
            // 
            satisFiaytitxt.Location = new Point(201, 333);
            satisFiaytitxt.Name = "satisFiaytitxt";
            satisFiaytitxt.Size = new Size(122, 26);
            satisFiaytitxt.TabIndex = 25;
            // 
            // alisFiyatitxt
            // 
            alisFiyatitxt.Location = new Point(201, 295);
            alisFiyatitxt.Name = "alisFiyatitxt";
            alisFiyatitxt.Size = new Size(122, 26);
            alisFiyatitxt.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label8.Location = new Point(58, 333);
            label8.Name = "label8";
            label8.Size = new Size(101, 18);
            label8.TabIndex = 23;
            label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label9.Location = new Point(96, 257);
            label9.Name = "label9";
            label9.Size = new Size(63, 18);
            label9.TabIndex = 22;
            label9.Text = "Miktar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label10.Location = new Point(66, 295);
            label10.Name = "label10";
            label10.Size = new Size(93, 18);
            label10.TabIndex = 21;
            label10.Text = "Alış Fiyatı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label11.Location = new Point(100, 181);
            label11.Name = "label11";
            label11.Size = new Size(59, 18);
            label11.TabIndex = 20;
            label11.Text = "Marka";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label12.Location = new Point(77, 219);
            label12.Name = "label12";
            label12.Size = new Size(82, 18);
            label12.TabIndex = 19;
            label12.Text = "Ürün Adı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label13.Location = new Point(81, 128);
            label13.Name = "label13";
            label13.Size = new Size(78, 18);
            label13.TabIndex = 18;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label14.Location = new Point(66, 90);
            label14.Name = "label14";
            label14.Size = new Size(93, 18);
            label14.TabIndex = 17;
            label14.Text = "Barkod No";
            // 
            // btnVarOlanEkle
            // 
            btnVarOlanEkle.FlatAppearance.BorderSize = 0;
            btnVarOlanEkle.FlatAppearance.MouseDownBackColor = Color.Red;
            btnVarOlanEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnVarOlanEkle.FlatStyle = FlatStyle.Flat;
            btnVarOlanEkle.Location = new Point(138, 377);
            btnVarOlanEkle.Name = "btnVarOlanEkle";
            btnVarOlanEkle.Size = new Size(185, 35);
            btnVarOlanEkle.TabIndex = 16;
            btnVarOlanEkle.Text = "EKLE && GÜNCELLE";
            btnVarOlanEkle.UseVisualStyleBackColor = true;
            btnVarOlanEkle.Click += btnVarOlanEkle_Click;
            // 
            // miktaritxt
            // 
            miktaritxt.Location = new Point(201, 257);
            miktaritxt.Name = "miktaritxt";
            miktaritxt.Size = new Size(122, 26);
            miktaritxt.TabIndex = 13;
            // 
            // urunAditxt
            // 
            urunAditxt.Location = new Point(201, 219);
            urunAditxt.Name = "urunAditxt";
            urunAditxt.Size = new Size(122, 26);
            urunAditxt.TabIndex = 12;
            // 
            // markatxt
            // 
            markatxt.Location = new Point(201, 181);
            markatxt.Name = "markatxt";
            markatxt.Size = new Size(122, 26);
            markatxt.TabIndex = 11;
            // 
            // kategoritxt
            // 
            kategoritxt.Location = new Point(201, 128);
            kategoritxt.Name = "kategoritxt";
            kategoritxt.Size = new Size(122, 26);
            kategoritxt.TabIndex = 10;
            // 
            // barkodNotxt
            // 
            barkodNotxt.Location = new Point(201, 87);
            barkodNotxt.Name = "barkodNotxt";
            barkodNotxt.Size = new Size(122, 26);
            barkodNotxt.TabIndex = 9;
            barkodNotxt.TextChanged += barkodNotxt_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 431);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(304, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 431);
            panel2.TabIndex = 3;
            // 
            // frmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(639, 431);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Sayfası";
            Load += frmUrunEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox barkodNotxt;
        private TextBox txtSatisFiyati;
        private TextBox txtAlisFiyati;
        private TextBox txtMiktar;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private TextBox miktaritxt;
        private TextBox urunAditxt;
        private TextBox markatxt;
        private TextBox kategoritxt;
        private ComboBox comboMarka;
        private ComboBox comboKategori;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnYeniEkle;
        private Label label7;
        private Label label5;
        private Label label6;
        private Button btnVarOlanEkle;
        private TextBox satisFiaytitxt;
        private TextBox alisFiyatitxt;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnExit;
        private Label lblMiktar;
    }
}