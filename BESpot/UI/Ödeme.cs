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
    public partial class Ödeme : Form
    {
        public Ödeme()
        {
            InitializeComponent();
        }
        public Odeme Odeme { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbodeme.SelectedItem == null)
            {
                errorProvider1.SetError(cbodeme, "Lütfen ödeme türünü seçiniz!");
                cbodeme.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbodeme, "");
            }
            Odeme.ÖdemeTarihi = dtödeme.Value;
            Odeme.ÖdemeTürü = cbodeme.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void Ödeme_Load(object sender, EventArgs e)
        {


            dtödeme.Value = Odeme.ÖdemeTarihi;
            cbodeme.SelectedItem = Odeme.ÖdemeTürü;


        }

        private void Ödeme_Load_1(object sender, EventArgs e)
        {

        }
    }
}
