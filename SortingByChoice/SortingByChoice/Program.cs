using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingByChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 9, 5, 12, 3, 65, 21 };
            int[] numbers = new[] { 1, 3, 6, 9, 12, 3 };

            int x1 = FindSmallest(array);
            int x2 = FindSmallest(numbers);
            int[] x3 = SortArray(array);
            string s = string.Join(",", x3);

            Console.WriteLine(x1 + "-" + x2);
            Console.Write(s);
            Console.ReadKey();
        }

        // Метод находит наименьшее число массива
        static int FindSmallest(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        // Метод сортирует массив используя метод "FindSmallest"
        static int[] SortArray(int[] sort)
        {
            //Создаём список для записи отсортированых данных
            List<int> number = new List<int>();
            List<int> list = sort.ToList();

            int n = sort.Length;

            for (int i = 0; i < n; i++)
            {
                int min = FindSmallest(sort);
                number.Add(min);

                // Преобразуем массив в строку и удаляем наименьший элемент
                list.Remove(min);
                sort = list.ToArray();
            }

            int[] result = number.ToArray();

            return result;
        }

    }
}
