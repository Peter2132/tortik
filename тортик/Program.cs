using тортик;


class Tortik
{
        static string strochka = "";
        static int shape = 0; 
        
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Что вы хотите заказать.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. Форма торта ");
                Console.WriteLine("   2. Размер торта");
                Console.WriteLine("   3. Вкус торта");
                Console.WriteLine("   4. Количество коржей");
                Console.WriteLine("   5. Глазурь торта");
                Console.WriteLine("   6. Декор тортов");
                Console.WriteLine("   7. Конец заказа");

                Console.WriteLine($"Цена: {shape}");
                Console.WriteLine($"Вы выбрали: {strochka}");
                
                int selected = Arrow.Show(2, 8);

                if (selected == 2)
                {
                    TypeTorta();
                }
                else if (selected == 3)
                {
                    SizeTorta();
                }
                else if (selected == 4)
                {
                    VkusTorta();
                }
                else if (selected == 5) 
                {
                    Kolichestvo();
                }
                else if (selected == 6) 
                {
                    Glazur();
                }
                else if (selected == 7)
                {
                    
                    Dekor();
                }
                else if (selected == 8)
                {
                    ConsoleKeyInfo key;

                    File.AppendAllText("заказ.txt", "\n Заказ от " + DateTime.Now);
                    File.AppendAllText("заказ.txt", $"\n Заказ: {strochka}");
                    File.AppendAllText("заказ.txt", $"\n Цена: {shape}");


                    Console.Clear();

                    Console.WriteLine("Нажмите клавишу Escape для создания нового заказа.");
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                    {
                        strochka = "";
                        shape = 0;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break; 
                    }
                }

            }
        }
        
        static void TypeTorta()
        {
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите форму торта.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. Квадратный - 100 ");
                Console.WriteLine("   2. Треугольный - 50");
                Console.WriteLine("   3. Круглый - 60");
                Console.WriteLine("    Escape - Назад");
                
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 4)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                    {
                        strochka += "Квадратный; ";
                        shape += 100;
                    }
                    else if (pos == 3)
                    {
                        strochka += "Треугольный; ";
                        shape += 50;
                    }
                    else if (pos == 4)
                    {
                        strochka += "Круглый; ";
                        shape += 60;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);


        }


        static void SizeTorta()
        {
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите размер.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. Маленький - 40 ");
                Console.WriteLine("   2. Средний - 50");
                Console.WriteLine("   3. Большой - 30");
                Console.WriteLine("    Escape - Назад");

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 4)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                    {
                        strochka += "Маленький; ";
                        shape += 40;
                    }
                    else if (pos == 3)
                    {
                        strochka += "Средний; ";
                        shape += 50;
                    }
                    else if (pos == 4)
                    {
                        strochka += "Большой; ";
                        shape += 30;
                    }

                }

            } while (key.Key != ConsoleKey.Escape);

        }

        static void VkusTorta()
        {
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите вкус торта.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. Клубничный - 55 ");
                Console.WriteLine("   2. Шоколадный - 70");
                Console.WriteLine("   3. Банановый - 65");
                Console.WriteLine("   4. Ванильный - 45");
                Console.WriteLine("    Escape - Назад");

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 5)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                    {
                        strochka += "Клубничный; ";
                        shape += 55;
                    }
                    else if (pos == 3)
                    {
                        strochka += "Шоколадный; ";
                        shape += 70;
                    }
                    else if (pos == 4)
                    {
                        strochka += "Банановый; ";
                        shape += 65;
                    }
                    else if (pos == 5)
                    {
                        strochka += "Ванильный; ";
                        shape += 45;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }

        static void Kolichestvo()
        {
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите количество коржей.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. 1 корж - 100 ");
                Console.WriteLine("   2. 2 коржа - 150");
                Console.WriteLine("   3. 3 коржа - 200");
                Console.WriteLine("   Escape - Назад");

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 4)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                    {
                        strochka += "1 корж; ";
                        shape += 100;
                    }
                    else if (pos == 3)
                    {
                        strochka += "2 коржа; ";
                        shape += 150;
                    }
                    else if (pos == 4)
                    {
                        strochka += "3 коржа; ";
                        shape += 200;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }

        static void Glazur()
        {
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите размер.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. Шоколадный - 140 ");
                Console.WriteLine("   2. Бизе - 110");
                Console.WriteLine("   3. Крем - 120");
                Console.WriteLine("    Escape - Назад");

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 4)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                    {
                        strochka += "Шоколадный; ";
                        shape += 140;
                    }
                    else if (pos == 3)
                    {
                        strochka += "Бизе; ";
                        shape += 110;
                    }
                    else if (pos == 4)
                    {
                        strochka += "Крем; ";
                        shape += 120;
                    }

                }

            } while (key.Key != ConsoleKey.Escape);

        }


        static void Dekor()
        {
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите количество коржей.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("   1. Блестки - 130 ");
                Console.WriteLine("   2. Бусины - 160");
                Console.WriteLine("   3. Фигурки из мастики - 180");
                Console.WriteLine("   Escape - Назад");

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 4)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                    {
                        strochka += "Блестки; ";
                        shape += 130;
                    }
                    else if (pos == 3)
                    {
                        strochka += "Бусины; ";
                        shape += 160;
                    }
                    else if (pos == 4)
                    {
                        strochka += "Фигурки из мастики; ";
                        shape += 180;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }
        
    
}

       