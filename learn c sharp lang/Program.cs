using System;

namespace learn_c_sharp_lang
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Напишите программу, вычисляющую среднее арифметическое двух чисел.
            2.Введите три числа и выведите на экран значение суммы и произведения этих чисел.
            3.Напишите простой конвертер валют(без возможности динамического выбора валюты пользователем).
            Валюты заданы хардкодом и не изменяются.Тип валют на выбор программиста.
            */

            int x = 3;
            int y = 4;
            double mean = (x + y) / 2.0;
            Console.WriteLine(mean);

            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int sum, mult;
            sum = a + b + c;
            mult = a * b * c;
            Console.WriteLine(sum + " " + mult);

            int rub = 52;
            double rubToUsd = rub / 100.0;
            Console.WriteLine(rubToUsd);

            //костыль
            Console.ReadLine();
        }
    }
}
