
namespace WFA_NotHesaplama
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
            this.nudBirinciVize = new System.Windows.Forms.NumericUpDown();
            this.nudIkinciVize = new System.Windows.Forms.NumericUpDown();
            this.nudFinal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.pbDurum = new System.Windows.Forms.PictureBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirinciVize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIkinciVize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBirinciVize
            // 
            this.nudBirinciVize.DecimalPlaces = 1;
            this.nudBirinciVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudBirinciVize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBirinciVize.Location = new System.Drawing.Point(187, 49);
            this.nudBirinciVize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBirinciVize.Name = "nudBirinciVize";
            this.nudBirinciVize.Size = new System.Drawing.Size(86, 34);
            this.nudBirinciVize.TabIndex = 0;
            // 
            // nudIkinciVize
            // 
            this.nudIkinciVize.DecimalPlaces = 1;
            this.nudIkinciVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudIkinciVize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIkinciVize.Location = new System.Drawing.Point(187, 105);
            this.nudIkinciVize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIkinciVize.Name = "nudIkinciVize";
            this.nudIkinciVize.Size = new System.Drawing.Size(86, 34);
            this.nudIkinciVize.TabIndex = 1;
            // 
            // nudFinal
            // 
            this.nudFinal.DecimalPlaces = 1;
            this.nudFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudFinal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFinal.Location = new System.Drawing.Point(187, 157);
            this.nudFinal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFinal.Name = "nudFinal";
            this.nudFinal.Size = new System.Drawing.Size(86, 34);
            this.nudFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.Vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "2.Vize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Final";
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(67, 292);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(206, 48);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "0";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(1, 405);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(274, 95);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDurum
            // 
            this.pbDurum.Location = new System.Drawing.Point(281, 405);
            this.pbDurum.Name = "pbDurum";
            this.pbDurum.Size = new System.Drawing.Size(124, 95);
            this.pbDurum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDurum.TabIndex = 9;
            this.pbDurum.TabStop = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(67, 234);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(206, 55);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 505);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.pbDurum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFinal);
            this.Controls.Add(this.nudIkinciVize);
            this.Controls.Add(this.nudBirinciVize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBirinciVize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIkinciVize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBirinciVize;
        private System.Windows.Forms.NumericUpDown nudIkinciVize;
        private System.Windows.Forms.NumericUpDown nudFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.PictureBox pbDurum;
        private System.Windows.Forms.Button btnHesapla;
    }
}

