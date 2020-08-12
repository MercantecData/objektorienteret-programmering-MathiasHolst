using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleSystem
{
    public class Room
    {
        private int roomNum;
        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }
        private bool isBooked;
        private Course whoBooked;
        public Room(int roomNum, bool isBooked, Course whoBooked)
        {
            this.roomNum = roomNum;
            this.isBooked = isBooked;
            this.whoBooked = whoBooked;
        }

        public Room(int roomNum, bool isBooked)
        {
            this.roomNum = roomNum;
            this.isBooked = isBooked;
            whoBooked = null;
        }

        public Room(bool isBooked, Course whoBooked)
        {
            roomNum = 0;
            this.isBooked = isBooked;
            this.whoBooked = whoBooked;
        }
    }
}
