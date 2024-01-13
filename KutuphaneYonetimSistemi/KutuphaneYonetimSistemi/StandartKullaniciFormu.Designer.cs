namespace KutuphaneYonetimSistemi
{
    partial class StandartKullaniciFormu
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
            this.filmListesi = new System.Windows.Forms.ListBox();
            this.btnFilmGoruntuleStandart = new System.Windows.Forms.Button();
            this.btnFilmEkleStandart = new System.Windows.Forms.Button();
            this.btnFilmCikarStandart = new System.Windows.Forms.Button();
            this.textFilmAdiStandart = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bilgilerim = new System.Windows.Forms.ListBox();
            this.btnStandartBilgilerimiGoruntule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textYonetmenStandart = new System.Windows.Forms.MaskedTextBox();
            this.txtYorumYonetmen = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYorumFilmAdi = new System.Windows.Forms.MaskedTextBox();
            this.txtYorumBilgisi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmListesi
            // 
            this.filmListesi.FormattingEnabled = true;
            this.filmListesi.ItemHeight = 20;
            this.filmListesi.Location = new System.Drawing.Point(83, 66);
            this.filmListesi.Name = "filmListesi";
            this.filmListesi.Size = new System.Drawing.Size(247, 164);
            this.filmListesi.TabIndex = 0;
            // 
            // btnFilmGoruntuleStandart
            // 
            this.btnFilmGoruntuleStandart.Location = new System.Drawing.Point(83, 300);
            this.btnFilmGoruntuleStandart.Name = "btnFilmGoruntuleStandart";
            this.btnFilmGoruntuleStandart.Size = new System.Drawing.Size(178, 55);
            this.btnFilmGoruntuleStandart.TabIndex = 1;
            this.btnFilmGoruntuleStandart.Text = "Filmlerimi Görüntüle";
            this.btnFilmGoruntuleStandart.UseVisualStyleBackColor = true;
            this.btnFilmGoruntuleStandart.Click += new System.EventHandler(this.btnFilmGoruntuleStandart_Click);
            // 
            // btnFilmEkleStandart
            // 
            this.btnFilmEkleStandart.Location = new System.Drawing.Point(560, 164);
            this.btnFilmEkleStandart.Name = "btnFilmEkleStandart";
            this.btnFilmEkleStandart.Size = new System.Drawing.Size(68, 28);
            this.btnFilmEkleStandart.TabIndex = 2;
            this.btnFilmEkleStandart.Text = "+";
            this.btnFilmEkleStandart.UseVisualStyleBackColor = true;
            this.btnFilmEkleStandart.Click += new System.EventHandler(this.btnFilmEkleStandart_Click);
            // 
            // btnFilmCikarStandart
            // 
            this.btnFilmCikarStandart.Location = new System.Drawing.Point(418, 164);
            this.btnFilmCikarStandart.Name = "btnFilmCikarStandart";
            this.btnFilmCikarStandart.Size = new System.Drawing.Size(79, 28);
            this.btnFilmCikarStandart.TabIndex = 3;
            this.btnFilmCikarStandart.Text = "-";
            this.btnFilmCikarStandart.UseVisualStyleBackColor = true;
            this.btnFilmCikarStandart.Click += new System.EventHandler(this.btnFilmCikarStandart_Click);
            // 
            // textFilmAdiStandart
            // 
            this.textFilmAdiStandart.Location = new System.Drawing.Point(543, 45);
            this.textFilmAdiStandart.Name = "textFilmAdiStandart";
            this.textFilmAdiStandart.Size = new System.Drawing.Size(100, 26);
            this.textFilmAdiStandart.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "FilmAdı:";
            // 
            // Bilgilerim
            // 
            this.Bilgilerim.FormattingEnabled = true;
            this.Bilgilerim.ItemHeight = 20;
            this.Bilgilerim.Location = new System.Drawing.Point(618, 264);
            this.Bilgilerim.Name = "Bilgilerim";
            this.Bilgilerim.Size = new System.Drawing.Size(346, 104);
            this.Bilgilerim.TabIndex = 10;
            // 
            // btnStandartBilgilerimiGoruntule
            // 
            this.btnStandartBilgilerimiGoruntule.Location = new System.Drawing.Point(706, 401);
            this.btnStandartBilgilerimiGoruntule.Name = "btnStandartBilgilerimiGoruntule";
            this.btnStandartBilgilerimiGoruntule.Size = new System.Drawing.Size(178, 55);
            this.btnStandartBilgilerimiGoruntule.TabIndex = 11;
            this.btnStandartBilgilerimiGoruntule.Text = "Bilgilerimi Görüntüle";
            this.btnStandartBilgilerimiGoruntule.UseVisualStyleBackColor = true;
            this.btnStandartBilgilerimiGoruntule.Click += new System.EventHandler(this.btnStandartBilgilerimiGoruntule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yönetmen:";
            // 
            // textYonetmenStandart
            // 
            this.textYonetmenStandart.Location = new System.Drawing.Point(543, 105);
            this.textYonetmenStandart.Name = "textYonetmenStandart";
            this.textYonetmenStandart.Size = new System.Drawing.Size(100, 26);
            this.textYonetmenStandart.TabIndex = 13;
            // 
            // txtYorumYonetmen
            // 
            this.txtYorumYonetmen.Location = new System.Drawing.Point(948, 108);
            this.txtYorumYonetmen.Name = "txtYorumYonetmen";
            this.txtYorumYonetmen.Size = new System.Drawing.Size(100, 26);
            this.txtYorumYonetmen.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yönetmen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "FilmAdı:";
            // 
            // txtYorumFilmAdi
            // 
            this.txtYorumFilmAdi.Location = new System.Drawing.Point(948, 48);
            this.txtYorumFilmAdi.Name = "txtYorumFilmAdi";
            this.txtYorumFilmAdi.Size = new System.Drawing.Size(100, 26);
            this.txtYorumFilmAdi.TabIndex = 14;
            // 
            // txtYorumBilgisi
            // 
            this.txtYorumBilgisi.Location = new System.Drawing.Point(948, 164);
            this.txtYorumBilgisi.Name = "txtYorumBilgisi";
            this.txtYorumBilgisi.Size = new System.Drawing.Size(100, 26);
            this.txtYorumBilgisi.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(809, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Yorum:";
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.Location = new System.Drawing.Point(896, 211);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(108, 28);
            this.btnYorumYap.TabIndex = 20;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = true;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // StandartKullaniciFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 536);
            this.Controls.Add(this.btnYorumYap);
            this.Controls.Add(this.txtYorumBilgisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYorumYonetmen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYorumFilmAdi);
            this.Controls.Add(this.textYonetmenStandart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStandartBilgilerimiGoruntule);
            this.Controls.Add(this.Bilgilerim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFilmAdiStandart);
            this.Controls.Add(this.btnFilmCikarStandart);
            this.Controls.Add(this.btnFilmEkleStandart);
            this.Controls.Add(this.btnFilmGoruntuleStandart);
            this.Controls.Add(this.filmListesi);
            this.Name = "StandartKullaniciFormu";
            this.Text = "StandartKullaniciFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filmListesi;
        private System.Windows.Forms.Button btnFilmGoruntuleStandart;
        private System.Windows.Forms.Button btnFilmEkleStandart;
        private System.Windows.Forms.Button btnFilmCikarStandart;
        private System.Windows.Forms.MaskedTextBox textFilmAdiStandart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Bilgilerim;
        private System.Windows.Forms.Button btnStandartBilgilerimiGoruntule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textYonetmenStandart;
        private System.Windows.Forms.MaskedTextBox txtYorumYonetmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtYorumFilmAdi;
        private System.Windows.Forms.MaskedTextBox txtYorumBilgisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYorumYap;
    }
}