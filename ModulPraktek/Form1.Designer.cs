namespace ModulPraktek
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblberatb = new Label();
            lblusia = new Label();
            lbltinggi = new Label();
            logo = new Button();
            txtberat = new TextBox();
            logo1 = new Button();
            txtusia = new TextBox();
            logo2 = new Button();
            txttinggi = new TextBox();
            btnhitung = new Button();
            label1 = new Label();
            btnreset = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txthasil = new TextBox();
            lblhasil = new Label();
            lblket1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblberatb
            // 
            lblberatb.AutoSize = true;
            lblberatb.Font = new Font("Inter Semi Bold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblberatb.Location = new Point(24, 106);
            lblberatb.Name = "lblberatb";
            lblberatb.Size = new Size(139, 19);
            lblberatb.TabIndex = 3;
            lblberatb.Text = "Berat Badan (kg)";
            // 
            // lblusia
            // 
            lblusia.AutoSize = true;
            lblusia.Font = new Font("Inter Semi Bold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblusia.Location = new Point(24, 201);
            lblusia.Name = "lblusia";
            lblusia.Size = new Size(104, 19);
            lblusia.TabIndex = 4;
            lblusia.Text = "Usia (tahun)";
            // 
            // lbltinggi
            // 
            lbltinggi.AutoSize = true;
            lbltinggi.Font = new Font("Inter Semi Bold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbltinggi.Location = new Point(24, 284);
            lbltinggi.Name = "lbltinggi";
            lbltinggi.Size = new Size(149, 19);
            lbltinggi.TabIndex = 5;
            lbltinggi.Text = "Tinggi badan (cm)";
            // 
            // logo
            // 
            logo.BackgroundImage = Properties.Resources.pen;
            logo.BackgroundImageLayout = ImageLayout.None;
            logo.FlatStyle = FlatStyle.Popup;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(24, 147);
            logo.Name = "logo";
            logo.Size = new Size(41, 40);
            logo.TabIndex = 6;
            logo.UseVisualStyleBackColor = true;
            // 
            // txtberat
            // 
            txtberat.Location = new Point(52, 66);
            txtberat.Multiline = true;
            txtberat.Name = "txtberat";
            txtberat.Size = new Size(173, 40);
            txtberat.TabIndex = 7;
            // 
            // logo1
            // 
            logo1.FlatStyle = FlatStyle.Popup;
            logo1.Image = Properties.Resources.pen__2_;
            logo1.Location = new Point(24, 229);
            logo1.Name = "logo1";
            logo1.Size = new Size(41, 40);
            logo1.TabIndex = 8;
            logo1.UseVisualStyleBackColor = true;
            // 
            // txtusia
            // 
            txtusia.Location = new Point(52, 148);
            txtusia.Multiline = true;
            txtusia.Name = "txtusia";
            txtusia.Size = new Size(173, 40);
            txtusia.TabIndex = 9;
            txtusia.TextChanged += txtusia_TextChanged;
            // 
            // logo2
            // 
            logo2.FlatStyle = FlatStyle.Popup;
            logo2.Image = Properties.Resources.pen__2_;
            logo2.Location = new Point(24, 316);
            logo2.Name = "logo2";
            logo2.Size = new Size(41, 40);
            logo2.TabIndex = 10;
            logo2.UseVisualStyleBackColor = true;
            // 
            // txttinggi
            // 
            txttinggi.Location = new Point(52, 235);
            txttinggi.Multiline = true;
            txttinggi.Name = "txttinggi";
            txttinggi.Size = new Size(173, 40);
            txttinggi.TabIndex = 11;
            txttinggi.TextChanged += txttinggi_TextChanged;
            // 
            // btnhitung
            // 
            btnhitung.BackColor = Color.DeepSkyBlue;
            btnhitung.Font = new Font("Inter Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnhitung.ForeColor = Color.LavenderBlush;
            btnhitung.Location = new Point(24, 380);
            btnhitung.Name = "btnhitung";
            btnhitung.Size = new Size(124, 35);
            btnhitung.TabIndex = 12;
            btnhitung.Text = "Hitung BMI";
            btnhitung.UseVisualStyleBackColor = false;
            btnhitung.Click += btnhitung_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 167);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 13;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Transparent;
            btnreset.FlatStyle = FlatStyle.System;
            btnreset.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnreset.ForeColor = Color.White;
            btnreset.Location = new Point(154, 380);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(84, 35);
            btnreset.TabIndex = 14;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 293);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 15;
            label2.Text = "*Keterangan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 319);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 16;
            label3.Text = "Kurus: IMT kurang dari 18,5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 344);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 17;
            label4.Text = "Normal: 18,5 – 22,9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 369);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 18;
            label5.Text = "Overweight: 23 - 27,5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 394);
            label7.Name = "label7";
            label7.Size = new Size(196, 20);
            label7.TabIndex = 20;
            label7.Text = "Obesitas: IMT lebih dari 27,5";
            // 
            // txthasil
            // 
            txthasil.Location = new Point(306, 147);
            txthasil.Multiline = true;
            txthasil.Name = "txthasil";
            txthasil.ReadOnly = true;
            txthasil.Size = new Size(219, 40);
            txthasil.TabIndex = 21;
            // 
            // lblhasil
            // 
            lblhasil.AutoSize = true;
            lblhasil.BackColor = Color.Transparent;
            lblhasil.Font = new Font("Inter Semi Bold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblhasil.Location = new Point(306, 106);
            lblhasil.Name = "lblhasil";
            lblhasil.Size = new Size(81, 19);
            lblhasil.TabIndex = 22;
            lblhasil.Text = "Hasil BMI";
            lblhasil.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblket1
            // 
            lblket1.AutoSize = true;
            lblket1.Location = new Point(306, 201);
            lblket1.Name = "lblket1";
            lblket1.Size = new Size(0, 20);
            lblket1.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter Semi Bold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 31);
            label6.Name = "label6";
            label6.Size = new Size(301, 20);
            label6.TabIndex = 24;
            label6.Text = "Menghitung BMI (Body Mass Index)";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtberat);
            panel1.Controls.Add(txtusia);
            panel1.Controls.Add(txttinggi);
            panel1.Location = new Point(12, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 392);
            panel1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 503);
            Controls.Add(label6);
            Controls.Add(lblket1);
            Controls.Add(lblhasil);
            Controls.Add(txthasil);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnreset);
            Controls.Add(label1);
            Controls.Add(btnhitung);
            Controls.Add(logo2);
            Controls.Add(logo1);
            Controls.Add(logo);
            Controls.Add(lbltinggi);
            Controls.Add(lblusia);
            Controls.Add(lblberatb);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENGITUNG BMI ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblberatb;
        private Label lblusia;
        private Label lbltinggi;
        private Button logo;
        private TextBox txtberat;
        private Button logo1;
        private TextBox txtusia;
        private Button logo2;
        private TextBox txttinggi;
        private Button btnhitung;
        private Label label1;
        private Button btnreset;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txthasil;
        private Label lblhasil;
        private Label lblket1;
        private Label label6;
        private Panel panel1;
    }
}