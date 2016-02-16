using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task3
{
    class Ohjelma : Tiedot
    {        
        
        public Ohjelma()
        {

        }

        public Ohjelma(string nimi,string info,double alku,double loppu)
        {
            
        }
                
        public override string ToString()
        {
            return Nimi + "\nOhjelman kuvaus: " + Info + "\nAlkaa klo: " + Alku + " - Loppuu klo: " + Loppu;
        }
    }
}
