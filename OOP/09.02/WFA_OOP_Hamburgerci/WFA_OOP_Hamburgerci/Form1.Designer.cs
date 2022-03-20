
namespace WFA_OOP_Hamburgerci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnSiparisAl = new System.Windows.Forms.Button();
            this.nuAdet = new System.Windows.Forms.NumericUpDown();
            this.gbEkstralar = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbKing = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).BeginInit();
            this.gbEkstralar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 66);
            this.label4.TabIndex = 23;
            this.label4.Text = "Orta: Normal Menu Fiyati , Buyuk: Menu Fiyati + 2.00TL,King: Menu Fiyati + 3.00TL" +
    "";
            // 
            // btnHesap
            // 
            this.btnHesap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(474, 492);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(102, 28);
            this.btnHesap.TabIndex = 21;
            this.btnHesap.Text = "Hesap";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnSiparisAl
            // 
            this.btnSiparisAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiparisAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisAl.Location = new System.Drawing.Point(366, 492);
            this.btnSiparisAl.Name = "btnSiparisAl";
            this.btnSiparisAl.Size = new System.Drawing.Size(102, 28);
            this.btnSiparisAl.TabIndex = 22;
            this.btnSiparisAl.Text = "Siparis Al";
            this.btnSiparisAl.UseVisualStyleBackColor = true;
            this.btnSiparisAl.Click += new System.EventHandler(this.btnSiparisAl_Click);
            // 
            // nuAdet
            // 
            this.nuAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuAdet.Location = new System.Drawing.Point(95, 443);
            this.nuAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAdet.Name = "nuAdet";
            this.nuAdet.Size = new System.Drawing.Size(74, 24);
            this.nuAdet.TabIndex = 20;
            this.nuAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbEkstralar
            // 
            this.gbEkstralar.Controls.Add(this.checkBox6);
            this.gbEkstralar.Controls.Add(this.checkBox3);
            this.gbEkstralar.Controls.Add(this.checkBox5);
            this.gbEkstralar.Controls.Add(this.checkBox2);
            this.gbEkstralar.Controls.Add(this.checkBox4);
            this.gbEkstralar.Controls.Add(this.checkBox1);
            this.gbEkstralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbEkstralar.Location = new System.Drawing.Point(36, 323);
            this.gbEkstralar.Name = "gbEkstralar";
            this.gbEkstralar.Size = new System.Drawing.Size(269, 117);
            this.gbEkstralar.TabIndex = 19;
            this.gbEkstralar.TabStop = false;
            this.gbEkstralar.Text = "Ekstralar";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(166, 79);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(77, 22);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Kivircik";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 22);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Aci Sos";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(166, 51);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(73, 22);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Hardal";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 22);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Tursu";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(166, 23);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 22);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Peynir";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Domates";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbKing
            // 
            this.rbKing.AutoSize = true;
            this.rbKing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKing.Location = new System.Drawing.Point(238, 295);
            this.rbKing.Name = "rbKing";
            this.rbKing.Size = new System.Drawing.Size(58, 22);
            this.rbKing.TabIndex = 16;
            this.rbKing.TabStop = true;
            this.rbKing.Text = "King";
            this.rbKing.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBuyuk.Location = new System.Drawing.Point(160, 295);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(70, 22);
            this.rbBuyuk.TabIndex = 17;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Buyuk";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOrta.Location = new System.Drawing.Point(95, 295);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(58, 22);
            this.rbOrta.TabIndex = 18;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Boyut:";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(91, 256);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(269, 26);
            this.cmbMenuler.TabIndex = 13;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menu:";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 18;
            this.lstSiparisler.Location = new System.Drawing.Point(366, 32);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(475, 454);
            this.lstSiparisler.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnSiparisAl);
            this.Controls.Add(this.nuAdet);
            this.Controls.Add(this.gbEkstralar);
            this.Controls.Add(this.rbKing);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).EndInit();
            this.gbEkstralar.ResumeLayout(false);
            this.gbEkstralar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnSiparisAl;
        private System.Windows.Forms.NumericUpDown nuAdet;
        private System.Windows.Forms.GroupBox gbEkstralar;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbKing;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

