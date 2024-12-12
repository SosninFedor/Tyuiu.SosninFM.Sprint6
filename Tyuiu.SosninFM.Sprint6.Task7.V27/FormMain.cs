using System.Windows.Forms;
using Tyuiu.SosninFM.Sprint6.Task7.V27.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task7.V27
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}
		{
    public partial class Form1 : Form
		{
			public Form1()
			{
				InitializeComponent();
				openFileDialogTask.Filter = "Çíà÷åíèÿ ðàçäåë¸ííûå çàïÿòûìè(*.scv)|*.csv|Âñå ôàéëû(*.*)|(*.*)";
				saveFileDialogMatrix.Filter = "Çíà÷åíèÿ ðàçäåë¸ííûå çàïÿòûìè(*.scv)|*.csv|Âñå ôàéëû(*.*)|(*.*)";
			}
			static int rows;
			static int colms;
			static string openFilePath;
			DataService ds = new DataService();


			private void Form1_Load(object sender, EventArgs e)
			{
				dataGridViewIn.ColumnCount = 50;
				dataGridViewOut.ColumnCount = 50;
				dataGridViewIn.RowCount = 50;
				dataGridViewOut.RowCount = 50;
				panelLeft.Width = this.Width / 2;
				for (int i = 0; i < 50; i++)
				{
					dataGridViewIn.ColumnCount = 25;
					dataGridViewOut.ColumnCount = 25;
				}
			}

			private void buttonDone_Click(object sender, EventArgs e)
			{
				openFileDialogTask.ShowDialog();
				openFilePath = openFileDialogTask.FileName;
				int[,] arrval = new int[rows, colms];
				arrval = ds.GetMatrix(openFilePath);
				for (int r = 0; r < rows; r++)
				{
					for (int c = 0; c < colms; c++)
					{
						dataGridViewOut.Rows[r].Cells[c].Value = arrval[r, c];
					}
				}
				buttonSave.Enabled = true;
			}

			private void buttonSave_Click(object sender, EventArgs e)
			{
				saveFileDialogMatrix.FileName = "Output_Task7";
				saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
				saveFileDialogMatrix.ShowDialog();
				string path = saveFileDialogMatrix.FileName;
				FileInfo fileInfo = new FileInfo(path);
				bool fileExist = fileInfo.Exists;
				if (fileExist)
				{
					File.Delete(path);
				}
				int row = dataGridViewOut.RowCount;
				int colm = dataGridViewOut.ColumnCount;
				string str = "";
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < colms; j++)
					{
						if (j != colms - 1)
						{
							str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
						}
						else
						{
							str = str + dataGridViewOut.Rows[i].Cells[j].Value;
						}
						File.AppendAllText(path, str + Environment.NewLine);
						str = "";

					}
				}
			}


		}
	}
}

