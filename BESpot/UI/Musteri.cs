using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BESpot.UI
{
    public partial class MusteriEkleDüzenle : Form
    {
        public MusteriEkleDüzenle()
        {
            InitializeComponent();
        }

       
        public Musteri Musteri { get; set; }
        public bool Güncelleme { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ShowDialog();
            if (!ErrorControl(txtAdı)) return;
            if (!ErrorControl(txtSoyadı)) return;
            if (!ErrorControl(txtTelefon)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdresi)) return;

            Musteri musteri = new Musteri()
            {
                Ad = txtAdı.Text,
                Soyad = txtSoyadı.Text,
                Telefon = txtTelefon.Text,
                Mail = txtMail.Text,
                Adres = txtAdresi.Text
            };

          

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Tüm alanları doldurunuz");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Telefon numarası boş bırakılamaz");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }

        private void MusteriEkleDüzenle_Load(object sender, EventArgs e)
        {
            txtMusteriID.Text = Musteri.ID.ToString();
            if (Güncelleme)
            {
                txtAdı.Text = Musteri.Ad;
                txtSoyadı.Text = Musteri.Soyad;
                txtTelefon.Text = Musteri.Telefon;
                txtMail.Text = Musteri.Mail;
                txtAdresi.Text = Musteri.Adres;

            }
        }

        private void txtAdresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Adres_Click(object sender, EventArgs e)
        {

        }

        private void Mail_Click(object sender, EventArgs e)
        {

        }

        private void Telefon_Click(object sender, EventArgs e)
        {

        }

        private void Soyadı_Click(object sender, EventArgs e)
        {

        }

        private void Adı_Click(object sender, EventArgs e)
        {

        }

        private void MusteriID_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MusteriEkleDüzenle_Load_1(object sender, EventArgs e)
        {

        }
    }
}
