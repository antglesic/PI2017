namespace PI_Projekt_SiM
{
    partial class frmSkladistar_racun_otpremnica_popis
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
            this.skladisteBtn = new System.Windows.Forms.Button();
            this.racuniOtpremniceBtn = new System.Windows.Forms.Button();
            this.zahtjevniceBtn = new System.Windows.Forms.Button();
            this.primkeBtn = new System.Windows.Forms.Button();
            this.porukeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.popisRacunaOtpremnica = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kreirajPrimkuBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skladisteBtn
            // 
            this.skladisteBtn.Location = new System.Drawing.Point(36, 24);
            this.skladisteBtn.Name = "skladisteBtn";
            this.skladisteBtn.Size = new System.Drawing.Size(162, 49);
            this.skladisteBtn.TabIndex = 17;
            this.skladisteBtn.Text = "Skladiste";
            this.skladisteBtn.UseVisualStyleBackColor = true;
            // 
            // racuniOtpremniceBtn
            // 
            this.racuniOtpremniceBtn.Location = new System.Drawing.Point(36, 93);
            this.racuniOtpremniceBtn.Name = "racuniOtpremniceBtn";
            this.racuniOtpremniceBtn.Size = new System.Drawing.Size(162, 49);
            this.racuniOtpremniceBtn.TabIndex = 18;
            this.racuniOtpremniceBtn.Text = "Racuni-otpremnice";
            this.racuniOtpremniceBtn.UseVisualStyleBackColor = true;
            // 
            // zahtjevniceBtn
            // 
            this.zahtjevniceBtn.Location = new System.Drawing.Point(36, 164);
            this.zahtjevniceBtn.Name = "zahtjevniceBtn";
            this.zahtjevniceBtn.Size = new System.Drawing.Size(162, 49);
            this.zahtjevniceBtn.TabIndex = 19;
            this.zahtjevniceBtn.Text = "Zahtjevnice";
            this.zahtjevniceBtn.UseVisualStyleBackColor = true;
            // 
            // primkeBtn
            // 
            this.primkeBtn.Location = new System.Drawing.Point(36, 235);
            this.primkeBtn.Name = "primkeBtn";
            this.primkeBtn.Size = new System.Drawing.Size(162, 49);
            this.primkeBtn.TabIndex = 20;
            this.primkeBtn.Text = "Primke";
            this.primkeBtn.UseVisualStyleBackColor = true;
            // 
            // porukeBtn
            // 
            this.porukeBtn.Location = new System.Drawing.Point(36, 307);
            this.porukeBtn.Name = "porukeBtn";
            this.porukeBtn.Size = new System.Drawing.Size(162, 49);
            this.porukeBtn.TabIndex = 21;
            this.porukeBtn.Text = "Poruke";
            this.porukeBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.popisRacunaOtpremnica);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kreirajPrimkuBtn);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 545);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // popisRacunaOtpremnica
            // 
            this.popisRacunaOtpremnica.FormattingEnabled = true;
            this.popisRacunaOtpremnica.Location = new System.Drawing.Point(24, 81);
            this.popisRacunaOtpremnica.Name = "popisRacunaOtpremnica";
            this.popisRacunaOtpremnica.Size = new System.Drawing.Size(682, 381);
            this.popisRacunaOtpremnica.TabIndex = 17;
            this.popisRacunaOtpremnica.SelectedIndexChanged += new System.EventHandler(this.đ_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dobavljac:";
            // 
            // kreirajPrimkuBtn
            // 
            this.kreirajPrimkuBtn.Location = new System.Drawing.Point(293, 486);
            this.kreirajPrimkuBtn.Name = "kreirajPrimkuBtn";
            this.kreirajPrimkuBtn.Size = new System.Drawing.Size(151, 23);
            this.kreirajPrimkuBtn.TabIndex = 14;
            this.kreirajPrimkuBtn.Text = "Kreiraj primku";
            this.kreirajPrimkuBtn.UseVisualStyleBackColor = true;
            // 
            // Skladistar_racun_otpremnica_popis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.porukeBtn);
            this.Controls.Add(this.primkeBtn);
            this.Controls.Add(this.zahtjevniceBtn);
            this.Controls.Add(this.racuniOtpremniceBtn);
            this.Controls.Add(this.skladisteBtn);
            this.Name = "Skladistar_racun_otpremnica_popis";
            this.Text = "Skladistar_racun_otpremnica_popis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button skladisteBtn;
        private System.Windows.Forms.Button racuniOtpremniceBtn;
        private System.Windows.Forms.Button zahtjevniceBtn;
        private System.Windows.Forms.Button primkeBtn;
        private System.Windows.Forms.Button porukeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kreirajPrimkuBtn;
        private System.Windows.Forms.ListBox popisRacunaOtpremnica;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}