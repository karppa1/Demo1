using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task3
{
    class Tiedot
    {
        public string Nimi { get; set; }
        public string Info { get; set; }
        public double Alku { get; set; }
        public double Loppu { get; set; }

        public Tiedot()
        {

        }

        public Tiedot(string nimi,string info,double alku,double loppu)
        {
            Nimi = nimi;
            Info = info;
            Alku = alku;
            Loppu = loppu;
        }

    }
}
