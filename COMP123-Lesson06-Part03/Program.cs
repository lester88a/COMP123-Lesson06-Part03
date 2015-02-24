using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson06_Part03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card newCard = new Card(Face.ACE, Suits.HEARTS);
            //Console.WriteLine(newCard.ToString());
            int rdNumber;
            Random rdn = new Random();
            rdNumber = rdn.Next(0, 53);
            Deck newDeck = new Deck();

            Console.WriteLine("Random Number is: {0}.", rdNumber);
            Console.WriteLine(newDeck.pickCard(rdNumber));

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
