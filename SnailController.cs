using System;

namespace SnailController
{
    class SnailController
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        y--;
                        Console.SetCursorPosition(x, y - 2);
                        Console.Write("¢Á");
                        Console.SetCursorPosition(x, y - 1);
                        Console.Write("I");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                        break;

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        y++;
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("¢Á");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("I");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                        break;

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        x++;
                        Console.SetCursorPosition(x + 2, y);
                        Console.Write("¢Á");
                        Console.SetCursorPosition(x + 1, y);
                        Console.Write("_");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        x--;
                        Console.SetCursorPosition(x - 3, y);
                        Console.Write("¢Á");
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("_");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                        break;
                }
            }
        }
    }
}
