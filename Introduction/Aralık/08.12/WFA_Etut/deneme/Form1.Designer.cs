
namespace WFA_Etut
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
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnArti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGlobalText = new System.Windows.Forms.TextBox();
            this.btnGlobalArti = new System.Windows.Forms.Button();
            this.btnGlonalEksi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEksi
            // 
            this.btnEksi.Location = new System.Drawing.Point(19, 49);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(123, 48);
            this.btnEksi.TabIndex = 0;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = true;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnArti
            // 
            this.btnArti.Location = new System.Drawing.Point(378, 49);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(123, 48);
            this.btnArti.TabIndex = 1;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSayi);
            this.groupBox1.Controls.Add(this.btnArti);
            this.groupBox1.Controls.Add(this.btnEksi);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Değişken  Olmadan";
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.Location = new System.Drawing.Point(180, 62);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(148, 30);
            this.txtSayi.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGlobalText);
            this.groupBox2.Controls.Add(this.btnGlobalArti);
            this.groupBox2.Controls.Add(this.btnGlonalEksi);
            this.groupBox2.Location = new System.Drawing.Point(26, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Değişken  Kullanarak";
            // 
            // txtGlobalText
            // 
            this.txtGlobalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGlobalText.Location = new System.Drawing.Point(180, 62);
            this.txtGlobalText.Name = "txtGlobalText";
            this.txtGlobalText.Size = new System.Drawing.Size(148, 30);
            this.txtGlobalText.TabIndex = 2;
            // 
            // btnGlobalArti
            // 
            this.btnGlobalArti.Location = new System.Drawing.Point(378, 49);
            this.btnGlobalArti.Name = "btnGlobalArti";
            this.btnGlobalArti.Size = new System.Drawing.Size(123, 48);
            this.btnGlobalArti.TabIndex = 1;
            this.btnGlobalArti.Text = "+";
            this.btnGlobalArti.UseVisualStyleBackColor = true;
            this.btnGlobalArti.Click += new System.EventHandler(this.btnGlobalArti_Click);
            // 
            // btnGlonalEksi
            // 
            this.btnGlonalEksi.Location = new System.Drawing.Point(19, 49);
            this.btnGlonalEksi.Name = "btnGlonalEksi";
            this.btnGlonalEksi.Size = new System.Drawing.Size(123, 48);
            this.btnGlonalEksi.TabIndex = 0;
            this.btnGlonalEksi.Text = "-";
            this.btnGlonalEksi.UseVisualStyleBackColor = true;
            this.btnGlonalEksi.Click += new System.EventHandler(this.btnGlonalEksi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(585, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Üzerinden Deger Okumak";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(180, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGlobalText;
        private System.Windows.Forms.Button btnGlobalArti;
        private System.Windows.Forms.Button btnGlonalEksi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

