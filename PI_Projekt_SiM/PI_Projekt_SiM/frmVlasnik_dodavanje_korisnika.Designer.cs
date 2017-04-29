namespace PI_Projekt_SiM
{
    partial class frmVlasnik_dodavanje_korisnika
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
            this.djelatniciBtn = new System.Windows.Forms.Button();
            this.naruciBtn = new System.Windows.Forms.Button();
            this.skladisteBtn = new System.Windows.Forms.Button();
            this.racuniOtpremniceBtn = new System.Windows.Forms.Button();
            this.zahtjevniceBtn = new System.Windows.Forms.Button();
            this.primkeBtn = new System.Windows.Forms.Button();
            this.porukeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputIme = new System.Windows.Forms.TextBox();
            this.inputPrezime = new System.Windows.Forms.TextBox();
            this.inputKontakt = new System.Windows.Forms.TextBox();
            this.inputKorIme = new System.Windows.Forms.TextBox();
            this.inputLozinka = new System.Windows.Forms.TextBox();
            this.kreirajBtn = new System.Windows.Forms.Button();
            this.inputUnos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // djelatniciBtn
            // 
            this.djelatniciBtn.Location = new System.Drawing.Point(36, 24);
            this.djelatniciBtn.Name = "djelatniciBtn";
            this.djelatniciBtn.Size = new System.Drawing.Size(162, 49);
            this.djelatniciBtn.TabIndex = 13;
            this.djelatniciBtn.Text = "Djelatnici";
            this.djelatniciBtn.UseVisualStyleBackColor = true;
            // 
            // naruciBtn
            // 
            this.naruciBtn.Location = new System.Drawing.Point(36, 93);
            this.naruciBtn.Name = "naruciBtn";
            this.naruciBtn.Size = new System.Drawing.Size(162, 49);
            this.naruciBtn.TabIndex = 14;
            this.naruciBtn.Text = "Narucivanje";
            this.naruciBtn.UseVisualStyleBackColor = true;
            // 
            // skladisteBtn
            // 
            this.skladisteBtn.Location = new System.Drawing.Point(36, 164);
            this.skladisteBtn.Name = "skladisteBtn";
            this.skladisteBtn.Size = new System.Drawing.Size(162, 49);
            this.skladisteBtn.TabIndex = 15;
            this.skladisteBtn.Text = "Skladiste";
            this.skladisteBtn.UseVisualStyleBackColor = true;
            // 
            // racuniOtpremniceBtn
            // 
            this.racuniOtpremniceBtn.Location = new System.Drawing.Point(36, 235);
            this.racuniOtpremniceBtn.Name = "racuniOtpremniceBtn";
            this.racuniOtpremniceBtn.Size = new System.Drawing.Size(162, 49);
            this.racuniOtpremniceBtn.TabIndex = 16;
            this.racuniOtpremniceBtn.Text = "Racuni-otpremnice";
            this.racuniOtpremniceBtn.UseVisualStyleBackColor = true;
            // 
            // zahtjevniceBtn
            // 
            this.zahtjevniceBtn.Location = new System.Drawing.Point(36, 307);
            this.zahtjevniceBtn.Name = "zahtjevniceBtn";
            this.zahtjevniceBtn.Size = new System.Drawing.Size(162, 49);
            this.zahtjevniceBtn.TabIndex = 17;
            this.zahtjevniceBtn.Text = "Zahtjevnice";
            this.zahtjevniceBtn.UseVisualStyleBackColor = true;
            // 
            // primkeBtn
            // 
            this.primkeBtn.Location = new System.Drawing.Point(36, 377);
            this.primkeBtn.Name = "primkeBtn";
            this.primkeBtn.Size = new System.Drawing.Size(162, 49);
            this.primkeBtn.TabIndex = 18;
            this.primkeBtn.Text = "Primke";
            this.primkeBtn.UseVisualStyleBackColor = true;
            // 
            // porukeBtn
            // 
            this.porukeBtn.Location = new System.Drawing.Point(36, 447);
            this.porukeBtn.Name = "porukeBtn";
            this.porukeBtn.Size = new System.Drawing.Size(162, 49);
            this.porukeBtn.TabIndex = 19;
            this.porukeBtn.Text = "Poruke";
            this.porukeBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputUnos);
            this.groupBox1.Controls.Add(this.inputIme);
            this.groupBox1.Controls.Add(this.inputPrezime);
            this.groupBox1.Controls.Add(this.inputKontakt);
            this.groupBox1.Controls.Add(this.inputKorIme);
            this.groupBox1.Controls.Add(this.inputLozinka);
            this.groupBox1.Controls.Add(this.kreirajBtn);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 545);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje novog korisnika";
            // 
            // inputIme
            // 
            this.inputIme.Location = new System.Drawing.Point(70, 50);
            this.inputIme.Name = "inputIme";
            this.inputIme.Size = new System.Drawing.Size(133, 20);
            this.inputIme.TabIndex = 15;
            this.inputIme.Text = "Ime";
            // 
            // inputPrezime
            // 
            this.inputPrezime.Location = new System.Drawing.Point(70, 94);
            this.inputPrezime.Name = "inputPrezime";
            this.inputPrezime.Size = new System.Drawing.Size(133, 20);
            this.inputPrezime.TabIndex = 16;
            this.inputPrezime.Text = "Prezime";
            // 
            // inputKontakt
            // 
            this.inputKontakt.Location = new System.Drawing.Point(70, 227);
            this.inputKontakt.Name = "inputKontakt";
            this.inputKontakt.Size = new System.Drawing.Size(133, 20);
            this.inputKontakt.TabIndex = 19;
            this.inputKontakt.Text = "Kontakt";
            // 
            // inputKorIme
            // 
            this.inputKorIme.Location = new System.Drawing.Point(70, 134);
            this.inputKorIme.Name = "inputKorIme";
            this.inputKorIme.Size = new System.Drawing.Size(133, 20);
            this.inputKorIme.TabIndex = 17;
            this.inputKorIme.Text = "Korisničko ime";
            // 
            // inputLozinka
            // 
            this.inputLozinka.Location = new System.Drawing.Point(70, 180);
            this.inputLozinka.Name = "inputLozinka";
            this.inputLozinka.Size = new System.Drawing.Size(133, 20);
            this.inputLozinka.TabIndex = 18;
            this.inputLozinka.Text = "Lozinka";
            // 
            // kreirajBtn
            // 
            this.kreirajBtn.Location = new System.Drawing.Point(297, 503);
            this.kreirajBtn.Name = "kreirajBtn";
            this.kreirajBtn.Size = new System.Drawing.Size(151, 23);
            this.kreirajBtn.TabIndex = 14;
            this.kreirajBtn.Text = "Kreiraj";
            this.kreirajBtn.UseVisualStyleBackColor = true;
            // 
            // inputUnos
            // 
            this.inputUnos.Location = new System.Drawing.Point(91, 295);
            this.inputUnos.Name = "inputUnos";
            this.inputUnos.Size = new System.Drawing.Size(89, 40);
            this.inputUnos.TabIndex = 20;
            this.inputUnos.Text = "Dodaj";
            this.inputUnos.UseVisualStyleBackColor = true;
            // 
            // frmVlasnik_dodavanje_korisnika
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
            this.Controls.Add(this.naruciBtn);
            this.Controls.Add(this.djelatniciBtn);
            this.Name = "frmVlasnik_dodavanje_korisnika";
            this.Text = "Vlasnik_dodavanje_korisnika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button djelatniciBtn;
        private System.Windows.Forms.Button naruciBtn;
        private System.Windows.Forms.Button skladisteBtn;
        private System.Windows.Forms.Button racuniOtpremniceBtn;
        private System.Windows.Forms.Button zahtjevniceBtn;
        private System.Windows.Forms.Button primkeBtn;
        private System.Windows.Forms.Button porukeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kreirajBtn;
        private System.Windows.Forms.TextBox inputIme;
        private System.Windows.Forms.TextBox inputPrezime;
        private System.Windows.Forms.TextBox inputKontakt;
        private System.Windows.Forms.TextBox inputKorIme;
        private System.Windows.Forms.TextBox inputLozinka;
        private System.Windows.Forms.Button inputUnos;
    }
}