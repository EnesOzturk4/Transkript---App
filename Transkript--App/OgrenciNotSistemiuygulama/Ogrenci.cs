﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemiuygulama
{
    public class Ogrenci
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No {  get; set; }
     
        public override string ToString()
        {
            return Ad + " " + Soyad  ;         
        }
    }
}
