
using Tyuiu.SosninFM.Sprint4.Task0.V11.Lib;

namespace Tyuiu.SosninFM.Sprint4.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] nums = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetMultOddArrEl(nums);
            int wait = 30;
            Assert.AreEqual(wait, res);


        }
    }
}