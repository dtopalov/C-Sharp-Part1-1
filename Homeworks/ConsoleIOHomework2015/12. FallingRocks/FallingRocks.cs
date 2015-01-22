using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallingRocks
{
    static Random rnd = new Random();
    struct Rock
    {
        public int X;
        public int Y;
        public char Shape;
        public ConsoleColor Color;

        public Rock(int x, int y, char shape, ConsoleColor color)
        {
            X = x;
            Y = y;
            Shape = shape;
            Color = color;
        }
    }

    struct Pad
    {
        public int X;

        public Pad(int x)
        {
            this.X = x;
        }
    }

    static void Main()
    {
        Rock[] rocks = new Rock[31];
        int count = 0;
        Console.CursorVisible = false;
        Pad pad = new Pad(30);
        int score = 0;
        int speed = 1;

        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 62; j++)
            {
                if (j == 0 || j == 61)
                {
                    Console.Write(" |");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(65, 5);
        Console.WriteLine("SCORE: 0");

        while (true)
        {
            Console.SetCursorPosition(pad.X, 29);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(0)");

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (pad.X>2 && pad.X < 60)
                    {
                        Console.SetCursorPosition(pad.X, 29);
                        pad.X++;
                        Console.Write(" (0)"); 
                    }
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (pad.X > 2 && pad.X < 60)
                    {
                        Console.SetCursorPosition(pad.X - 1, 29);
                        pad.X--;
                        Console.Write("(0) ");
                    }
                }
            }
            
            Rock rockTest = new Rock(RandomGen(2, 63), 0, RandomChar(), RandomColor());
            rocks[count] = rockTest;
            for (int i = 0; i <= 30; i++)
            {
                if (rocks[i].Y <= 30)
                {
                    MoveRock(rocks[i]);
                    if (rocks[i].X >= pad.X && rocks[i].X < pad.X + 3 && rocks[i].Y == 29)
                    {
                        Console.SetCursorPosition(27, 14);
                        Console.WriteLine(new string('*', 13));
                        Console.SetCursorPosition(27, 15);
                        Console.WriteLine("* GAME OVER *");
                        Console.SetCursorPosition(27, 16);
                        Console.WriteLine(new string('*', 13));
                        Console.SetCursorPosition(27, 17);
                        return;
                    }
                    rocks[i].Y++;
                    if (rocks[i].Y == 31)
                    {
                        score++;
                    }
                }
            }

            count++;
            if (count == 31)
            {
                count = 0;
            }

            Console.SetCursorPosition(72, 5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(score);
            if (score > 99 && score%100 == 0)
            {
                speed += 5;
            }
            Thread.Sleep(200 - speed);
        }
    }

    static void MoveRock(Rock rock)
    {
        if (rock.Y > 0 && rock.Y <= 30)
        {
            Console.SetCursorPosition(rock.X, rock.Y - 1);
            Console.Write(" ");
        }    
        if (rock.Y < 30)
        {
            Console.SetCursorPosition(rock.X, rock.Y);
            Console.ForegroundColor = rock.Color;
            Console.Write(rock.Shape);
        }
    }

    static int RandomGen(int x, int y)
    {
        int rndNumber = rnd.Next(x, y);
        return rndNumber;
    }

    private static char RandomChar()
    {
        char[] rocksShapes = {'@', '#', '*', '%', 'W'};
        char currentRockShape = rocksShapes[RandomGen(0, 5)];
        return currentRockShape;
    }

    private static ConsoleColor RandomColor()
    {
        ConsoleColor[] colors =
        {
            ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.White,
            ConsoleColor.Red
        };
        ConsoleColor currentColor = colors[RandomGen(0, 5)];
        return currentColor;
    }
}

