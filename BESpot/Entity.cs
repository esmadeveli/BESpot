﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BESpot
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Text { get; internal set; }
        public bool Güncelleme { get; internal set; }
        public Musteri musteri { get; internal set; }

        private Musteri musteri1;


        public Musteri GetMusteri()
        {
            return musteri1;
        }

        internal void SetMusteri(Musteri value)
        {
            musteri1 = value;
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }


        internal object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }

    public class Urun
    {
        public Guid ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Ağırlık { get; set; }
        public string Renk { get; set; }
        public double Fiyat { get; set; }
        public string Text { get; internal set; }

        public bool Güncelleme { get; internal set; }
        
      

        public override string ToString()
        {
            return $"{Marka}";
        }

        internal object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
    public class Siparis
    {
        public Guid ID { get; set; }

        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }

        public DateTime SiparişTarihi { get; set; }
        public DateTime ÖdemeTarihi { get; set; }

        public double Fiyat { get; set; }

        public double Adet { get; set; }
        public string ÖdemeTürü { get; set; }
        public string Text { get; internal set; }
        public DateTime Tarih { get; internal set; }
        public Guid UrunID { get; internal set; }
        public Guid MusteriID { get; internal set; }
        public bool Güncelleme { get; internal set; }

        public Siparis siparis { get; internal set; }


        internal DialogResult ShowDialog()
        {
            // Show dialog logic here
            // ...

            // Return the appropriate DialogResult
            return DialogResult.OK; // veya DialogResult.Cancel
        }
    }

    public class Odeme
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime ÖdemeTarihi { get; set; }
        public string ÖdemeTürü { get; set; }
    }


}
