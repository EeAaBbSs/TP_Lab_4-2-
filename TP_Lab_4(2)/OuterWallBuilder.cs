using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class OuterWallBuilder : WallBuilder
    {
        public override Wall CreateWall()
        {
            Wall = new OuterWall();
            return Wall;
        }

        public override void SetHorizIntWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetVertIntWall(char b)
        {
            Wall.VertWall = b;
        }

        public override void SetHorizOutWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetVertOutWall(char b)
        {
            Wall.VertWall = b;
        }
    }
}
