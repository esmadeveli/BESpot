namespace BESpot.UI
{
    partial class MusteriEkleDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkleDüzenle));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtAdresi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.Soyadı = new System.Windows.Forms.Label();
            this.Adı = new System.Windows.Forms.Label();
            this.MusteriID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(504, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 29);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(352, 560);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(146, 29);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Müşteri Ekle";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtAdresi
            // 
            this.txtAdresi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdresi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdresi.Location = new System.Drawing.Point(343, 299);
            this.txtAdresi.Multiline = true;
            this.txtAdresi.Name = "txtAdresi";
            this.txtAdresi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdresi.Size = new System.Drawing.Size(295, 226);
            this.txtAdresi.TabIndex = 20;
            this.txtAdresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdresi.TextChanged += new System.EventHandler(this.txtAdresi_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(343, 259);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(295, 28);
            this.txtMail.TabIndex = 19;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoyadı.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadı.Location = new System.Drawing.Point(342, 179);
            this.txtSoyadı.Multiline = true;
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(295, 28);
            this.txtSoyadı.TabIndex = 17;
            this.txtSoyadı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoyadı.TextChanged += new System.EventHandler(this.txtSoyadı_TextChanged);
            // 
            // txtAdı
            // 
            this.txtAdı.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdı.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdı.Location = new System.Drawing.Point(342, 139);
            this.txtAdı.Multiline = true;
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(295, 28);
            this.txtAdı.TabIndex = 16;
            this.txtAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdı.TextChanged += new System.EventHandler(this.txtAdı_TextChanged);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMusteriID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(342, 99);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(295, 28);
            this.txtMusteriID.TabIndex = 15;
            this.txtMusteriID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMusteriID.TextChanged += new System.EventHandler(this.txtMusteriID_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTelefon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(342, 224);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(295, 26);
            this.txtTelefon.TabIndex = 18;
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefon_MaskInputRejected);
            // 
            // Adres
            // 
            this.Adres.BackColor = System.Drawing.Color.RosyBrown;
            this.Adres.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adres.Location = new System.Drawing.Point(138, 299);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(194, 40);
            this.Adres.TabIndex = 9;
            this.Adres.Text = "Adres Giriniz :";
            this.Adres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Adres.Click += new System.EventHandler(this.Adres_Click);
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.RosyBrown;
            this.Mail.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mail.Location = new System.Drawing.Point(140, 259);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(192, 40);
            this.Mail.TabIndex = 10;
            this.Mail.Text = "E-Mail Adresi :";
            this.Mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // Telefon
            // 
            this.Telefon.BackColor = System.Drawing.Color.RosyBrown;
            this.Telefon.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Telefon.Location = new System.Drawing.Point(140, 216);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(192, 43);
            this.Telefon.TabIndex = 11;
            this.Telefon.Text = "Telefon Numarası :";
            this.Telefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Telefon.Click += new System.EventHandler(this.Telefon_Click);
            // 
            // Soyadı
            // 
            this.Soyadı.BackColor = System.Drawing.Color.RosyBrown;
            this.Soyadı.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soyadı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Soyadı.Location = new System.Drawing.Point(141, 176);
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.Size = new System.Drawing.Size(191, 40);
            this.Soyadı.TabIndex = 12;
            this.Soyadı.Text = "Soyadı :";
            this.Soyadı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Soyadı.Click += new System.EventHandler(this.Soyadı_Click);
            // 
            // Adı
            // 
            this.Adı.BackColor = System.Drawing.Color.RosyBrown;
            this.Adı.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adı.Location = new System.Drawing.Point(141, 131);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(191, 45);
            this.Adı.TabIndex = 13;
            this.Adı.Text = "Adı :";
            this.Adı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Adı.Click += new System.EventHandler(this.Adı_Click);
            // 
            // MusteriID
            // 
            this.MusteriID.BackColor = System.Drawing.Color.RosyBrown;
            this.MusteriID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusteriID.Location = new System.Drawing.Point(141, 99);
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.Size = new System.Drawing.Size(191, 32);
            this.MusteriID.TabIndex = 14;
            this.MusteriID.Text = "Müşteri ID :";
            this.MusteriID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MusteriID.Click += new System.EventHandler(this.MusteriID_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MusteriEkleDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAdresi);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Soyadı);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.MusteriID);
            this.Name = "MusteriEkleDüzenle";
            this.Text = "Musteri Ekle";
            this.Load += new System.EventHandler(this.MusteriEkleDüzenle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtAdresi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Soyadı;
        private System.Windows.Forms.Label Adı;
        private System.Windows.Forms.Label MusteriID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}