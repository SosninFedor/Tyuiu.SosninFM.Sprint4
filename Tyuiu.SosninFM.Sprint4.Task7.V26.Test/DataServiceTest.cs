
using Tyuiu.SosninFM.Sprint4.Task7.V26.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task7.V26.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalculate()
		{
			int rows = 5;
			int cols = 3;
			int[,] matrix = new int[rows, cols];
			string str = "351268459614723";
			DataService ds = new DataService();
			int res = ds.Calculate(rows, cols, str);
			int wait = 18432;
			Assert.AreEqual(wait, res);

		}
	}
}