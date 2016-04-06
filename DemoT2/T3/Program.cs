using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();

            wallet.addMoney(5.5);
            wallet.addMoney(8.4);
            wallet.addMoney(7.9);

            Console.WriteLine(wallet.ToString());

            wallet.takeMoney(100);
            wallet.takeMoney(3.6);

            Console.WriteLine(wallet.ToString());

            wallet.addCard(new Card("S-Etukortti", "Aku Ankka", "ABC12345"));
            wallet.addCard(new Card("Visa", "Aku Ankka", "CBA12345"));
            wallet.addCard(new Card("Kirjastokortti", "Aku Ankka", "ACB12345"));

            Console.WriteLine(wallet.ToString());

            wallet.takeCard("Visa");

            Console.WriteLine(wallet.ToString());

            Console.ReadLine();
        }
    }
}
