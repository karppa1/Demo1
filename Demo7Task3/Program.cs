using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kanava kanava1 = new Kanava();
            List<Ohjelma> ohjelmat1 = new List<Ohjelma>();

            ohjelmat1.Add(new Ohjelma { Nimi = "Ekaohjelma", Info = "Jonkinlainen ohjelman tapainen", Alku = 18.35, Loppu = 19.05 });
            ohjelmat1.Add(new Ohjelma { Nimi = "Tokaohjelma", Info = "Jonkinlainen toinen ohjelman tapainen", Alku = 19.05, Loppu = 19.20 });
            ohjelmat1.Add(new Ohjelma { Nimi = "Kolmasohjelma", Info = "Jonkinlainen kolmas ohjelman tapainen", Alku = 19.22, Loppu = 20.05 });

            kanava1.Nimi = "Ykkönen";
            kanava1.Ohjelmat = ohjelmat1;

            Kanava kanava2 = new Kanava();
            List<Ohjelma> ohjelmat2 = new List<Ohjelma>();

            ohjelmat2.Add(new Ohjelma { Nimi = "Ohjelma1", Info = "Sarja", Alku = 18.35, Loppu = 19.05 });
            ohjelmat2.Add(new Ohjelma { Nimi = "Ohjelma2", Info = "Elokuva", Alku = 18.35, Loppu = 19.05 });
            ohjelmat2.Add(new Ohjelma { Nimi = "Ohjelma3", Info = "Dokumenttiohjelma", Alku = 18.35, Loppu = 19.05 });

            foreach (Ohjelma tiedot in ohjelmat1)
            {
                Console.WriteLine("Ohjelman nimi: " + tiedot.ToString() + "\n");
            }

            foreach (Ohjelma tiedot in ohjelmat2)
            {
                Console.WriteLine("Ohjelman nimi: " + tiedot.ToString() + "\n");
            }


            Console.ReadLine();
        }
    }
}
