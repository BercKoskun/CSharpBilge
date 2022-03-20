
namespace WFA_GlobalDegisken_SayiTahminOyunu
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTahminSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(12, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(152, 41);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.Location = new System.Drawing.Point(146, 316);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(151, 75);
            this.btnAsagi.TabIndex = 1;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.Location = new System.Drawing.Point(146, 213);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(151, 75);
            this.btnYukari.TabIndex = 2;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(159, 107);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(123, 87);
            this.lblTahmin.TabIndex = 3;
            this.lblTahmin.Text = "00";
            this.lblTahmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(288, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tahmin :";
            // 
            // lblTahminSayisi
            // 
            this.lblTahminSayisi.AutoSize = true;
            this.lblTahminSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminSayisi.Location = new System.Drawing.Point(383, 20);
            this.lblTahminSayisi.Name = "lblTahminSayisi";
            this.lblTahminSayisi.Size = new System.Drawing.Size(23, 25);
            this.lblTahminSayisi.TabIndex = 5;
            this.lblTahminSayisi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Uygulama 0-100 arasında ki bir sayıyı tahmin etmek için çalışır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTahminSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTahminSayisi;
        private System.Windows.Forms.Label label1;
    }
}

