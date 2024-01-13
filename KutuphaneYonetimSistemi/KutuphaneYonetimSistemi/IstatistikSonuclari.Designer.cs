namespace KutuphaneYonetimSistemi
{
    partial class IstatistikSonuclari
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
            this.listPuanlamaSiralamalari = new System.Windows.Forms.ListBox();
            this.listDegerlendirmeSiralamalari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPuanlamaSiralamalari
            // 
            this.listPuanlamaSiralamalari.FormattingEnabled = true;
            this.listPuanlamaSiralamalari.ItemHeight = 20;
            this.listPuanlamaSiralamalari.Location = new System.Drawing.Point(72, 114);
            this.listPuanlamaSiralamalari.Name = "listPuanlamaSiralamalari";
            this.listPuanlamaSiralamalari.Size = new System.Drawing.Size(266, 224);
            this.listPuanlamaSiralamalari.TabIndex = 0;
            // 
            // listDegerlendirmeSiralamalari
            // 
            this.listDegerlendirmeSiralamalari.FormattingEnabled = true;
            this.listDegerlendirmeSiralamalari.ItemHeight = 20;
            this.listDegerlendirmeSiralamalari.Location = new System.Drawing.Point(667, 114);
            this.listDegerlendirmeSiralamalari.Name = "listDegerlendirmeSiralamalari";
            this.listDegerlendirmeSiralamalari.Size = new System.Drawing.Size(266, 224);
            this.listDegerlendirmeSiralamalari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Puanlama Sıraları:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Film Değerlendirilme Sıraları:";
            // 
            // IstatistikSonuclari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDegerlendirmeSiralamalari);
            this.Controls.Add(this.listPuanlamaSiralamalari);
            this.Name = "IstatistikSonuclari";
            this.Text = "IstatistikSonuclari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPuanlamaSiralamalari;
        private System.Windows.Forms.ListBox listDegerlendirmeSiralamalari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}