//******************************
//* практическая работа №5     *
//* Выполнил: Ханов Артур      *
//******************************
using System;

namespace PR_5
{
    class Program
    {
        static void Main(string[] args)

        {
            int a, b, c, x, y;// объявление переменных

            Console.WriteLine("практическая работа №5");
            Console.WriteLine("введите стороны кирпича");
            Console.Write("введите а= ");// ввод данных
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите с= ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите стороны отверстия ");
            Console.Write("введите x= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите y= ");
            y = Convert.ToInt32(Console.ReadLine());

            if (a * b * c <= x * y) // проверяем войдет ли кирпич в отверстие
            {
                Console.WriteLine("вывод: кирпич вошел в отверстие");
            }
            else Console.WriteLine("вывод: кирпич не вошел в отвертие");
            Console.ReadKey();



        }
    }
}
