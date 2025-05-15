namespace Satış
{
    partial class frmUrunListele
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
            panel1 = new Panel();
            btnMarkaGuncelle = new Button();
            label2 = new Label();
            label3 = new Label();
            comboMarka = new ComboBox();
            comboKategori = new ComboBox();
            satisFiaytitxt = new TextBox();
            alisFiyatitxt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnGuncelle = new Button();
            miktaritxt = new TextBox();
            urunAditxt = new TextBox();
            markatxt = new TextBox();
            kategoritxt = new TextBox();
            barkodNotxt = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            txtBarkodNoAra = new TextBox();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMarkaGuncelle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboMarka);
            panel1.Controls.Add(comboKategori);
            panel1.Controls.Add(satisFiaytitxt);
            panel1.Controls.Add(alisFiyatitxt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(miktaritxt);
            panel1.Controls.Add(urunAditxt);
            panel1.Controls.Add(markatxt);
            panel1.Controls.Add(kategoritxt);
            panel1.Controls.Add(barkodNotxt);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 533);
            panel1.TabIndex = 0;
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.FlatAppearance.BorderSize = 0;
            btnMarkaGuncelle.FlatAppearance.MouseDownBackColor = Color.Red;
            btnMarkaGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMarkaGuncelle.FlatStyle = FlatStyle.Flat;
            btnMarkaGuncelle.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkaGuncelle.Location = new Point(147, 469);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(122, 52);
            btnMarkaGuncelle.TabIndex = 45;
            btnMarkaGuncelle.Text = "MARKA GÜNCELLE";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label2.Location = new Point(46, 430);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 44;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label3.Location = new Point(27, 377);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 43;
            label3.Text = "Kategori";
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(147, 425);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(122, 23);
            comboMarka.TabIndex = 42;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(147, 377);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(122, 23);
            comboKategori.TabIndex = 41;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // satisFiaytitxt
            // 
            satisFiaytitxt.Location = new Point(147, 305);
            satisFiaytitxt.Name = "satisFiaytitxt";
            satisFiaytitxt.Size = new Size(122, 23);
            satisFiaytitxt.TabIndex = 40;
            // 
            // alisFiyatitxt
            // 
            alisFiyatitxt.Location = new Point(147, 267);
            alisFiyatitxt.Name = "alisFiyatitxt";
            alisFiyatitxt.Size = new Size(122, 23);
            alisFiyatitxt.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label8.Location = new Point(4, 305);
            label8.Name = "label8";
            label8.Size = new Size(101, 18);
            label8.TabIndex = 38;
            label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label9.Location = new Point(42, 229);
            label9.Name = "label9";
            label9.Size = new Size(63, 18);
            label9.TabIndex = 37;
            label9.Text = "Miktar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label10.Location = new Point(12, 267);
            label10.Name = "label10";
            label10.Size = new Size(93, 18);
            label10.TabIndex = 36;
            label10.Text = "Alış Fiyatı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label11.Location = new Point(46, 153);
            label11.Name = "label11";
            label11.Size = new Size(59, 18);
            label11.TabIndex = 35;
            label11.Text = "Marka";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label12.Location = new Point(23, 191);
            label12.Name = "label12";
            label12.Size = new Size(82, 18);
            label12.TabIndex = 34;
            label12.Text = "Ürün Adı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label13.Location = new Point(27, 100);
            label13.Name = "label13";
            label13.Size = new Size(78, 18);
            label13.TabIndex = 33;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 11.25F, FontStyle.Bold);
            label14.Location = new Point(12, 62);
            label14.Name = "label14";
            label14.Size = new Size(93, 18);
            label14.TabIndex = 32;
            label14.Text = "Barkod No";
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatAppearance.MouseDownBackColor = Color.Red;
            btnGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelle.Location = new Point(147, 334);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 34);
            btnGuncelle.TabIndex = 31;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // miktaritxt
            // 
            miktaritxt.Location = new Point(147, 229);
            miktaritxt.Name = "miktaritxt";
            miktaritxt.Size = new Size(122, 23);
            miktaritxt.TabIndex = 30;
            // 
            // urunAditxt
            // 
            urunAditxt.Location = new Point(147, 191);
            urunAditxt.Name = "urunAditxt";
            urunAditxt.Size = new Size(122, 23);
            urunAditxt.TabIndex = 29;
            // 
            // markatxt
            // 
            markatxt.Location = new Point(147, 153);
            markatxt.Name = "markatxt";
            markatxt.ReadOnly = true;
            markatxt.Size = new Size(122, 23);
            markatxt.TabIndex = 28;
            // 
            // kategoritxt
            // 
            kategoritxt.Location = new Point(147, 100);
            kategoritxt.Name = "kategoritxt";
            kategoritxt.ReadOnly = true;
            kategoritxt.Size = new Size(122, 23);
            kategoritxt.TabIndex = 27;
            // 
            // barkodNotxt
            // 
            barkodNotxt.Location = new Point(147, 59);
            barkodNotxt.Name = "barkodNotxt";
            barkodNotxt.Size = new Size(122, 23);
            barkodNotxt.TabIndex = 26;
            barkodNotxt.TextChanged += barkodNotxt_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(281, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 533);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtBarkodNoAra);
            panel3.Controls.Add(btnSil);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(555, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 533);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 59);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Barkoda Göre Arama";
            // 
            // txtBarkodNoAra
            // 
            txtBarkodNoAra.Location = new Point(11, 81);
            txtBarkodNoAra.Name = "txtBarkodNoAra";
            txtBarkodNoAra.Size = new Size(100, 23);
            txtBarkodNoAra.TabIndex = 1;
            txtBarkodNoAra.TextChanged += txtBarkodNoAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(11, 136);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 0;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(691, 533);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // frmUrunListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(972, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUrunListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Sayfası";
            Load += frmUrunListele_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox satisFiaytitxt;
        private TextBox alisFiyatitxt;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnGuncelle;
        private TextBox miktaritxt;
        private TextBox urunAditxt;
        private TextBox markatxt;
        private TextBox kategoritxt;
        private TextBox barkodNotxt;
        private Panel panel3;
        private Label label1;
        private TextBox txtBarkodNoAra;
        private Button btnSil;
        private Label label2;
        private Label label3;
        private ComboBox comboMarka;
        private ComboBox comboKategori;
        private Button btnMarkaGuncelle;
    }
}