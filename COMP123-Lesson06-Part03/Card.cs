using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson06_Part03
{
    class Card
    {
        //Instance variables +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _face;
        private string _suit;//type

        //Properties +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string Face 
        {
            get 
            {
                return this._face; //Read-only
            }
        }
        public string Suit
        {
            get
            {
                return this._suit; //Read-only
            }
        }

        //Constructors++++++++++++++++++++++++++++
        public Card(string face, string suit)
        {
            this._face = face; //asign the value
            this._suit = suit;
        }
        
        //Methods+++++++++++++++++++++++++++++++++++
        public void Show()
        {
            Console.WriteLine("{0} of {1}", this._face, this._suit); //Ace of Heart
        }
    }
}
