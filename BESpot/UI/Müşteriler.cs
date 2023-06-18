using BESpot.BL;
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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }




        private void Müşteriler_Load(object sender, EventArgs e)
        {

        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            Musteri frmMusteri = new Musteri()
            {
                Text = "Müşteri Ekle",
                musteri = new Musteri() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.GetMusteri());

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnmusteridüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Musteri frmMusteri = new Musteri()
            {
                Text = "Müşteri Güncelle",
                Güncelleme = true,
                musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),

                },
            };
            //
            var sonuc = frmMusteri.ShowDialog();
            // if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.GetMusteri());

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.GetMusteri().Ad;
                    row.Cells[2].Value = frmMusteri.GetMusteri().Soyad;
                    row.Cells[3].Value = frmMusteri.GetMusteri().Telefon;
                    row.Cells[4].Value = frmMusteri.GetMusteri().Mail;
                    row.Cells[5].Value = frmMusteri.GetMusteri().Adres;

                }

            }
        }

        private void btnmusterisil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }
        public Musteri Musteri { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
           
                DataGridViewRow row = dataGridView1.SelectedRows[0];


                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),

                };


                DialogResult = DialogResult.OK;
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Ara_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

