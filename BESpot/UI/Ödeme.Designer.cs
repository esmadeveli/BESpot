namespace BESpot.UI
{
    partial class Ödeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ödeme));
            this.cbodeme = new System.Windows.Forms.ComboBox();
            this.ÖdemeTürü = new System.Windows.Forms.Label();
            this.dtödeme = new System.Windows.Forms.DateTimePicker();
            this.ÖdemeTarihi = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textodemeID = new System.Windows.Forms.TextBox();
            this.ÖdemeID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbodeme
            // 
            this.cbodeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeme.FormattingEnabled = true;
            this.cbodeme.Items.AddRange(new object[] {
            "Banka Kartı",
            "Kredi Kartı",
            "Nakit",
            "Senet "});
            this.cbodeme.Location = new System.Drawing.Point(353, 178);
            this.cbodeme.Name = "cbodeme";
            this.cbodeme.Size = new System.Drawing.Size(278, 24);
            this.cbodeme.TabIndex = 57;
            // 
            // ÖdemeTürü
            // 
            this.ÖdemeTürü.BackColor = System.Drawing.Color.RosyBrown;
            this.ÖdemeTürü.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeTürü.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeTürü.Location = new System.Drawing.Point(179, 168);
            this.ÖdemeTürü.Name = "ÖdemeTürü";
            this.ÖdemeTürü.Size = new System.Drawing.Size(169, 41);
            this.ÖdemeTürü.TabIndex = 63;
            this.ÖdemeTürü.Text = "Ödeme Türü :";
            this.ÖdemeTürü.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtödeme
            // 
            this.dtödeme.Location = new System.Drawing.Point(353, 139);
            this.dtödeme.Name = "dtödeme";
            this.dtödeme.Size = new System.Drawing.Size(278, 22);
            this.dtödeme.TabIndex = 56;
            // 
            // ÖdemeTarihi
            // 
            this.ÖdemeTarihi.BackColor = System.Drawing.Color.RosyBrown;
            this.ÖdemeTarihi.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeTarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeTarihi.Location = new System.Drawing.Point(179, 135);
            this.ÖdemeTarihi.Name = "ÖdemeTarihi";
            this.ÖdemeTarihi.Size = new System.Drawing.Size(169, 33);
            this.ÖdemeTarihi.TabIndex = 62;
            this.ÖdemeTarihi.Text = "Ödeme Tarihi :";
            this.ÖdemeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(506, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 29);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(370, 218);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 29);
            this.btnOk.TabIndex = 58;
            this.btnOk.Text = "Ödeme Yap";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textodemeID
            // 
            this.textodemeID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textodemeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textodemeID.Location = new System.Drawing.Point(353, 92);
            this.textodemeID.Multiline = true;
            this.textodemeID.Name = "textodemeID";
            this.textodemeID.ReadOnly = true;
            this.textodemeID.Size = new System.Drawing.Size(278, 28);
            this.textodemeID.TabIndex = 55;
            this.textodemeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ÖdemeID
            // 
            this.ÖdemeID.BackColor = System.Drawing.Color.RosyBrown;
            this.ÖdemeID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeID.Location = new System.Drawing.Point(179, 92);
            this.ÖdemeID.Name = "ÖdemeID";
            this.ÖdemeID.Size = new System.Drawing.Size(169, 35);
            this.ÖdemeID.TabIndex = 61;
            this.ÖdemeID.Text = "Ödeme ID :";
            this.ÖdemeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMüşteriSeç.Location = new System.Drawing.Point(409, 272);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(167, 59);
            this.btnMüşteriSeç.TabIndex = 64;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = false;
            // 
            // Ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.cbodeme);
            this.Controls.Add(this.ÖdemeTürü);
            this.Controls.Add(this.dtödeme);
            this.Controls.Add(this.ÖdemeTarihi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textodemeID);
            this.Controls.Add(this.ÖdemeID);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Name = "Ödeme";
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.Ödeme_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbodeme;
        private System.Windows.Forms.Label ÖdemeTürü;
        private System.Windows.Forms.DateTimePicker dtödeme;
        private System.Windows.Forms.Label ÖdemeTarihi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textodemeID;
        private System.Windows.Forms.Label ÖdemeID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMüşteriSeç;
    }
}