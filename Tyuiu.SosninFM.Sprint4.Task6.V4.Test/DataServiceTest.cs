
using Tyuiu.SosninFM.Sprint4.Task6.V4.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task6.V4.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalculate()
		{
			DataService ds = new DataService();

			var array = new string[] { "������", "����� ���������", "�����������", "������������", "������ ��������", "���������", "������" };
			string[] res = ds.Calculate(array);
			string[] wait = { "������", "������" };
			CollectionAssert.AreEqual(wait, res);



		}
	}
}