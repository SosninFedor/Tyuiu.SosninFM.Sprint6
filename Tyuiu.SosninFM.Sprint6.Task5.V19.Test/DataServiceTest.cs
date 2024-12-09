using Tyuiu.SosninFM.Sprint6.Task5.V19.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task5.V19.Test
{
	[TestClass]
	public sealed class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint6\Sprint6Task6\InPutDataFileTask6V19.txt";
			FileInfo info = new FileInfo(path);
			bool res = info.Exists;
			bool wait = true;
			Assert.AreEqual(wait, res);


		}
	}
}
