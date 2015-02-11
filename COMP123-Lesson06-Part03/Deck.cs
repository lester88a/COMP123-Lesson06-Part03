using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson06_Part03
{
    class Deck
    {
        //Insatnce variables+++++++++++++++++++++++
        private Card[] _cards = new Card[52];
       
        //Constructor+++++++++++++++++++++++++++++++
        public Deck()
        {
            this._buildDeck();
        }

        //Private Methods++++++++++++++++++++++++
        private void _addCard(int card,int face,string suit)
        {
            this._cards[card] = new Card(face, suit);
        }

        //Build deck
        private void _buildDeck()
        {
            string[] suits = { Suits.CLUBS, Suits.DIAMONDS, Suits.HEARTS, Suits.SPADES };
            //int[] faces = { Face.ACE, Face.TWO,Face.THREE,Face.FOUR,Face.FIVE};
            for (int i = 0; i < suits.Length; i++)
            {
                for (int fc = 1; fc < 14; fc++)
                {
                    this._addCard(i, fc, suits[i]);
                }
                
            }
            this._addCard(0, Face.ACE, Suits.HEARTS);
        }

        //Public Methods++++++++++++++++++++++
        public string pickCard(int card)
        {

            return this._cards[card].ToString();
        }

    }
}
