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
    public partial class Urun : Form
    {
        public bool Güncelleme { get; private set; }
        public Urun urun { get; internal set; }
        public Guid ID { get; internal set; }

        public Urun()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(cbMarka)) return;
            if (!ErrorControl(txtModel)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(txtAğırlık)) return;
            if (!ErrorControl(cbRenk)) return;

            /*Urun.Marka = cbMarka.SelectedItem.ToString(); 
            Urun.Model = txtModel.Text;
            Urun.Ağırlık = txtAğırlık.Value;
            Urun.Fiyat = (double)nmFiyat.Value;
            Urun.Renk = cbRenk.SelectedItem.ToString(); ;
           */
            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Tüm alanları doldurunuz!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (!(((NumericUpDown)c).Value == 0))
                {
                    errorProvider1.SetError(c, "Lütfen Fiyat Giriniz");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriID_Click(object sender, EventArgs e)
        {

        }
    }
}
