namespace KutuphaneYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AdminGirisBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminSifretext = new System.Windows.Forms.TextBox();
            this.AdminAdtext = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnKullaniciIstatistikGoruntule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.filmSonuclariGenelKullanici = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGenelKullaniciAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurGenelKullanici = new System.Windows.Forms.TextBox();
            this.txtYonetmenGenelKullanici = new System.Windows.Forms.TextBox();
            this.txtFilmAdiGenelKullanici = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AdminGirisBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AdminSifretext);
            this.tabPage1.Controls.Add(this.AdminAdtext);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yönetici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminGirisBtn
            // 
            this.AdminGirisBtn.Location = new System.Drawing.Point(266, 235);
            this.AdminGirisBtn.Name = "AdminGirisBtn";
            this.AdminGirisBtn.Size = new System.Drawing.Size(132, 41);
            this.AdminGirisBtn.TabIndex = 4;
            this.AdminGirisBtn.Text = "Giriş Yap";
            this.AdminGirisBtn.UseVisualStyleBackColor = true;
            this.AdminGirisBtn.Click += new System.EventHandler(this.AdminGirisBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // AdminSifretext
            // 
            this.AdminSifretext.Location = new System.Drawing.Point(240, 126);
            this.AdminSifretext.Name = "AdminSifretext";
            this.AdminSifretext.Size = new System.Drawing.Size(158, 26);
            this.AdminSifretext.TabIndex = 1;
            // 
            // AdminAdtext
            // 
            this.AdminAdtext.Location = new System.Drawing.Point(240, 62);
            this.AdminAdtext.Name = "AdminAdtext";
            this.AdminAdtext.Size = new System.Drawing.Size(158, 26);
            this.AdminAdtext.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnKullaniciIstatistikGoruntule);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.filmSonuclariGenelKullanici);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btnGenelKullaniciAra);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtTurGenelKullanici);
            this.tabPage3.Controls.Add(this.txtYonetmenGenelKullanici);
            this.tabPage3.Controls.Add(this.txtFilmAdiGenelKullanici);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1181, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kullanıcı";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciIstatistikGoruntule
            // 
            this.btnKullaniciIstatistikGoruntule.Location = new System.Drawing.Point(518, 384);
            this.btnKullaniciIstatistikGoruntule.Name = "btnKullaniciIstatistikGoruntule";
            this.btnKullaniciIstatistikGoruntule.Size = new System.Drawing.Size(199, 51);
            this.btnKullaniciIstatistikGoruntule.TabIndex = 15;
            this.btnKullaniciIstatistikGoruntule.Text = "Film İstatistiklerini Görüntüle";
            this.btnKullaniciIstatistikGoruntule.UseVisualStyleBackColor = true;
            this.btnKullaniciIstatistikGoruntule.Click += new System.EventHandler(this.btnKullaniciIstatistikGoruntule_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Film Sonuçları:";
            // 
            // filmSonuclariGenelKullanici
            // 
            this.filmSonuclariGenelKullanici.FormattingEnabled = true;
            this.filmSonuclariGenelKullanici.ItemHeight = 20;
            this.filmSonuclariGenelKullanici.Location = new System.Drawing.Point(518, 61);
            this.filmSonuclariGenelKullanici.Name = "filmSonuclariGenelKullanici";
            this.filmSonuclariGenelKullanici.Size = new System.Drawing.Size(199, 304);
            this.filmSonuclariGenelKullanici.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Giriş / Çıkış / Hesap İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenelKullaniciAra
            // 
            this.btnGenelKullaniciAra.Location = new System.Drawing.Point(162, 331);
            this.btnGenelKullaniciAra.Name = "btnGenelKullaniciAra";
            this.btnGenelKullaniciAra.Size = new System.Drawing.Size(141, 38);
            this.btnGenelKullaniciAra.TabIndex = 6;
            this.btnGenelKullaniciAra.Text = "Film Ara";
            this.btnGenelKullaniciAra.UseVisualStyleBackColor = true;
            this.btnGenelKullaniciAra.Click += new System.EventHandler(this.btnGenelKullaniciAra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yönetmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Film Adı:";
            // 
            // txtTurGenelKullanici
            // 
            this.txtTurGenelKullanici.Location = new System.Drawing.Point(212, 238);
            this.txtTurGenelKullanici.Name = "txtTurGenelKullanici";
            this.txtTurGenelKullanici.Size = new System.Drawing.Size(162, 26);
            this.txtTurGenelKullanici.TabIndex = 2;
            // 
            // txtYonetmenGenelKullanici
            // 
            this.txtYonetmenGenelKullanici.Location = new System.Drawing.Point(212, 143);
            this.txtYonetmenGenelKullanici.Name = "txtYonetmenGenelKullanici";
            this.txtYonetmenGenelKullanici.Size = new System.Drawing.Size(162, 26);
            this.txtYonetmenGenelKullanici.TabIndex = 1;
            // 
            // txtFilmAdiGenelKullanici
            // 
            this.txtFilmAdiGenelKullanici.Location = new System.Drawing.Point(212, 37);
            this.txtFilmAdiGenelKullanici.Name = "txtFilmAdiGenelKullanici";
            this.txtFilmAdiGenelKullanici.Size = new System.Drawing.Size(162, 26);
            this.txtFilmAdiGenelKullanici.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox AdminSifretext;
        private System.Windows.Forms.TextBox AdminAdtext;
        private System.Windows.Forms.Button AdminGirisBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurGenelKullanici;
        private System.Windows.Forms.TextBox txtYonetmenGenelKullanici;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGenelKullaniciAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox filmSonuclariGenelKullanici;
        private System.Windows.Forms.Button btnKullaniciIstatistikGoruntule;
        private System.Windows.Forms.TextBox txtFilmAdiGenelKullanici;
    }
}

