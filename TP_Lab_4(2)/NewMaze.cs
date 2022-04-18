using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class NewMaze
    {
        public const int MAZE_SIZE = 15;
        private InteriorWallBuilder intWall = new InteriorWallBuilder();
        private OuterWallBuilder outWall = new OuterWallBuilder();

        public OuterWallBuilder OutWallB
        {
            get { return outWall; }
            set { outWall = value; }
        }
        public InteriorWallBuilder IntWallB
        {
            get { return intWall; }
            set { intWall = value; }
        }
        private char[,] mazePattern = new char[MAZE_SIZE, MAZE_SIZE]
            {
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'3','4','2','2','2','2','2','2','2','2','2','2','2','2','3'},
                {'3','2','4','2','2','2','2','2','2','2','2','2','2','2','3'},
                {'3','2','2','4','2','2','2','2','2','2','2','2','2','2','3'},
                {'3','2','2','2','4','2','2','2','2','2','2','4','2','2','3'},
                {'3','2','2','2','2','4','2','2','2','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','4','2','2','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','4','2','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','2','4','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','2','2','4','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','2','2','2','4','2','2','2','3'},
                {'3','2','2','4','2','2','2','2','2','2','2','4','2','2','3'},
                {'3','2','2','2','2','2','2','2','2','2','2','2','4','2','3'},
                {'3','2','2','2','2','2','2','2','2','2','2','2','2','4','3'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'}
            };
        public char[,] MazePattern
        {
            get { return mazePattern; }
            set
            {
                for (int i = 0; i < MAZE_SIZE; i++)
                {
                    for (int j = 0; j < MAZE_SIZE; j++)
                    {
                        if (mazePattern[i, j] == '1') { mazePattern[i, j] = OutWallB.Wall.VertWall; }
                        if (mazePattern[i, j] == '3') { mazePattern[i, j] = OutWallB.Wall.HorWall; }
                        if (mazePattern[i, j] == '2') { mazePattern[i, j] = IntWallB.Wall.HorWall; }
                        if (mazePattern[i, j] == '4') { mazePattern[i, j] = IntWallB.Wall.VertWall; }
                    }
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    result += Convert.ToString(MazePattern[i, j]);
                }
                result += "\n";
            }
            return result;
        }
    }
}
