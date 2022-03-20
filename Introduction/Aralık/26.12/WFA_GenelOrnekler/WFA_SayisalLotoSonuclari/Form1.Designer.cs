
namespace WFA_SayisalLotoSonuclari
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
            this.lstSonuclar = new System.Windows.Forms.ListBox();
            this.btnSonucGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSonuclar
            // 
            this.lstSonuclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSonuclar.FormattingEnabled = true;
            this.lstSonuclar.ItemHeight = 25;
            this.lstSonuclar.Location = new System.Drawing.Point(215, 34);
            this.lstSonuclar.Name = "lstSonuclar";
            this.lstSonuclar.Size = new System.Drawing.Size(250, 354);
            this.lstSonuclar.TabIndex = 0;
            // 
            // btnSonucGoster
            // 
            this.btnSonucGoster.Location = new System.Drawing.Point(482, 126);
            this.btnSonucGoster.Name = "btnSonucGoster";
            this.btnSonucGoster.Size = new System.Drawing.Size(105, 129);
            this.btnSonucGoster.TabIndex = 1;
            this.btnSonucGoster.Text = "Sonuc Göster";
            this.btnSonucGoster.UseVisualStyleBackColor = true;
            this.btnSonucGoster.Click += new System.EventHandler(this.btnSonucGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btnSonucGoster);
            this.Controls.Add(this.lstSonuclar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuclar;
        private System.Windows.Forms.Button btnSonucGoster;
    }
}

