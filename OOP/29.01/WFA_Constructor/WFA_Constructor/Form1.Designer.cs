
namespace WFA_Constructor
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
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.cmbRenkler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenkDegistir.Location = new System.Drawing.Point(47, 133);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(271, 77);
            this.btnRenkDegistir.TabIndex = 0;
            this.btnRenkDegistir.Text = "RenkCumbusu Classının Rengini Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // cmbRenkler
            // 
            this.cmbRenkler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRenkler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRenkler.FormattingEnabled = true;
            this.cmbRenkler.Location = new System.Drawing.Point(47, 49);
            this.cmbRenkler.Name = "cmbRenkler";
            this.cmbRenkler.Size = new System.Drawing.Size(271, 39);
            this.cmbRenkler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRenkler);
            this.Controls.Add(this.btnRenkDegistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.ComboBox cmbRenkler;
    }
}

