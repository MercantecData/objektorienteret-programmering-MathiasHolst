using System;
using System.Collections.Generic;
using System.Text;

namespace Jeppe_s_ObjektFraVærelse
{
    class items
    {
        private int Books;
        private int PlayingCards;
        private int Chips;
        private bool Liquor;
        public int books   // property
        {
            get { return Books; }   // get method
            set { books = value; }  // set method
        }

        public items(int books, int playingCards, int chips, bool liquor)
        {
            Books = books;
            PlayingCards = playingCards;
            Chips = chips;
            Liquor = liquor;
        }
    }
}
