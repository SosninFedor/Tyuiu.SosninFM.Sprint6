using Tyuiu.SosninFM.Sprint6.Task3.V7.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task3.V7
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		DataService ds = new DataService();
		int[,] mtrx = new int[5, 5] { { 31, 25, -18, 12, 9 },
											{ 6, 34, -2, 2, -18  },
											{ -5, 4, 27, 4, -1   },
											{ 4, 15, 34, -6, -10 },
											{ 0, 8, 5, 14, -17   } };
		private void buttonDone_YDS_Click(object sender, EventArgs e)
		{

			int[,] res = ds.Calculate(mtrx);
			int rows = mtrx.GetUpperBound(0) + 1;
			int columns = mtrx.Length / rows;

			dataGridViewResult_YDS.ColumnCount = columns;
			dataGridViewResult_YDS.RowCount = rows;

			for (int i = 0; i < columns; i++)
			{
				dataGridViewResult_YDS.Columns[i].Width = 25;
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					dataGridViewResult_YDS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
				}
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void buttonHelp_YDS_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Янголенко Данил Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
