using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemiuygulama
{
    public class Donem
    {



        public string Ad { get; set; }
        
        public int No { get; set; }

        public override string ToString()
        {   
            return No+ "- "+ (No+1) + " " +Ad;
            
        }

    }
}
