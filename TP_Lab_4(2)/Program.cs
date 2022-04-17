using System;
using System.Text;

namespace TP_Lab_4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.CursorVisible = false;
            ////ввод
            //int[,] maze = new int[,]
            //{
            //    {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
            //    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,1,2,2,2,2,2,2,0,0,0,0,0,0,0,1},
            //    {1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,1,3,3,3,3,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            //    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            //    {3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3}
            //};
            ////координаты игрока
            //int x = 1, y = 1;
            Maze maze = new Maze();
            //рисуем лабиринт
            Console.Clear();
            for (int i = 0; i < maze.mazePattern.GetLength(0); i++)
            {
                for (int j = 0; j < maze.mazePattern.GetLength(1); j++)
                {
                    Console.Write(maze.mazePattern[i, j]);
                }
                Console.WriteLine();
            }
            //    Console.CursorLeft = x;
            //    Console.CursorTop = y;
            //    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //    Console.Write("@");
            //    Console.BackgroundColor = ConsoleColor.Cyan;
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    Console.BackgroundColor = ConsoleColor.Black;

            //    // обработка ввода
            //    ConsoleKeyInfo ki = Console.ReadKey(true);
            //    if (ki.Key == ConsoleKey.Escape) break;
            //    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 0) x--;
            //    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 0) x++;
            //    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 0) y--;
            //    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 0) y++;

        }
    }
}

