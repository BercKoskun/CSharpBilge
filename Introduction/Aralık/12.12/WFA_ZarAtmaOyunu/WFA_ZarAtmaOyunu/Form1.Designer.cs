
namespace WFA_ZarAtmaOyunu
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
            this.lblZarBir = new System.Windows.Forms.Label();
            this.lblZarIki = new System.Windows.Forms.Label();
            this.btnZarAt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblZarBir
            // 
            this.lblZarBir.AutoSize = true;
            this.lblZarBir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblZarBir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZarBir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblZarBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZarBir.Location = new System.Drawing.Point(85, 34);
            this.lblZarBir.Name = "lblZarBir";
            this.lblZarBir.Size = new System.Drawing.Size(62, 67);
            this.lblZarBir.TabIndex = 0;
            this.lblZarBir.Text = "0";
            this.lblZarBir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZarIki
            // 
            this.lblZarIki.AutoSize = true;
            this.lblZarIki.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblZarIki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZarIki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblZarIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZarIki.Location = new System.Drawing.Point(195, 34);
            this.lblZarIki.Name = "lblZarIki";
            this.lblZarIki.Size = new System.Drawing.Size(62, 67);
            this.lblZarIki.TabIndex = 1;
            this.lblZarIki.Text = "0";
            this.lblZarIki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZarAt
            // 
            this.btnZarAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZarAt.Location = new System.Drawing.Point(85, 128);
            this.btnZarAt.Name = "btnZarAt";
            this.btnZarAt.Size = new System.Drawing.Size(172, 53);
            this.btnZarAt.TabIndex = 2;
            this.btnZarAt.Text = "Zar At";
            this.btnZarAt.UseVisualStyleBackColor = true;
            this.btnZarAt.Click += new System.EventHandler(this.btnZarAt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 215);
            this.Controls.Add(this.btnZarAt);
            this.Controls.Add(this.lblZarIki);
            this.Controls.Add(this.lblZarBir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZarBir;
        private System.Windows.Forms.Label lblZarIki;
        private System.Windows.Forms.Button btnZarAt;
        private System.Windows.Forms.Timer timer1;
    }
}

