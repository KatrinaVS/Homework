using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую цифру!");
            var variadle = Console.ReadLine(); //вводим первую цифру
            Console.WriteLine("Введите вторую цифру!");
            var variadl = Console.ReadLine(); //вводим вторую цифру

            Console.WriteLine("Еще цифра!");
            string selection = Console.ReadLine();

            int x = Int32.Parse(variadle);
            int a = Int32.Parse(variadl);

            int c = x + a; // математические примеры
            int b = x * a;
            var e = (double)x / a;
            var ef = (decimal)x / a;
            var ed = (float)x / a;
            int r = x - a;

            Console.WriteLine("Сложение");
            Console.WriteLine(c);
            Console.WriteLine("Умножение");
            Console.WriteLine(b);
            Console.WriteLine("Деление doudle");
            Console.WriteLine(e);
            Console.WriteLine("Деление decimal");
            Console.WriteLine(ef);
            Console.WriteLine("Деление float");
            Console.WriteLine(ed);
            Console.WriteLine("Вычитание");
            Console.WriteLine(r);


            Console.WriteLine("Условная конструкция if/else!");
            if (x > a) // условная конструкция if/else
            {
                Console.WriteLine($"Число {x} больше числа {a}");
            }
            else if (x < a)
            {
                Console.WriteLine($"Число {x} меньше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {x} равно числу {a}");
            }


            Console.WriteLine("Условная конструкция switch/case!");
            switch (selection)// условная конструкция switch/case
            {
                case "0":
                    Console.WriteLine("1");
                    break;
                case "1":
                    Console.WriteLine("A");
                    break;
                case "2":
                    Console.WriteLine("I");
                    break;
                case "9":
                    Console.WriteLine("Выход");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.ReadKey();

        }
    }
}