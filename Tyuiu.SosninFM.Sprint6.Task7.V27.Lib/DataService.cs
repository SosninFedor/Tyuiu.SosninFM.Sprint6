
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SosninFM.Sprint6.Task7.V27.Lib
{
	public class DataService : ISprint6Task7V27
	{
		public int[,] GetMatrix(string path)
		{
			string filedata = File.ReadAllText(path);
			filedata = filedata.Replace('\n', '\r');
			string[] line = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
			int row = line.Length;
			int colm = line[0].Split(';').Length;
			int[,] arrval = new int[row, colm];

			for (int r = 0; r < row; r++)
			{
				string[] line_r = line[r].Split(';');
				for (int c = 0; c < colm; c++)
				{
					arrval[r, c] = Convert.ToInt32(line_r[c]);
				}
			}


			for (int j = 0; j < colm; j++)
			{
				if (arrval[4, j] < 0)
				{
					arrval[4, j] = -1;
				}
			}

			return arrval;
		}
	}
}
