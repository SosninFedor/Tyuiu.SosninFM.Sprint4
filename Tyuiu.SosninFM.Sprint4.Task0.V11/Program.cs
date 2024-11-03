
using System.Runtime.Serialization.Formatters;
using Tyuiu.SosninFM.Sprint4.Task0.V11.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Массивы в С#                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов,, заполненный значе-*");
            Console.WriteLine("* ниями от 0 до 9. Подсчитать произвдение нечетных элементов массива:     *");
            Console.WriteLine("* {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.GetMultOddArrEl(numsArray);

            Console.WriteLine("Произведение всех нечетных чисел равно:" + res);

            Console.ReadKey();




        }
    }
}
