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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        public static object ID { get; set; }
        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }

        public Siparis siparis { get; set; }

        public bool Güncelleme { get; set; } = false;

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (nmÜcret.Value == 0)
            {
                errorProvider1.SetError(nmÜcret, "Lütfen Fiyat giriniz!");
                nmÜcret.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmÜcret, "");
            }

            // Siparis.UrunID = Guid.Parse(txtUrunID.Text);
            //  Siparis.MusteriID = Guid.Parse(txtMusteriID.Text);
            // Siparis.SiparisTarihi = dtsiparis.Value;
            // Siparis.ÖdemeTarihi = dtödeme.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            txtID.Text = Siparis.ID.ToString();
            if (Güncelleme)
            {
                txtMusteriID.Text = Musteri.ToString();
                txtUrunID.Text = Urun.ToString();
            }


        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //  txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //  txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }


        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
