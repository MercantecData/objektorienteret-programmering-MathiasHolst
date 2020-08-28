using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Jeppe_s_ObjektFraVærelse
{
    class Reol
    {
        private int Rooms;
        private string Color;
        private items Items;

        public Reol(int rooms, string color, items items)
        {
            Rooms = rooms;
            Color = color;
            Items = items;
        }

        public int AddBook(int Books)
        {
            return Books += 1;
        }
    }
}
