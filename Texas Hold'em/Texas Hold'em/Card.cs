using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Hold_em
{
    internal class Card
    {
        private Suit _suit;          //Suit is the first letter of the suit name for example, s for spades and so on
        private int _rank;           //Rank is based on numerical value of the card where jack through ace are the values 11 through 14

        public Suit GetSuit()
        {
            return _suit;
        }

        public void SetSuit(Suit suitIn)
        {
            this._suit = suitIn;
        }

        public int GetRank()
        {
            return _rank;
        }

        public void SetRank(int rankIn)
        {
            this._rank = rankIn;
        }
    }
}
