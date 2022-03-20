
namespace WFA_MasaUstuUygulamalar
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
            this.txtHarfKutusu = new System.Windows.Forms.TextBox();
            this.lblHarfSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHarfKutusu
            // 
            this.txtHarfKutusu.Location = new System.Drawing.Point(159, 12);
            this.txtHarfKutusu.Multiline = true;
            this.txtHarfKutusu.Name = "txtHarfKutusu";
            this.txtHarfKutusu.Size = new System.Drawing.Size(250, 169);
            this.txtHarfKutusu.TabIndex = 0;
            this.txtHarfKutusu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHarfSayisi
            // 
            this.lblHarfSayisi.AutoSize = true;
            this.lblHarfSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarfSayisi.Location = new System.Drawing.Point(315, 197);
            this.lblHarfSayisi.Name = "lblHarfSayisi";
            this.lblHarfSayisi.Size = new System.Drawing.Size(45, 25);
            this.lblHarfSayisi.TabIndex = 1;
            this.lblHarfSayisi.Text = "280";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(156, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Karakter :";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(788, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHarfSayisi);
            this.Controls.Add(this.txtHarfKutusu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox txtHarfKutusu;
        private System.Windows.Forms.Label lblHarfSayisi;
        private System.Windows.Forms.Label label3;
    }
}

