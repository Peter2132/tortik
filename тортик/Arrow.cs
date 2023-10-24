using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тортик
{
    public class Arrow
    {
        public static int Show(int min, int max)
        {
            {
                int pos = 2;
                ConsoleKeyInfo key;

                do
                {
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");

                    if (key.Key == ConsoleKey.UpArrow && pos != 2)
                    {
                        pos--;
                        if (pos == 2)
                        {

                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow && pos != 8)
                    {
                        pos++;

                    }
                } while (key.Key != ConsoleKey.Enter);
                return pos;
            }
        }
    }

    
      

}
