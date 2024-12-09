
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SosninFM.Sprint6.Task1.V27.Lib
{
	public class DataService : ISprint6Task1V27
	{
		public double[] GetMassFunction(int startValue, int stopValue)
		{
			double[] valueWaitArray;
			int len = (stopValue - startValue) + 1;
			valueWaitArray = new double[len];
			double y;
			double b;
			int count = 0;
			for (int x = startValue; x <= stopValue; x++)
			{ 
				b = 4 - 2 * x + ((2 + Math.Cos(x) / (2 * x - 2)));
				y = Math.Round(b, 2);
				valueWaitArray[count] = y;
				count++;
			}
			return valueWaitArray;



		}
	}
}
