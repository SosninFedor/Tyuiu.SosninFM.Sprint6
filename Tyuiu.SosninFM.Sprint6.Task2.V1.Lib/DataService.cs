namespace Tyuiu.SosninFM.Sprint6.Task2.V1.Lib
{
	public class DataService
	{
		public double[] GetMassFunction(int startValue, int stopValue)
		{
			double[] valueArray;
			int len = (stopValue - startValue) + 1;
			valueArray = new double[len];
			double y;
			int count = 0;
			for (int x = startValue; x <= stopValue; x++)
			{
				int z = (2 * x - 2);
				if (z == 0)
				{
					valueArray[count] = 0;
				}
				else
				{
					y = (Math.Cos(x) + ((Math.Sin(x)) / (2 - 2 * x)) - 4 * x);
					valueArray[count] = Math.Round(y, 2);
				}
				count++;
			}
			return valueArray;
		}
	}
}

