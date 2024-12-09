using Tyuiu.SosninFM.Sprint6.Task5.V19.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task5.V19
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}
		DataService ds = new DataService();
		string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint6\Sprint6Task6\InPutDataFileTask6V19.txt";

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonDone_SVA_Click(object sender, EventArgs e)
		{
			dataGridViewOutPut_SVA.ColumnCount = 2;
			dataGridViewOutPut_SVA.Columns[0].Width = 20;
			dataGridViewOutPut_SVA.Columns[1].Width = 50;

			this.chartDiag_SVA.ChartAreas[0].AxisX.Title = "Ось X";
			this.chartDiag_SVA.ChartAreas[0].AxisY.Title = "Ось Y";

			chartDiag_SVA.Series[0].Points.Clear();

			double[] numsMass = new double[ds.len];
			numsMass = ds.LoadFromDataFile(path);

			for (int i = 0; i < numsMass.Length; i++)
			{
				dataGridViewOutPut_SVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
				chartDiag_SVA.Series[0].Points.AddXY(i, numsMass[i]);
			}
		}
		private void buttonHelp_SVA_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 5 выполнил студент группы АСОиУб 24-1 Соснин Федор Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonOpenFile_SAS_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process txt = new System.Diagnostics.Process();
			txt.StartInfo.FileName = "notepad.exe";
			txt.StartInfo.Arguments = path;
			txt.Start();
		}
	}
}
