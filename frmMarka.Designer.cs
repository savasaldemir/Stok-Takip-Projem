﻿namespace Satış
{
    partial class frmMarka
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 120);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Marka";
            // 
            // button1
            // 
            button1.Location = new Point(164, 160);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            btnExit.Location = new Point(234, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 32);
            btnExit.TabIndex = 23;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMarka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(277, 217);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marka Sayfası";
            Load += frmMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button btnExit;
    }
}