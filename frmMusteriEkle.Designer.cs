namespace Satış
{
    partial class frmMusteriEkle
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
            btnExit = new Button();
            button1 = new Button();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(button1);
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 345);
            panel1.TabIndex = 11;
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
            btnExit.Location = new Point(347, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 32);
            btnExit.TabIndex = 22;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(246, 271);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 21;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(136, 129);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(206, 76);
            txtAdres.TabIndex = 19;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(136, 100);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(206, 23);
            txtTelefon.TabIndex = 18;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(136, 71);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(206, 23);
            txtAdSoyad.TabIndex = 17;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(136, 42);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(206, 23);
            txtTC.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold);
            label5.Location = new Point(30, 214);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 15;
            label5.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold);
            label4.Location = new Point(30, 132);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 14;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold);
            label3.Location = new Point(30, 103);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 13;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 12;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 11;
            label1.Text = "TC";
            // 
            // frmMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(390, 345);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Sayfası";
            Load += frmMusteriEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
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
        private Button btnExit;
    }
}