using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class NewMaze
    {
        public const int MAZE_SIZE = 5;
        //private InteriorWallBuilder intWall = new InteriorWallBuilder();
        //private OuterWallBuilder outWall = new OuterWallBuilder();

        //public OuterWallBuilder OutWallB
        //{
        //    get { return outWall; }
        //    set { outWall = value; }
        //}
        //public InteriorWallBuilder IntWallB
        //{
        //    get { return intWall; }
        //    set { intWall = value; }
        //}
        private int[,] mazePattern = new int[MAZE_SIZE, MAZE_SIZE]
            {
                {1,1,1,1,1},
                {3,4,2,2,3},
                {3,2,4,2,3},
                {3,2,2,4,3},
                {1,1,1,1,1}
            }; 
        private Wall[,] mazeWalled = new Wall[MAZE_SIZE, MAZE_SIZE];
        public Wall[,] MazeWalled
        {
            get { return MazeWalled; }
            set
            {
                for (int i = 0; i < MAZE_SIZE; i++)
                {
                    for (int j = 0; j < MAZE_SIZE; j++)
                    {
                        InteriorWallBuilder iWB = new InteriorWallBuilder();
                        iWB.SetVertOutWall('I');
                        iWB.SetHorizOutWall('>');
                        Wall iWall = iWB.CreateWall();
                        OuterWallBuilder oWB = new OuterWallBuilder();
                        oWB.SetHorizIntWall('_');
                        oWB.SetVertIntWall('|');
                        Wall oWall = oWB.CreateWall();
                        if (mazePattern[i, j] == 1) { mazeWalled[i, j] = oWall; }
                        if (mazePattern[i, j] == 3) { mazeWalled[i, j] = oWall; }
                        if (mazePattern[i, j] == 2) 
                        {
                            iWall.SetHP(39);
                            mazeWalled[i, j] = iWall;
                        }
                        if (mazePattern[i, j] == 4) 
                        {
                            iWall.SetHP(39);
                            mazeWalled[i, j] = iWall; 
                        }
                    }
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < MAZE_SIZE; i++)
            {
                for (int j = 0; j < MAZE_SIZE; j++)
                {
                    if (mazePattern[i, j] == 1 || mazePattern[i, j] == 2)
                        result += (mazeWalled[i, j].HorWall);
                    else if (mazePattern[i, j] == 3 || mazePattern[i, j] == 4)
                        result += (mazeWalled[i, j].VertWall);
                }
                result += "\n";
            }
            return result;
        }
    }
}
