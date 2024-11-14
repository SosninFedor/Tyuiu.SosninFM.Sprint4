
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SosninFM.Sprint4.Task5.V25.Lib
{
	public class DataService : ISprint4Task5V25
	{
		public int Calculate(int[,] matrix)
		{
			{
				int rows = matrix.GetLength(1);         //столбцы
				int columns = matrix.GetLength(0);     //строки

				int count = 0;

				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						if (matrix[i, j] > 0)
						{
							count += matrix[i, j];
						}
					}
				}
				return count;
			}

		}
	}
}
