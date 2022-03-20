
namespace WFA_YemekSepeti
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
            this.btnHesap = new System.Windows.Forms.Button();
            this.nudIkinci = new System.Windows.Forms.NumericUpDown();
            this.nudBirinci = new System.Windows.Forms.NumericUpDown();
            this.cmbIkinciYemek = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBirinciYemek = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIkinci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirinci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(79, 295);
            this.btnHesap.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(469, 69);
            this.btnHesap.TabIndex = 21;
            this.btnHesap.Text = "HESAP ÇEK";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // nudIkinci
            // 
            this.nudIkinci.DecimalPlaces = 1;
            this.nudIkinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudIkinci.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudIkinci.Location = new System.Drawing.Point(452, 194);
            this.nudIkinci.Margin = new System.Windows.Forms.Padding(4);
            this.nudIkinci.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIkinci.Name = "nudIkinci";
            this.nudIkinci.Size = new System.Drawing.Size(97, 30);
            this.nudIkinci.TabIndex = 19;
            this.nudIkinci.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBirinci
            // 
            this.nudBirinci.DecimalPlaces = 1;
            this.nudBirinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudBirinci.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudBirinci.Location = new System.Drawing.Point(451, 63);
            this.nudBirinci.Margin = new System.Windows.Forms.Padding(4);
            this.nudBirinci.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirinci.Name = "nudBirinci";
            this.nudBirinci.Size = new System.Drawing.Size(97, 30);
            this.nudBirinci.TabIndex = 20;
            this.nudBirinci.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbIkinciYemek
            // 
            this.cmbIkinciYemek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIkinciYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIkinciYemek.FormattingEnabled = true;
            this.cmbIkinciYemek.Location = new System.Drawing.Point(79, 194);
            this.cmbIkinciYemek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIkinciYemek.Name = "cmbIkinciYemek";
            this.cmbIkinciYemek.Size = new System.Drawing.Size(295, 33);
            this.cmbIkinciYemek.TabIndex = 17;
            this.cmbIkinciYemek.SelectedIndexChanged += new System.EventHandler(this.cmbIkinciYemek_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(447, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Porsiyon :";
            // 
            // cmbBirinciYemek
            // 
            this.cmbBirinciYemek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirinciYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBirinciYemek.FormattingEnabled = true;
            this.cmbBirinciYemek.Location = new System.Drawing.Point(78, 63);
            this.cmbBirinciYemek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBirinciYemek.Name = "cmbBirinciYemek";
            this.cmbBirinciYemek.Size = new System.Drawing.Size(295, 33);
            this.cmbBirinciYemek.TabIndex = 18;
            this.cmbBirinciYemek.SelectedIndexChanged += new System.EventHandler(this.cmbBirinciYemek_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "İkinci Yemek :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(446, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Porsiyon :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Birinci Yemek :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.nudIkinci);
            this.Controls.Add(this.nudBirinci);
            this.Controls.Add(this.cmbIkinciYemek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBirinciYemek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIkinci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.NumericUpDown nudIkinci;
        private System.Windows.Forms.NumericUpDown nudBirinci;
        private System.Windows.Forms.ComboBox cmbIkinciYemek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBirinciYemek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

