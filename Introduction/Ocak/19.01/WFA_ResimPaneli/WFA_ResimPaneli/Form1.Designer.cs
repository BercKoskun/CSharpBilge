
namespace WFA_ResimPaneli
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnIlk = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnSlayt = new System.Windows.Forms.Button();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 481);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(167, 12);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(838, 436);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 1;
            this.pbResim.TabStop = false;
            // 
            // btnIlk
            // 
            this.btnIlk.Location = new System.Drawing.Point(184, 454);
            this.btnIlk.Name = "btnIlk";
            this.btnIlk.Size = new System.Drawing.Size(66, 45);
            this.btnIlk.TabIndex = 2;
            this.btnIlk.Text = "<<";
            this.btnIlk.UseVisualStyleBackColor = true;
            this.btnIlk.Click += new System.EventHandler(this.btnIlk_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(256, 454);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(66, 45);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(939, 454);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(66, 45);
            this.btnSon.TabIndex = 5;
            this.btnSon.Text = ">>";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(858, 454);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(66, 45);
            this.btnIleri.TabIndex = 4;
            this.btnIleri.Text = ">";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnSlayt
            // 
            this.btnSlayt.Location = new System.Drawing.Point(583, 454);
            this.btnSlayt.Name = "btnSlayt";
            this.btnSlayt.Size = new System.Drawing.Size(253, 45);
            this.btnSlayt.TabIndex = 7;
            this.btnSlayt.Text = "Slayt Gösterisi";
            this.btnSlayt.UseVisualStyleBackColor = true;
            this.btnSlayt.Click += new System.EventHandler(this.btnSlayt_Click);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(343, 454);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(217, 45);
            this.btnRastgele.TabIndex = 6;
            this.btnRastgele.Text = "Rastgele Resim Seç";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 505);
            this.Controls.Add(this.btnSlayt);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIlk);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnIlk;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnSlayt;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Timer timer1;
    }
}

