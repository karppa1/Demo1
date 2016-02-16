using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task3
{   
    class Kanava : Tiedot
    {
        public List<Ohjelma> Ohjelmat = new List<Ohjelma>();

        public Kanava()
        {

        }

        public Kanava(string nimi,List<Ohjelma> ohjelmat)
        {
            Ohjelmat = ohjelmat;
        }
        
        public override string ToString()
        {
            return Nimi + "n" + Ohjelmat;
        }
    }
}
