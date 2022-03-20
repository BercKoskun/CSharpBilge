
namespace WFA_MayinTarlasi
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
            this.flpTarla = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMayinSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpTarla
            // 
            this.flpTarla.Location = new System.Drawing.Point(19, 70);
            this.flpTarla.Name = "flpTarla";
            this.flpTarla.Size = new System.Drawing.Size(507, 480);
            this.flpTarla.TabIndex = 0;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(237, 14);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(65, 50);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mayın Sayısı : ";
            // 
            // lblMayinSayisi
            // 
            this.lblMayinSayisi.AutoSize = true;
            this.lblMayinSayisi.Location = new System.Drawing.Point(120, 50);
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Size = new System.Drawing.Size(16, 17);
            this.lblMayinSayisi.TabIndex = 3;
            this.lblMayinSayisi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 559);
            this.Controls.Add(this.lblMayinSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.flpTarla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTarla;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMayinSayisi;
    }
}

