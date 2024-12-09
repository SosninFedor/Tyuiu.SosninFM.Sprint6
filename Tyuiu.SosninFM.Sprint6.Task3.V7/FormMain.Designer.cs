using Tyuiu.SosninFM.Sprint6.Task3.V7.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task3.V7
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
			this.groupBoxCondition_YDS = new System.Windows.Forms.GroupBox();
			this.groupBoxResult_YDS = new System.Windows.Forms.GroupBox();
			this.labelResult_YDS = new System.Windows.Forms.Label();
			this.dataGridViewResult_YDS = new System.Windows.Forms.DataGridView();
			this.buttonHelp_YDS = new System.Windows.Forms.Button();
			this.buttonDone_YDS = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxCondition_YDS.SuspendLayout();
			this.groupBoxResult_YDS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YDS)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxCondition_YDS
			// 
			this.groupBoxCondition_YDS.Controls.Add(this.label1);
			this.groupBoxCondition_YDS.Location = new System.Drawing.Point(13, 13);
			this.groupBoxCondition_YDS.Name = "groupBoxCondition_YDS";
			this.groupBoxCondition_YDS.Size = new System.Drawing.Size(468, 349);
			this.groupBoxCondition_YDS.TabIndex = 0;
			this.groupBoxCondition_YDS.TabStop = false;
			this.groupBoxCondition_YDS.Text = "Условие";
			// 
			// groupBoxResult_YDS
			// 
			this.groupBoxResult_YDS.Controls.Add(this.dataGridViewResult_YDS);
			this.groupBoxResult_YDS.Controls.Add(this.labelResult_YDS);
			this.groupBoxResult_YDS.Location = new System.Drawing.Point(488, 13);
			this.groupBoxResult_YDS.Name = "groupBoxResult_YDS";
			this.groupBoxResult_YDS.Size = new System.Drawing.Size(312, 291);
			this.groupBoxResult_YDS.TabIndex = 1;
			this.groupBoxResult_YDS.TabStop = false;
			this.groupBoxResult_YDS.Text = "Вывод данных";
			// 
			// labelResult_YDS
			// 
			this.labelResult_YDS.AutoSize = true;
			this.labelResult_YDS.Location = new System.Drawing.Point(0, 22);
			this.labelResult_YDS.Name = "labelResult_YDS";
			this.labelResult_YDS.Size = new System.Drawing.Size(80, 16);
			this.labelResult_YDS.TabIndex = 0;
			this.labelResult_YDS.Text = "Результат:";
			// 
			// dataGridViewResult_YDS
			// 
			this.dataGridViewResult_YDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResult_YDS.ColumnHeadersVisible = false;
			this.dataGridViewResult_YDS.Location = new System.Drawing.Point(3, 42);
			this.dataGridViewResult_YDS.Name = "dataGridViewResult_YDS";
			this.dataGridViewResult_YDS.RowHeadersVisible = false;
			this.dataGridViewResult_YDS.RowHeadersWidth = 51;
			this.dataGridViewResult_YDS.RowTemplate.Height = 24;
			this.dataGridViewResult_YDS.Size = new System.Drawing.Size(303, 243);
			this.dataGridViewResult_YDS.TabIndex = 1;
			// 
			// buttonHelp_YDS
			// 
			this.buttonHelp_YDS.Location = new System.Drawing.Point(488, 305);
			this.buttonHelp_YDS.Name = "buttonHelp_YDS";
			this.buttonHelp_YDS.Size = new System.Drawing.Size(80, 57);
			this.buttonHelp_YDS.TabIndex = 2;
			this.buttonHelp_YDS.Text = "?";
			this.buttonHelp_YDS.UseVisualStyleBackColor = true;
			this.buttonHelp_YDS.Click += new System.EventHandler(this.buttonHelp_YDS_Click);
			// 
			// buttonDone_YDS
			// 
			this.buttonDone_YDS.Location = new System.Drawing.Point(575, 305);
			this.buttonDone_YDS.Name = "buttonDone_YDS";
			this.buttonDone_YDS.Size = new System.Drawing.Size(219, 57);
			this.buttonDone_YDS.TabIndex = 3;
			this.buttonDone_YDS.Text = "Выполнить";
			this.buttonDone_YDS.UseVisualStyleBackColor = true;
			this.buttonDone_YDS.Click += new System.EventHandler(this.buttonDone_YDS_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(414, 128);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дан массив 5 на 5 элементов.\r\n31  25 -18  12   9\r\n 6  34  -2   2 -18\r\n-5   4  27 " +
	"  4  -1\r\n 4  15  34  -6 -10\r\n 0   8   5  14 -17\r\n\r\nВыполнить сортировку по возра" +
	"станию в четвертом столбце.";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 374);
			this.Controls.Add(this.buttonDone_YDS);
			this.Controls.Add(this.buttonHelp_YDS);
			this.Controls.Add(this.groupBoxResult_YDS);
			this.Controls.Add(this.groupBoxCondition_YDS);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Спринт 6 | Таск 3 | Вариант 7 | Янголенко Д. С.";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.groupBoxCondition_YDS.ResumeLayout(false);
			this.groupBoxCondition_YDS.PerformLayout();
			this.groupBoxResult_YDS.ResumeLayout(false);
			this.groupBoxResult_YDS.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YDS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxCondition_YDS;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxResult_YDS;
		private System.Windows.Forms.DataGridView dataGridViewResult_YDS;
		private System.Windows.Forms.Label labelResult_YDS;
		private System.Windows.Forms.Button buttonHelp_YDS;
		private System.Windows.Forms.Button buttonDone_YDS;
	}
}
