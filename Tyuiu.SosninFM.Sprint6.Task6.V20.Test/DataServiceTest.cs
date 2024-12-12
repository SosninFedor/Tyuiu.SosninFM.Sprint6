using Tyuiu.SosninFM.Sprint6.Task6.V20.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task6.V20.Test
{
	[TestClass]
	public sealed class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();
			string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint6\Tyuiu.SosninFM.Sprint6.Task6.V20\bin\Debug\InPutDataFileTask6V20.txt";
			string res = ds.CollectTextFromFile(path);
			string wait = "dKOPBC IqjpIlKAaSCBuaQUU JPPzrPC FPsrQHsImzbTBckw NgAfitECn";
			Assert.AreEqual(wait, res);
		}
	}
}
