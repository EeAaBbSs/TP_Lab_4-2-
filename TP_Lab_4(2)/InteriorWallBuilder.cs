using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class InteriorWallBuilder : WallBuilder
    {
        public override Wall CreateWall()
        {
            Wall = new InteriorWall();
            return Wall;
        }

        public override void SetHorizIntWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetHorizOutWall(char b)
        {
            Wall.HorWall = b;
        }

        public override void SetVertIntWall(char b)
        {
            Wall.VertWall = b;
        }

        public override void SetVertOutWall(char a)
        {
            Wall.VertWall = a;
        }
    }
}
