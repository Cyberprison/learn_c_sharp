using System;

namespace learn_c_sharp_lang
{
    class Program
    {
        //почему мы все методы сделали статическими?

        //3. найти сумму цифр числа при помощи рекурсии
        static int sumDigit(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else
            {
                return number % 10 + sumDigit(number / 10);
            }
        }

        //2. найти сумму элементов массива при попомщи рекурсии
        static int sumMasElements(int[]mas, int index = 0)
        {
            if (mas.Length <= index)
            {
                return 0;
            }
            else
            {
                return mas[index] + sumMasElements(mas, index + 1);
            }
        }

        //1. реализовать вывод массива при помощи рекурсии
        static void outputMasRecursion(int[]mas, int index = 0)
        {
            if (mas.Length > index)
            {
                Console.Write(mas[index] + " ");
                outputMasRecursion(mas, index + 1);
            }
        }

        static void Main(string[] args)
        {
            //3
            //Console.WriteLine(sumDigit(123456789));

            //2 
            //int [] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(sumMasElements(mas));

            //1 
            int [] mas = { 1 };
            outputMasRecursion(mas);

            //костыль
            Console.ReadLine();
        }
    }
}
