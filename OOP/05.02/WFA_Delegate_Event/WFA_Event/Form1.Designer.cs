
namespace WFA_Event
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
            this.btnGazla = new System.Windows.Forms.Button();
            this.lstHizGostergesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGazla
            // 
            this.btnGazla.Location = new System.Drawing.Point(151, 24);
            this.btnGazla.Name = "btnGazla";
            this.btnGazla.Size = new System.Drawing.Size(220, 68);
            this.btnGazla.TabIndex = 0;
            this.btnGazla.Text = "Gazla";
            this.btnGazla.UseVisualStyleBackColor = true;
            this.btnGazla.Click += new System.EventHandler(this.btnGazla_Click);
            // 
            // lstHizGostergesi
            // 
            this.lstHizGostergesi.FormattingEnabled = true;
            this.lstHizGostergesi.ItemHeight = 16;
            this.lstHizGostergesi.Location = new System.Drawing.Point(127, 98);
            this.lstHizGostergesi.Name = "lstHizGostergesi";
            this.lstHizGostergesi.Size = new System.Drawing.Size(267, 308);
            this.lstHizGostergesi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.lstHizGostergesi);
            this.Controls.Add(this.btnGazla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGazla;
        private System.Windows.Forms.ListBox lstHizGostergesi;
    }
}

