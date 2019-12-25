using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosachev1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Объявляем переменные sum и average, они будут хранить результат
            double sum = 0;
            double average = 0;

            //переменные для работы с пользовательским вводом
            int n;
            string nStr;

            double radius;
            string radiusStr;

            //Получаем от пользователя число для подстановки в формулу
            Console.WriteLine("Лабораторная работа №1. Вариант 20");
            Console.WriteLine("Введите любое целое число - количество шаров, например 2");
            nStr = Console.ReadLine();

            Console.WriteLine("Введите  число - начальный радиус");

            radiusStr = Console.ReadLine();


            //Проверяем, число ли ввел пользователь
            if (int.TryParse(nStr, out n) && double.TryParse(radiusStr, out radius))
            {

                for (int i = 0; i < n; i++)
                {
                    double v;
                    v = 4 * Math.PI * (radius * (1 + 0.2 * i) * radius * (1 + 0.2 * i) * radius * (1 + 0.2 * i)) / 3;
                    sum = sum + v;
                }
                average = sum / n;

                Console.WriteLine("Сумма: {0}", sum);
                Console.WriteLine("Ср.значение: {0}", average);

            }
            else
            {
                Console.WriteLine("Вы ввели не число. Я чуть не сломался вообще-то!");
            }




            Console.Read();
        }
    }
}
