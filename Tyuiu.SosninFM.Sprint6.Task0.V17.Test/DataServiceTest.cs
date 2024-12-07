
using Tyuiu.SosninFM.Sprint6.Task0.V17.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task0.V17.Test
{
	[TestClass]
	public sealed class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();
			double res = ds.Calculate(7, 8, 9);#
			double wait = 0;
			Assert.AreEqual(res, wait);




		}
	}
}
