using Tyuiu.SosninFM.Sprint6.Task5.V19.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task5.V19
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panelCondition_SVA = new System.Windows.Forms.Panel();
			this.buttonHelp_SVA = new System.Windows.Forms.Button();
			this.buttonOpenFile_SVA = new System.Windows.Forms.Button();
			this.buttonDone_SVA = new System.Windows.Forms.Button();
			this.groupBoxCondition_SVA = new System.Windows.Forms.GroupBox();
			this.textBoxCondition_SVA = new System.Windows.Forms.TextBox();
			this.panelOutPut_SVA = new System.Windows.Forms.Panel();
			this.groupBoxOutPut_SVA = new System.Windows.Forms.GroupBox();
			this.dataGridViewOutPut_SVA = new System.Windows.Forms.DataGridView();
			this.chartDiag_SVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panelCondition_SVA.SuspendLayout();
			this.groupBoxCondition_SVA.SuspendLayout();
			this.panelOutPut_SVA.SuspendLayout();
			this.groupBoxOutPut_SVA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SVA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDiag_SVA)).BeginInit();
			this.SuspendLayout();
			// 
			// panelCondition_SVA
			// 
			this.panelCondition_SVA.Controls.Add(this.buttonHelp_SVA);
			this.panelCondition_SVA.Controls.Add(this.buttonOpenFile_SVA);
			this.panelCondition_SVA.Controls.Add(this.buttonDone_SVA);
			this.panelCondition_SVA.Controls.Add(this.groupBoxCondition_SVA);
			this.panelCondition_SVA.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCondition_SVA.Location = new System.Drawing.Point(0, 0);
			this.panelCondition_SVA.Name = "panelCondition_SVA";
			this.panelCondition_SVA.Size = new System.Drawing.Size(1024, 100);
			this.panelCondition_SVA.TabIndex = 0;
			// 
			// buttonHelp_SVA
			// 
			this.buttonHelp_SVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonHelp_SVA.Location = new System.Drawing.Point(849, 12);
			this.buttonHelp_SVA.Name = "buttonHelp_SVA";
			this.buttonHelp_SVA.Size = new System.Drawing.Size(84, 76);
			this.buttonHelp_SVA.TabIndex = 3;
			this.buttonHelp_SVA.Text = "Справка";
			this.buttonHelp_SVA.UseVisualStyleBackColor = false;
			this.buttonHelp_SVA.Click += new System.EventHandler(this.buttonHelp_SVA_Click);
			// 
			// buttonOpenFile_SVA
			// 
			this.buttonOpenFile_SVA.BackColor = System.Drawing.SystemColors.HotTrack;
			this.buttonOpenFile_SVA.Location = new System.Drawing.Point(751, 12);
			this.buttonOpenFile_SVA.Name = "buttonOpenFile_SVA";
			this.buttonOpenFile_SVA.Size = new System.Drawing.Size(92, 76);
			this.buttonOpenFile_SVA.TabIndex = 2;
			this.buttonOpenFile_SVA.Text = "Открыть файл";
			this.buttonOpenFile_SVA.UseVisualStyleBackColor = false;
			this.buttonOpenFile_SVA.Click += new System.EventHandler(this.buttonOpenFile_SAS_Click);
			// 
			// buttonDone_SVA
			// 
			this.buttonDone_SVA.BackColor = System.Drawing.Color.Green;
			this.buttonDone_SVA.Location = new System.Drawing.Point(641, 12);
			this.buttonDone_SVA.Name = "buttonDone_SVA";
			this.buttonDone_SVA.Size = new System.Drawing.Size(104, 76);
			this.buttonDone_SVA.TabIndex = 1;
			this.buttonDone_SVA.Text = "Выполнить";
			this.buttonDone_SVA.UseVisualStyleBackColor = false;
			this.buttonDone_SVA.Click += new System.EventHandler(this.buttonDone_SVA_Click);
			// 
			// groupBoxCondition_SVA
			// 
			this.groupBoxCondition_SVA.Controls.Add(this.textBoxCondition_SVA);
			this.groupBoxCondition_SVA.Location = new System.Drawing.Point(3, 3);
			this.groupBoxCondition_SVA.Name = "groupBoxCondition_SVA";
			this.groupBoxCondition_SVA.Size = new System.Drawing.Size(632, 91);
			this.groupBoxCondition_SVA.TabIndex = 0;
			this.groupBoxCondition_SVA.TabStop = false;
			this.groupBoxCondition_SVA.Text = "Условие";
			// 
			// textBoxCondition_SVA
			// 
			this.textBoxCondition_SVA.Location = new System.Drawing.Point(9, 21);
			this.textBoxCondition_SVA.Multiline = true;
			this.textBoxCondition_SVA.Name = "textBoxCondition_SVA";
			this.textBoxCondition_SVA.ReadOnly = true;
			this.textBoxCondition_SVA.Size = new System.Drawing.Size(623, 64);
			this.textBoxCondition_SVA.TabIndex = 0;
			this.textBoxCondition_SVA.Text = "Прочитть данные из файла InPutFileTask5.txt . Вывести в dataGridView все целые чи" +
	"сла и построить диаграмму по этим значениям.\r\n";
			// 
			// panelOutPut_SVA
			// 
			this.panelOutPut_SVA.Controls.Add(this.groupBoxOutPut_SVA);
			this.panelOutPut_SVA.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelOutPut_SVA.Location = new System.Drawing.Point(0, 100);
			this.panelOutPut_SVA.Name = "panelOutPut_SVA";
			this.panelOutPut_SVA.Size = new System.Drawing.Size(240, 554);
			this.panelOutPut_SVA.TabIndex = 1;
			// 
			// groupBoxOutPut_SVA
			// 
			this.groupBoxOutPut_SVA.Controls.Add(this.dataGridViewOutPut_SVA);
			this.groupBoxOutPut_SVA.Location = new System.Drawing.Point(3, 6);
			this.groupBoxOutPut_SVA.Name = "groupBoxOutPut_SVA";
			this.groupBoxOutPut_SVA.Size = new System.Drawing.Size(229, 545);
			this.groupBoxOutPut_SVA.TabIndex = 0;
			this.groupBoxOutPut_SVA.TabStop = false;
			this.groupBoxOutPut_SVA.Text = "Вывод данных:";
			// 
			// dataGridViewOutPut_SVA
			// 
			this.dataGridViewOutPut_SVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOutPut_SVA.Location = new System.Drawing.Point(9, 24);
			this.dataGridViewOutPut_SVA.Name = "dataGridViewOutPut_SVA";
			this.dataGridViewOutPut_SVA.ReadOnly = true;
			this.dataGridViewOutPut_SVA.RowHeadersWidth = 51;
			this.dataGridViewOutPut_SVA.RowTemplate.Height = 24;
			this.dataGridViewOutPut_SVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridViewOutPut_SVA.Size = new System.Drawing.Size(214, 524);
			this.dataGridViewOutPut_SVA.TabIndex = 0;
			this.dataGridViewOutPut_SVA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// chartDiag_SVA
			// 
			this.chartDiag_SVA.BackColor = System.Drawing.Color.Transparent;
			this.chartDiag_SVA.BorderlineColor = System.Drawing.SystemColors.HighlightText;
			chartArea1.Name = "ChartArea1";
			this.chartDiag_SVA.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartDiag_SVA.Legends.Add(legend1);
			this.chartDiag_SVA.Location = new System.Drawing.Point(246, 127);
			this.chartDiag_SVA.Name = "chartDiag_SVA";
			series1.ChartArea = "ChartArea1";
			series1.Color = System.Drawing.Color.Green;
			series1.IsVisibleInLegend = false;
			series1.Legend = "Legend1";
			series1.MarkerBorderColor = System.Drawing.Color.White;
			series1.MarkerColor = System.Drawing.Color.White;
			series1.MarkerImageTransparentColor = System.Drawing.SystemColors.HighlightText;
			series1.Name = "Series1";
			this.chartDiag_SVA.Series.Add(series1);
			this.chartDiag_SVA.Size = new System.Drawing.Size(778, 515);
			this.chartDiag_SVA.TabIndex = 2;
			this.chartDiag_SVA.Text = "chart1";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 654);
			this.Controls.Add(this.chartDiag_SVA);
			this.Controls.Add(this.panelOutPut_SVA);
			this.Controls.Add(this.panelCondition_SVA);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Спринт 6 | Таск 5 | Вариант 19 | Штоль В.А.";
			this.panelCondition_SVA.ResumeLayout(false);
			this.groupBoxCondition_SVA.ResumeLayout(false);
			this.groupBoxCondition_SVA.PerformLayout();
			this.panelOutPut_SVA.ResumeLayout(false);
			this.groupBoxOutPut_SVA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SVA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDiag_SVA)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelCondition_SVA;
		private System.Windows.Forms.Panel panelOutPut_SVA;
		private System.Windows.Forms.GroupBox groupBoxCondition_SVA;
		private System.Windows.Forms.TextBox textBoxCondition_SVA;
		private System.Windows.Forms.GroupBox groupBoxOutPut_SVA;
		private System.Windows.Forms.DataGridView dataGridViewOutPut_SVA;
		private System.Windows.Forms.Button buttonHelp_SVA;
		private System.Windows.Forms.Button buttonOpenFile_SVA;
		private System.Windows.Forms.Button buttonDone_SVA;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SVA;
	}
}

