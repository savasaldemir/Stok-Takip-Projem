namespace Satış
{
    partial class frmMusteriListeleme
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
            btnGuncelle = new Button();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            txtTcAra = new TextBox();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtAdres);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(txtAdSoyad);
            panel1.Controls.Add(txtTC);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 517);
            panel1.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelle.Location = new Point(127, 391);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(125, 47);
            btnGuncelle.TabIndex = 32;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 336);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 31;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(93, 209);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(158, 121);
            txtAdres.TabIndex = 30;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(93, 180);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(158, 23);
            txtTelefon.TabIndex = 29;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(93, 151);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(158, 23);
            txtAdSoyad.TabIndex = 28;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(93, 122);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(158, 23);
            txtTC.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold);
            label5.Location = new Point(3, 339);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 26;
            label5.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold);
            label4.Location = new Point(2, 212);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 25;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold);
            label3.Location = new Point(2, 183);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 24;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.Location = new Point(2, 154);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 23;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(2, 125);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 22;
            label1.Text = "TC";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(256, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 32);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtTcAra);
            panel3.Controls.Add(btnSil);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(814, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 485);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 30);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 2;
            label6.Text = "TC ARA";
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(6, 53);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(100, 23);
            txtTcAra.TabIndex = 1;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(16, 200);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 32);
            btnSil.TabIndex = 0;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(256, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(558, 485);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // frmMusteriListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(926, 517);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMusteriListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşşteri Listeleme Sayfası";
            Load += frmMusteriListeleme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnGuncelle;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txtTcAra;
        private Button btnSil;
    }
}