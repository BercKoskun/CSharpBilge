
namespace WFA_GenelOrnekler
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
            this.components = new System.ComponentModel.Container();
            this.cmbKisiler = new System.Windows.Forms.ComboBox();
            this.cmbStandart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbKisiler
            // 
            this.cmbKisiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKisiler.FormattingEnabled = true;
            this.cmbKisiler.Items.AddRange(new object[] {
            "Rıdvan",
            "Kürşat",
            "Emre",
            "Gözde",
            "Cemil",
            "Rüstem"});
            this.cmbKisiler.Location = new System.Drawing.Point(42, 50);
            this.cmbKisiler.Name = "cmbKisiler";
            this.cmbKisiler.Size = new System.Drawing.Size(166, 24);
            this.cmbKisiler.TabIndex = 0;
            this.cmbKisiler.SelectedIndexChanged += new System.EventHandler(this.cmbKisiler_SelectedIndexChanged);
            // 
            // cmbStandart
            // 
            this.cmbStandart.FormattingEnabled = true;
            this.cmbStandart.Items.AddRange(new object[] {
            "Rıdvan",
            "Kürşat",
            "Emre",
            "Gözde",
            "Cemil",
            "Rüstem"});
            this.cmbStandart.Location = new System.Drawing.Point(256, 50);
            this.cmbStandart.Name = "cmbStandart";
            this.cmbStandart.Size = new System.Drawing.Size(181, 24);
            this.cmbStandart.TabIndex = 1;
            this.cmbStandart.Text = "Urun Seçiniz...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seçili Elemanı Ekranda Gösterme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Son Elemanı Seçme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Elemanları Silme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Text seçme özelliği";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(271, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "Text seçme özelliği";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(271, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "Elemanları Silme";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(271, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 44);
            this.button9.TabIndex = 8;
            this.button9.Text = "Son Elemanı Seçme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(271, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 44);
            this.button10.TabIndex = 7;
            this.button10.Text = "Seçili Elemanı Ekranda Gösterme";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(42, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(166, 44);
            this.button11.TabIndex = 12;
            this.button11.Text = "Eleman Ekle";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "Araya eleman ekleme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(500, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 468);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbStandart);
            this.Controls.Add(this.cmbKisiler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKisiler;
        private System.Windows.Forms.ComboBox cmbStandart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

