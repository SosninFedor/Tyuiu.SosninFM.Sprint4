
using Tyuiu.SosninFM.Sprint4.Task2.V29.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task2.V29.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void Calculate()
		{
			DataService ds = new DataService();

			int[] numsArray = {8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2};
			int res = ds.Calculate(numsArray);
			int wait = 32768;
			Assert.AreEqual(wait, res);


		}
	}
}