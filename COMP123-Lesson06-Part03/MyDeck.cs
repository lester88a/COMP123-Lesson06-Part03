using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson06_Part03
{
    class MyDeck:Deck,IAddJoker
    {
        //Constructor+++++++++++++++++++++++++++++
        public MyDeck():base()
        { 
            
        }

        //Interface methods+++++++++++++++++++++++
        public void AddJoker()
        {
            Console.WriteLine("Added Joker");
        }
    }
}
