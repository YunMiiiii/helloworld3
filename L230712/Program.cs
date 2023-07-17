using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L230712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] map = {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };

            int playerX = 1;
            int playerY = 1;

            while (true)
            {

                //Input();
                ConsoleKeyInfo info = Console.ReadKey(true); //입력에서 키만 받아올거고

                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:

                        if (map[playerY, playerX - 1] != 1)
                        {
                            playerX--;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (map[playerY, playerX + 1] != 1)
                        {
                            playerX++;
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        if (map[playerY - 1, playerX] != 1)
                        {
                            playerY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[playerY + 1, playerX] != 1)
                        {
                            playerY++;
                        }
                        break;

                }

                Console.Clear();


                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {

                        if (playerX == x && playerY == y)       //현재 그린 위치에 플레이어가 있으면 그린다는 뜻?
                        {
                            Console.Write("P" + " ");
                        }
                        else if (map[y, x] == 1)                //맵을 그린다
                        {
                            Console.Write("*" + " ");
                        }
                        else if (map[y, x] == 0)
                        {
                            Console.Write(" " + " ");
                        }
                        else
                        {

                        }


                    }
                    Console.WriteLine();
                }

            }
        
    }
    }
}
