
using Tyuiu.SosninFM.Sprint4.Task5.V25.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task5.V25
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			int[,] mas2 = new int[5, 5] {   {1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 } };

			Console.Title = "Спринт #4 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #4                                                               *");
			Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
			Console.WriteLine("* Задание #5                                                              *");
			Console.WriteLine("* Вариант #25                                                             *");
			Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");

			Console.WriteLine("Введите количесвто строк в массиве: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите количесвто столбцов в массиве: ");
			int columns = Convert.ToInt32(Console.ReadLine());

			int[,] mtrx = new int[rows, columns];

			Console.WriteLine("***************************************************************************");

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					mtrx[i, j] = round.Next(-4, 3);
				}
			}

			Console.WriteLine("\nМассив: ");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write($"{mtrx[i, j]} \t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");

			int res = ds.Calculate(mtrx);

			Console.WriteLine("Сумма положительных элементов = " + res);
			Console.ReadKey();


		}
	}
}
