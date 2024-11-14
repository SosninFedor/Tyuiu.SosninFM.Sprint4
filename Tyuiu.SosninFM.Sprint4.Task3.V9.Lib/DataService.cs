
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SosninFM.Sprint4.Task3.V9.Lib
{
	public class DataService : ISprint4Task3V9
	{
		public int Calculate(int[,] array)
		{
			int rows = array.GetUpperBound(0) + 1;        //строки
			int columns = array.Length / rows;           //столбцы 

			int count = 0;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					if (j == 1)
					{
						count += array[i, j];
					}
				}
			}

			return count;
		}
	}
}
