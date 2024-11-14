
using Tyuiu.SosninFM.Sprint4.Task5.V25.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task5.V25.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalculate()
		{
			DataService ds = new DataService();
			int[,] mas2 = new int[5, 5] {   {1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 },
											{1, -1, 1, 1, -1 } };
			int res = ds.Calculate(mas2);
			int wait = 5;

			Assert.AreEqual(res, wait);
		}
	}
}
