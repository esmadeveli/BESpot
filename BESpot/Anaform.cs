using BESpot.BL;
using BESpot.DL;
using BESpot.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BESpot
{
    public partial class Anaform : Form

    {
        public object m;
        public Anaform()
        {
            InitializeComponent();
          
            dataGridView1.Visible = true;
        }
        Müşteriler mf = new Müşteriler();
        Urünler uf = new Urünler();
        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }
        private void btnMüşteriler_Click_1(object sender, EventArgs e)
        {
            new Müşteriler().ShowDialog();
        }

        private void btnÜrünler_Click_1(object sender, EventArgs e)
        {
            new Urünler().ShowDialog();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Siparis frm = new Siparis()
            {
                Text = "Sipariş Ver",
                siparis = new Siparis()
                {
                    ID = Guid.NewGuid()
                }
            };
            frm.ShowDialog();
        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {
            Ödeme frm = new Ödeme()
            {
                Text = "Ödeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid()
                }
            };

            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                
            }
            else if (result == DialogResult.Cancel)
            {
                // Ödeme işlemi iptal edildi.
               
            }
        }

        private void btnSiparisDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Siparis frm = new Siparis()
            {
                Text = "Sipariş Güncelle",
                Güncelleme = true,
                siparis = new Siparis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[7].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[8].Value.ToString()),

                },
            };

            var sonuc = frm.ShowDialog();
            // if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisGüncelle(frm.siparis);

                if (b)
                {
                    row.Cells[1].Value = frm.siparis.MusteriID;
                    row.Cells[2].Value = frm.siparis.UrunID;
                    row.Cells[7].Value = frm.siparis.Fiyat;
                    row.Cells[8].Value = frm.siparis.Tarih;

                }
            }

        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);

                if (b)
                {



                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            Urünler urunlerForm = new Urünler();
            urunlerForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSatisSil_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);

                if (b)
                {



                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemler kaydedildi.");
        }
    }
}
