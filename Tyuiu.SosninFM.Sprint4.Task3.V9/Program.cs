
using Tyuiu.SosninFM.Sprint4.Task3.V9.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task3.V9
{
	internal class Program
	{
		static void Main(string[] args)
		{

			DataService ds = new DataService();

			Console.Title = "Спринт #4 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #4                                                               *");
			Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
			Console.WriteLine("* Задание #3                                                              *");
			Console.WriteLine("* Вариант #9                                                              *");
			Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
			Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
			Console.WriteLine("*                                                                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");
			int[,] array = new int[5, 5] { { 9, 6, 4, 5, 3 },
										   { 7, 4, 7, 5, 3 },
										   { 8, 5, 9, 9, 3 },
										   { 7, 8, 7, 9, 3 },
										   { 3, 7, 3, 7, 7 } };
			int rows = array.GetUpperBound(0) + 1;
			int columns = array.Length / rows;

			Console.WriteLine("Массив: ");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write($"{array[i, j]} \t");
				}

				Console.WriteLine();

			}

			Console.WriteLine();

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("Сумма элементов во втором столбце массива = " + ds.Calculate(array));

			Console.ReadKey();



		}
	}
}
