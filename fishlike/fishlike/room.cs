using System;
using System.Collections.Generic;
using System.Text;

namespace fishlike
{
    class cell
    {
        public enum rT
        {
            empty,
            enemy,
            item,
            boss,
            rest,
            centre
        }
        private int[] pos_;
        private bool complete_, hasPlayer_;
        private rT roomType_;

        public int[] pos { get { return pos_; } set { pos_ = value; } }
        public bool complete { get { return complete_; } set { complete_ = value; } }
        public bool hasPlayer { get { return hasPlayer_; } set { hasPlayer_ = value; } }
        public rT roomType { get { return roomType_; } set { roomType_ = value; } }


        public cell(int[] p)
        {
            pos = p;
            complete = false;
            hasPlayer = false;
            roomType = rT.empty;
        }
        public virtual void roomFunction() { }
    }

    class enemyRoom : cell
    {
        public enemyRoom(int[] p) : base(p)
        { 
            roomType = rT.enemy;
        }

        public override void roomFunction()
        {
            if (hasPlayer)
            {
                Console.WriteLine("combat");
            }
            else
            {
                Console.WriteLine("player isnt here lol");
            }
        }

    }
    class itemRoom : cell
    {
        public itemRoom(int[] p) : base(p)
        {
            roomType = rT.item;
        }
    }
}
