
namespace WFA_BakiyeSorgulama
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
            this.txtParaYatir = new System.Windows.Forms.TextBox();
            this.txtParaCek = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParaYatir
            // 
            this.txtParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaYatir.Location = new System.Drawing.Point(40, 74);
            this.txtParaYatir.Name = "txtParaYatir";
            this.txtParaYatir.Size = new System.Drawing.Size(178, 30);
            this.txtParaYatir.TabIndex = 0;
            // 
            // txtParaCek
            // 
            this.txtParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaCek.Location = new System.Drawing.Point(40, 146);
            this.txtParaCek.Name = "txtParaCek";
            this.txtParaCek.Size = new System.Drawing.Size(178, 30);
            this.txtParaCek.TabIndex = 1;
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(250, 71);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(128, 36);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(250, 140);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(128, 36);
            this.btnParaCek.TabIndex = 3;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(503, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bakiye :";
            // 
            // lblBakiye
            // 
            this.lblBakiye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(612, 9);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(155, 56);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "0";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.Maroon;
            this.lblDurum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDurum.Location = new System.Drawing.Point(0, 324);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(1000, 256);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.txtParaCek);
            this.Controls.Add(this.txtParaYatir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParaYatir;
        private System.Windows.Forms.TextBox txtParaCek;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblDurum;
    }
}

