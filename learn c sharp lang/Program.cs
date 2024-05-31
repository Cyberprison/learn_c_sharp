using System;

namespace learn_c_sharp_lang
{
    class Program
    {

        //1. Написать метод Resize изменяющий количество элементов массива(метод должен иметь возможность увеличить или уменьшить количество элементов массива).
        static void Resize<T>(ref T[]mas, int length)
        {
            T[] newMas = new T[length];

            for(int i = 0; i + 1 <= mas.Length && i + 1 <= newMas.Length; i++ )
            {
                newMas[i] = mas[i];
            }

            mas = newMas;
        }

        //2. Написать методы для добавления элемента в начало массива, в конец массива и по указанному индексу.
        static void addELementAtIndex(ref int[]mas, int el, int index)
        {
            int [] newMas = new int[mas.Length + 1];

            //всё в индексах
            for (int i = 0; i < index; i++)
            {
                newMas[i] = mas[i];
            }

            newMas[index] = el;

            for (int i = index; i + 1 <= mas.Length; i++)
            {
                newMas[i + 1] = mas[i];
            }

            mas = newMas;
        }
        static void addEnd(ref int []mas, int el)
        {
            addELementAtIndex(ref mas, 52, mas.Length);
        }
        static void addStart(ref int[] mas, int el)
        {
            addELementAtIndex(ref mas, 52, 0);
        }

        //3. Написать методы для удаления первого элемента массива, последнего элемента массива и элемента по указанному индексу.
        static void deleteFirst(ref int[]mas)
        {
            deleteAtIndex(ref mas, 0);
        }
        static void deleteLast(ref int[]mas)
        {
            deleteAtIndex(ref mas, mas.Length - 1);
        }
        static void deleteAtIndex(ref int[]mas, int index)
        {
            int[] newMas = new int[mas.Length - 1];

            for(int i = 0; i < index; i++)
            {
                newMas[i] = mas[i];
            }

            for(int i = index + 1; i < mas.Length; i++)
            {
                newMas[i - 1] = mas[i];
            }

            mas = newMas;
        }

        static void Main(string[] args)
        {
            //1
            /*
            int[] mas = { };
            Resize(ref mas, 2);
            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
            */

            //2
            /*
            int[] mas = { 2, 4, 6, 8, 0 };
            addELementAtIndex(ref mas, 52, mas.Length);
            foreach (var item in mas)
            {
                Console.Write($"{item} ");
            }
            */

            //3
            int[] mas = { 2, 4, 6, 8, 0 };
            //deleteAtIndex(ref mas, mas.Length - 1);
            deleteLast(ref mas);
            foreach (var item in mas)
            {
                Console.Write($"{item} ");
            }

            //костыль
            Console.ReadLine();
        }
    }
}
