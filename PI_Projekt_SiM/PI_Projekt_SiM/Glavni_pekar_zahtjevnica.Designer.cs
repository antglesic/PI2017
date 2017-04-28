namespace PI_Projekt_SiM
{
    partial class Glavni_pekar_zahtjevnica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajSirovinuBtn = new System.Windows.Forms.Button();
            this.posaljiPopisBtn = new System.Windows.Forms.Button();
            this.popisNarudzbenica = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dodajSirovinuBtn);
            this.groupBox1.Controls.Add(this.posaljiPopisBtn);
            this.groupBox1.Controls.Add(this.popisNarudzbenica);
            this.groupBox1.Location = new System.Drawing.Point(96, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 545);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahtjevnica";
            // 
            // dodajSirovinuBtn
            // 
            this.dodajSirovinuBtn.Location = new System.Drawing.Point(254, 99);
            this.dodajSirovinuBtn.Name = "dodajSirovinuBtn";
            this.dodajSirovinuBtn.Size = new System.Drawing.Size(151, 23);
            this.dodajSirovinuBtn.TabIndex = 16;
            this.dodajSirovinuBtn.Text = "Dodaj sirovinu";
            this.dodajSirovinuBtn.UseVisualStyleBackColor = true;
            // 
            // posaljiPopisBtn
            // 
            this.posaljiPopisBtn.Location = new System.Drawing.Point(294, 501);
            this.posaljiPopisBtn.Name = "posaljiPopisBtn";
            this.posaljiPopisBtn.Size = new System.Drawing.Size(151, 23);
            this.posaljiPopisBtn.TabIndex = 15;
            this.posaljiPopisBtn.Text = "Posalji";
            this.posaljiPopisBtn.UseVisualStyleBackColor = true;
            this.posaljiPopisBtn.Click += new System.EventHandler(this.posaljiPopisBtn_Click);
            // 
            // popisNarudzbenica
            // 
            this.popisNarudzbenica.FormattingEnabled = true;
            this.popisNarudzbenica.Location = new System.Drawing.Point(25, 155);
            this.popisNarudzbenica.Name = "popisNarudzbenica";
            this.popisNarudzbenica.Size = new System.Drawing.Size(658, 329);
            this.popisNarudzbenica.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kolicina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sirovine:";
            // 
            // Glavni_pekar_zahtjevnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 584);
            this.Controls.Add(this.groupBox1);
            this.Name = "Glavni_pekar_zahtjevnica";
            this.Text = "Glavni_pekar_zahtjevnica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button dodajSirovinuBtn;
        private System.Windows.Forms.Button posaljiPopisBtn;
        private System.Windows.Forms.ListBox popisNarudzbenica;

    }
}