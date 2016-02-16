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
            kanava1.Nimi = "Ykkönen";
            List<Ohjelma> ohjelmat1 = new List<Ohjelma>();

            ohjelmat1.Add(new Ohjelma { Nimi = "Ekaohjelma", Info = "Jonkinlainen ohjelman tapainen", Alku = 18.35, Loppu = 19.05 });
            ohjelmat1.Add(new Ohjelma { Nimi = "Tokaohjelma", Info = "Jonkinlainen toinen ohjelman tapainen", Alku = 19.05, Loppu = 19.20 });
            ohjelmat1.Add(new Ohjelma { Nimi = "Kolmasohjelma", Info = "Jonkinlainen kolmas ohjelman tapainen", Alku = 19.22, Loppu = 20.05 });

            List<string> ohjelmatOut = new List<string>();
            foreach (Ohjelma tiedot in ohjelmat1)
            {
                ohjelmatOut.Add(tiedot.ToString());
            }

            File.WriteAllLines("Kanava1.txt", ohjelmatOut);

            try
            {
                string text = System.IO.File.ReadAllText("Kanava1.txt");
                System.Console.WriteLine("Kanava: \n" + kanava1.Nimi + "\n\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

            ohjelmatOut.Clear();

            Kanava kanava2 = new Kanava();
            kanava2.Nimi = "Kakkonen";
            List<Ohjelma> ohjelmat2 = new List<Ohjelma>();

            ohjelmat2.Add(new Ohjelma { Nimi = "Ohjelma1", Info = "Sarja", Alku = 18.35, Loppu = 19.05 });
            ohjelmat2.Add(new Ohjelma { Nimi = "Ohjelma2", Info = "Elokuva", Alku = 18.35, Loppu = 19.05 });
            ohjelmat2.Add(new Ohjelma { Nimi = "Ohjelma3", Info = "Dokumenttiohjelma", Alku = 18.35, Loppu = 19.05 });

            foreach (Ohjelma tiedot in ohjelmat2)
            {
                ohjelmatOut.Add(tiedot.ToString());
            }

            File.WriteAllLines("Kanava2.txt", ohjelmatOut);

            try
            {
                string text = System.IO.File.ReadAllText("Kanava2.txt");
                System.Console.WriteLine("Kanava: \n" + kanava2.Nimi + "\n\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

           
            Console.ReadLine();
        }
    }
}
