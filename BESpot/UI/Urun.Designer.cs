namespace BESpot.UI
{
    partial class Urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urun));
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbRenk = new System.Windows.Forms.ComboBox();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtAğırlık = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.textUrunID = new System.Windows.Forms.TextBox();
            this.Renk = new System.Windows.Forms.Label();
            this.Ağırlık = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Marka = new System.Windows.Forms.Label();
            this.MusteriID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Items.AddRange(new object[] {
            "Arçelik",
            "Beko",
            "Bosch",
            "Hotpoint",
            "Vestel",
            "Samsung",
            "Altus ",
            "Ferre",
            "Siemens",
            "Franke ",
            "Miele",
            "Profilo",
            "Regal",
            "Simfer",
            "Esty",
            "Kumtel",
            "Teka",
            "Luxell",
            "Electrolux",
            "LG",
            "Grundig",
            "Uğur",
            "Sinbo"});
            this.cbMarka.Location = new System.Drawing.Point(371, 121);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(277, 24);
            this.cbMarka.TabIndex = 16;
            // 
            // cbRenk
            // 
            this.cbRenk.FormattingEnabled = true;
            this.cbRenk.Items.AddRange(new object[] {
            "Siyah",
            "Beyaz",
            "Gri",
            "Kırmızı "});
            this.cbRenk.Location = new System.Drawing.Point(371, 288);
            this.cbRenk.Name = "cbRenk";
            this.cbRenk.Size = new System.Drawing.Size(278, 24);
            this.cbRenk.TabIndex = 20;
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(372, 206);
            this.nmFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(277, 22);
            this.nmFiyat.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(532, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 29);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(372, 344);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(146, 29);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Ürün Ekle";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtAğırlık
            // 
            this.txtAğırlık.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAğırlık.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAğırlık.Location = new System.Drawing.Point(371, 243);
            this.txtAğırlık.Multiline = true;
            this.txtAğırlık.Name = "txtAğırlık";
            this.txtAğırlık.Size = new System.Drawing.Size(278, 28);
            this.txtAğırlık.TabIndex = 19;
            this.txtAğırlık.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtModel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(371, 158);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(278, 28);
            this.txtModel.TabIndex = 17;
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // textUrunID
            // 
            this.textUrunID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textUrunID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUrunID.Location = new System.Drawing.Point(371, 78);
            this.textUrunID.Multiline = true;
            this.textUrunID.Name = "textUrunID";
            this.textUrunID.ReadOnly = true;
            this.textUrunID.Size = new System.Drawing.Size(278, 28);
            this.textUrunID.TabIndex = 15;
            this.textUrunID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Renk
            // 
            this.Renk.BackColor = System.Drawing.Color.RosyBrown;
            this.Renk.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Renk.Location = new System.Drawing.Point(188, 278);
            this.Renk.Name = "Renk";
            this.Renk.Size = new System.Drawing.Size(173, 40);
            this.Renk.TabIndex = 23;
            this.Renk.Text = "Renk :";
            this.Renk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ağırlık
            // 
            this.Ağırlık.BackColor = System.Drawing.Color.RosyBrown;
            this.Ağırlık.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ağırlık.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ağırlık.Location = new System.Drawing.Point(187, 235);
            this.Ağırlık.Name = "Ağırlık";
            this.Ağırlık.Size = new System.Drawing.Size(174, 43);
            this.Ağırlık.TabIndex = 24;
            this.Ağırlık.Text = "Ağırlık :";
            this.Ağırlık.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Fiyat
            // 
            this.Fiyat.BackColor = System.Drawing.Color.RosyBrown;
            this.Fiyat.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fiyat.Location = new System.Drawing.Point(187, 195);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(174, 40);
            this.Fiyat.TabIndex = 25;
            this.Fiyat.Text = "Fiyat :";
            this.Fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Model
            // 
            this.Model.BackColor = System.Drawing.Color.RosyBrown;
            this.Model.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Model.Location = new System.Drawing.Point(187, 155);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(174, 40);
            this.Model.TabIndex = 26;
            this.Model.Text = "Model :";
            this.Model.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Marka
            // 
            this.Marka.BackColor = System.Drawing.Color.RosyBrown;
            this.Marka.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Marka.Location = new System.Drawing.Point(187, 110);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(174, 45);
            this.Marka.TabIndex = 27;
            this.Marka.Text = "Marka :";
            this.Marka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MusteriID
            // 
            this.MusteriID.BackColor = System.Drawing.Color.RosyBrown;
            this.MusteriID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusteriID.Location = new System.Drawing.Point(181, 79);
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.Size = new System.Drawing.Size(180, 31);
            this.MusteriID.TabIndex = 28;
            this.MusteriID.Text = "Ürün ID :";
            this.MusteriID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MusteriID.Click += new System.EventHandler(this.MusteriID_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.cbRenk);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAğırlık);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.textUrunID);
            this.Controls.Add(this.Renk);
            this.Controls.Add(this.Ağırlık);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.MusteriID);
            this.Name = "Urun";
            this.Text = "Urun";
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbRenk;
        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtAğırlık;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox textUrunID;
        private System.Windows.Forms.Label Renk;
        private System.Windows.Forms.Label Ağırlık;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label MusteriID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}