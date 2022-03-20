
namespace WFA_OutPameter
{
    partial class Form2
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
            this.btnOutUc = new System.Windows.Forms.Button();
            this.btnOutIki = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOutUc
            // 
            this.btnOutUc.Location = new System.Drawing.Point(13, 126);
            this.btnOutUc.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutUc.Name = "btnOutUc";
            this.btnOutUc.Size = new System.Drawing.Size(441, 49);
            this.btnOutUc.TabIndex = 24;
            this.btnOutUc.Text = "OUT ANAHTAR KELİMESİ (ÖRNEK ÜÇ)";
            this.btnOutUc.UseVisualStyleBackColor = true;
            // 
            // btnOutIki
            // 
            this.btnOutIki.Location = new System.Drawing.Point(13, 69);
            this.btnOutIki.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutIki.Name = "btnOutIki";
            this.btnOutIki.Size = new System.Drawing.Size(441, 49);
            this.btnOutIki.TabIndex = 23;
            this.btnOutIki.Text = "OUT ANAHTAR KELİMESİ (ÖRNEK İKİ)";
            this.btnOutIki.UseVisualStyleBackColor = true;
            this.btnOutIki.Click += new System.EventHandler(this.btnOutIki_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(13, 13);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(441, 49);
            this.btnOut.TabIndex = 21;
            this.btnOut.Text = "OUT ANAHTAR KELİMESİ";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Hakkari",
            "Diyarbakır",
            "Şırnak",
            "Trabzon",
            "Muğla"});
            this.listBox1.Location = new System.Drawing.Point(483, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 516);
            this.listBox1.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 558);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOutUc);
            this.Controls.Add(this.btnOutIki);
            this.Controls.Add(this.btnOut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOutUc;
        private System.Windows.Forms.Button btnOutIki;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ListBox listBox1;
    }
}