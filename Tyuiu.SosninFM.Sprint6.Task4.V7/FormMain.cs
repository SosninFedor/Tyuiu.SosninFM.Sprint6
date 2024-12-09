using Tyuiu.SosninFM.Sprint6.Task4.V7.Lib;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SosninFM.Sprint6.Task4.V7
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		DataService ds = new DataService();

		private void groupBoxDataOut_BAA_Enter(object sender, EventArgs e)
		{

		}

		private void buttonDone_BAA_Click(object sender, EventArgs e)
		{
			try
			{
				int startStep = Convert.ToInt32(textBoxStartStep_BAA.Text);
				int stopStep = Convert.ToInt32(textBoxStopStep_BAA.Text);

				int len = ds.GetMassFunction(startStep, stopStep).Length;

				double[] array = new double[len];

				array = ds.GetMassFunction(startStep, stopStep);

				this.chartFunction_BAA.ChartAreas[0].AxisX.Title = "Ось X";
				this.chartFunction_BAA.ChartAreas[0].AxisY.Title = "Ось Y";

				textBoxResult_BAA.Text = "";

				for (int i = 0; i <= len - 1; i++)
				{
					this.chartFunction_BAA.Series[0].Points.AddXY(startStep, array[i]);

					textBoxResult_BAA.AppendText(array[i] + Environment.NewLine);

					startStep++;
				}
			}
			catch
			{
				MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonHelp_BAA_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-24-1 Соснин Федор Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonSave_BAA_Click(object sender, EventArgs e)
		{
			try
			{
				string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4v7.txt";
				File.WriteAllText(path, textBoxResult_BAA.Text);

				DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (dialogResult == DialogResult.Yes)
				{
					System.Diagnostics.Process txt = new System.Diagnostics.Process();
					txt.StartInfo.FileName = "notepad.exe";
					txt.StartInfo.Arguments = path;
					txt.Start();
				}
			}
			catch
			{
				MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}