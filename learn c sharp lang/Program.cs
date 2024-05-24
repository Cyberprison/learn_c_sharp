using System;

namespace learn_c_sharp_lang
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            проверка на четность
            */

            if (int.Parse(Console.ReadLine()) % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечетное");
            }
            

            //костыль
            Console.ReadLine();
        }
    }
}
