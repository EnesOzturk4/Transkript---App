using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemiuygulama
{
    public class Ders
    {
        public int Kod { get; set; }
 
        public string Ad { get; set; }
        public int Kredi { get; set; }


        public override string ToString()
        {
            return Ad  ; 
        }
    }
}
