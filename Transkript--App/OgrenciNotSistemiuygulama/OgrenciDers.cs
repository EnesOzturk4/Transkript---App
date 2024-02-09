using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemiuygulama
{
    public class OgrenciDers
    {
        public Ogrenci Ogrenci { get; set; }
        public Donem Donem { get; set; }
        public Ders Ders { get; set; }

        public HarfNotu HarfNotu { get; set; }
        public override string ToString()
        {
           return Ogrenci.Ad  + Donem.Ad + Donem.No + Ders.Ad;
            
        }
    }
}
