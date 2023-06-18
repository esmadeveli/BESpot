namespace BESpot.UI
{
    partial class Siparis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparis));
            this.btnÜrünSeç = new System.Windows.Forms.Button();
            this.cbödemetürü = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            this.dtsiparis = new System.Windows.Forms.DateTimePicker();
            this.ÖdemeTarihi = new System.Windows.Forms.Label();
            this.SiparişTarihi = new System.Windows.Forms.Label();
            this.nmÜcret = new System.Windows.Forms.NumericUpDown();
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.MusteriID = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.UrunID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.Adı = new System.Windows.Forms.Label();
            this.SiparisID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmÜcret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnÜrünSeç
            // 
            this.btnÜrünSeç.BackColor = System.Drawing.Color.RosyBrown;
            this.btnÜrünSeç.Location = new System.Drawing.Point(602, 197);
            this.btnÜrünSeç.Name = "btnÜrünSeç";
            this.btnÜrünSeç.Size = new System.Drawing.Size(167, 29);
            this.btnÜrünSeç.TabIndex = 57;
            this.btnÜrünSeç.Text = "Ürün Seç";
            this.btnÜrünSeç.UseVisualStyleBackColor = false;
            this.btnÜrünSeç.Click += new System.EventHandler(this.btnÜrünSeç_Click);
            // 
            // cbödemetürü
            // 
            this.cbödemetürü.FormattingEnabled = true;
            this.cbödemetürü.Items.AddRange(new object[] {
            "Banka Kartı",
            "Kredi Kartı",
            "Nakit",
            "Senet"});
            this.cbödemetürü.Location = new System.Drawing.Point(217, 293);
            this.cbödemetürü.Name = "cbödemetürü";
            this.cbödemetürü.Size = new System.Drawing.Size(277, 24);
            this.cbödemetürü.TabIndex = 55;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMüşteriSeç.Location = new System.Drawing.Point(602, 149);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(167, 29);
            this.btnMüşteriSeç.TabIndex = 56;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = false;
            this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // dtsiparis
            // 
            this.dtsiparis.Location = new System.Drawing.Point(217, 254);
            this.dtsiparis.Name = "dtsiparis";
            this.dtsiparis.Size = new System.Drawing.Size(277, 22);
            this.dtsiparis.TabIndex = 45;
            // 
            // ÖdemeTarihi
            // 
            this.ÖdemeTarihi.BackColor = System.Drawing.Color.RosyBrown;
            this.ÖdemeTarihi.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeTarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeTarihi.Location = new System.Drawing.Point(43, 287);
            this.ÖdemeTarihi.Name = "ÖdemeTarihi";
            this.ÖdemeTarihi.Size = new System.Drawing.Size(169, 33);
            this.ÖdemeTarihi.TabIndex = 54;
            this.ÖdemeTarihi.Text = "Ödeme Türü :";
            this.ÖdemeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SiparişTarihi
            // 
            this.SiparişTarihi.BackColor = System.Drawing.Color.RosyBrown;
            this.SiparişTarihi.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiparişTarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SiparişTarihi.Location = new System.Drawing.Point(43, 245);
            this.SiparişTarihi.Name = "SiparişTarihi";
            this.SiparişTarihi.Size = new System.Drawing.Size(169, 42);
            this.SiparişTarihi.TabIndex = 53;
            this.SiparişTarihi.Text = "Sipariş Tarihi :";
            this.SiparişTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nmÜcret
            // 
            this.nmÜcret.Location = new System.Drawing.Point(217, 223);
            this.nmÜcret.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmÜcret.Name = "nmÜcret";
            this.nmÜcret.Size = new System.Drawing.Size(277, 22);
            this.nmÜcret.TabIndex = 44;
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(217, 188);
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(278, 22);
            this.nmAdet.TabIndex = 43;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMusteriID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(217, 118);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(278, 28);
            this.txtMusteriID.TabIndex = 41;
            this.txtMusteriID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMusteriID.TextChanged += new System.EventHandler(this.txtMusteriID_TextChanged);
            // 
            // MusteriID
            // 
            this.MusteriID.BackColor = System.Drawing.Color.RosyBrown;
            this.MusteriID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusteriID.Location = new System.Drawing.Point(43, 115);
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.Size = new System.Drawing.Size(169, 30);
            this.MusteriID.TabIndex = 52;
            this.MusteriID.Text = "Müşteri ID :";
            this.MusteriID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunID
            // 
            this.txtUrunID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUrunID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(217, 152);
            this.txtUrunID.Multiline = true;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(278, 28);
            this.txtUrunID.TabIndex = 42;
            this.txtUrunID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UrunID
            // 
            this.UrunID.BackColor = System.Drawing.Color.RosyBrown;
            this.UrunID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UrunID.Location = new System.Drawing.Point(43, 145);
            this.UrunID.Name = "UrunID";
            this.UrunID.Size = new System.Drawing.Size(169, 34);
            this.UrunID.TabIndex = 51;
            this.UrunID.Text = "Ürün ID :";
            this.UrunID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(361, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 29);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(244, 345);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 29);
            this.btnOk.TabIndex = 46;
            this.btnOk.Text = "Ürün Ekle";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(217, 84);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(278, 28);
            this.txtID.TabIndex = 40;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.Color.RosyBrown;
            this.txtFiyat.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFiyat.Location = new System.Drawing.Point(42, 215);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(169, 35);
            this.txtFiyat.TabIndex = 48;
            this.txtFiyat.Text = "Ücret :";
            this.txtFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Adı
            // 
            this.Adı.BackColor = System.Drawing.Color.RosyBrown;
            this.Adı.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adı.Location = new System.Drawing.Point(43, 179);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(169, 36);
            this.Adı.TabIndex = 49;
            this.Adı.Text = "Adet : ";
            this.Adı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SiparisID
            // 
            this.SiparisID.BackColor = System.Drawing.Color.RosyBrown;
            this.SiparisID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiparisID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SiparisID.Location = new System.Drawing.Point(43, 77);
            this.SiparisID.Name = "SiparisID";
            this.SiparisID.Size = new System.Drawing.Size(169, 38);
            this.SiparisID.TabIndex = 50;
            this.SiparisID.Text = " ID :";
            this.SiparisID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnÜrünSeç);
            this.Controls.Add(this.cbödemetürü);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Controls.Add(this.dtsiparis);
            this.Controls.Add(this.ÖdemeTarihi);
            this.Controls.Add(this.SiparişTarihi);
            this.Controls.Add(this.nmÜcret);
            this.Controls.Add(this.nmAdet);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.MusteriID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.UrunID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.SiparisID);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmÜcret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÜrünSeç;
        private System.Windows.Forms.ComboBox cbödemetürü;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMüşteriSeç;
        private System.Windows.Forms.DateTimePicker dtsiparis;
        private System.Windows.Forms.Label ÖdemeTarihi;
        private System.Windows.Forms.Label SiparişTarihi;
        private System.Windows.Forms.NumericUpDown nmÜcret;
        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label MusteriID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label UrunID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.Label Adı;
        private System.Windows.Forms.Label SiparisID;
    }
}