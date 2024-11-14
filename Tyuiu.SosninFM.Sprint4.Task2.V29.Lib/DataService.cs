﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SosninFM.Sprint4.Task2.V29.Lib
{
	public class DataService : ISprint4Task2V29
	{
		public int Calculate(int[] array)
		{
			int sumArray = 1;

			for (int i = 0; i <= array.Length - 1; i++)
			{
				if (array[i] % 2 == 0)
				{
					sumArray *= array[i];
				}
			}

			return sumArray;
		}
	}
}
