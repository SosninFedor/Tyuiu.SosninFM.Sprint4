
using Tyuiu.SosninFM.Sprint4.Task7.V26.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task7.V26
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
			Console.WriteLine("* Задание #7                                                              *");
			Console.WriteLine("* Вариант #26                                                             *");
			Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");


			int rows = 5; int cols = 3;
			int[,] mtrx = new int[rows, cols];
			string str = "351268459614723";

			int index = 0;

			Console.WriteLine("\nМассив:");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{str[index]} \t");
					index++;
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");
			int res = ds.Calculate(rows, cols, str);
			Console.WriteLine("Произведение чётных элементов = " + res);

			Console.ReadKey();
		}
	}
}
