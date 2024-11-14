
using Tyuiu.SosninFM.Sprint4.Task2.V29.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task2.V29
{
	internal class Program
	{
		static void Main(string[] args)
		{

			DataService ds = new DataService();
			Random rnd = new Random();
			Console.Title = "Спринт #4 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #4                                                               *");
			Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
			Console.WriteLine("* Задание #2                                                              *");
			Console.WriteLine("* Вариант #29                                                             *");
			Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
			Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
			Console.WriteLine("*                                                                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");

			int len;
			Console.WriteLine("введите кол-во элементов массива: ");
			len = Convert.ToInt32(Console.ReadLine());

			int[] numsArray = new int[len];

			for (int i = 0; i <= len; i++)
			{
				numsArray[i] = rnd.Next(1,8);
			}

			Console.WriteLine("Массив:");
			for (int i = 0;i <= len; i++)
			{
                Console.WriteLine(numsArray[i] + "\t");
			}

            Console.WriteLine();
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");

			int res = ds.Calculate(numsArray);
            Console.WriteLine("Произведение четных элементов массива: " + res);
			Console.ReadKey();

		}
	}
}
