using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class MazeBuilder
    {
        OuterWall ow = new OuterWall();
        InteriorWall iw = new InteriorWall();
        private char oh = ow.HorInterWall;
        private char ov = ow.VertInterWall;
        private char ih = iw.HorInterWall;
        private char iv = iw.VertInterWall;
        private char[,] mazePattern = new char[,]
            {
                {oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {ov,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,iv,ov},
                {oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh,oh}
            };
        public void CreateMaze()
        {
            new MazeBuilder();
        }
    }
}
