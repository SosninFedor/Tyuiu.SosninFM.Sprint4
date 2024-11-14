
using Tyuiu.SosninFM.Sprint4.Task4.V14.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task4.V14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			int[,] mtr = new int[5, 5] { { 3, 4, 3, 4, 1, },
										 { 8, 1, 6, 6, 9, },
										 { 9, 8, 5, 1, 3, },
										 { 1, 8, 7, 1, 2, },
										 { 9, 9, 7, 5, 6, } };

			Console.Title = "Спринт #4 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #4                                                               *");
			Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
			Console.WriteLine("* Задание #4                                                              *");
			Console.WriteLine("* Вариант #14                                                             *");
			Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("Количество строчек и колонок : ");
			int rows = mtr.GetUpperBound(0) + 1;
			int coll = mtr.Length / rows;
			Console.WriteLine(rows + " | " + coll);

			Console.WriteLine("Массив : ");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < coll; j++)
				{
					Console.WriteLine($"{mtr[i, j]} \t");
				}
			}

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("Сумма последних элементов массива : " + ds.Calculate(mtr));
			Console.ReadKey();
		}
	}
}
