

using Tyuiu.SosninFM.Sprint6.Task2.V1.Lib;
namespace Tyuiu.SosninFM.Sprint6.Task2.V1
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ButtonResultSAA = new Button();
			TextBoxResultSAA = new TextBox();
			TextBoxStartStepSAA = new TextBox();
			groupBoxConditionSAA = new GroupBox();
			pictureBoxFormulaSAA = new PictureBox();
			labelConditionSAA = new Label();
			groupBoxVarsSAA = new GroupBox();
			labelEnd = new Label();
			TextBoxStopStepSAA = new TextBox();
			labelStart = new Label();
			groupBoxOutput = new GroupBox();
			buttonHelp = new Button();
			groupBoxConditionSAA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).BeginInit();
			groupBoxVarsSAA.SuspendLayout();
			groupBoxOutput.SuspendLayout();
			SuspendLayout();
			// 
			// ButtonResultSAA
			// 
			ButtonResultSAA.BackColor = SystemColors.ActiveCaption;
			ButtonResultSAA.Location = new Point(609, 789);
			ButtonResultSAA.Margin = new Padding(5, 6, 5, 6);
			ButtonResultSAA.Name = "ButtonResultSAA";
			ButtonResultSAA.Size = new Size(372, 128);
			ButtonResultSAA.TabIndex = 0;
			ButtonResultSAA.Text = "Выполнить";
			ButtonResultSAA.UseVisualStyleBackColor = false;
			ButtonResultSAA.Click += buttonResult_Click;
			// 
			// TextBoxResultSAA
			// 
			TextBoxResultSAA.BackColor = SystemColors.ControlLight;
			TextBoxResultSAA.Location = new Point(10, 46);
			TextBoxResultSAA.Margin = new Padding(5, 6, 5, 6);
			TextBoxResultSAA.Multiline = true;
			TextBoxResultSAA.Name = "TextBoxResultSAA";
			TextBoxResultSAA.ReadOnly = true;
			TextBoxResultSAA.Size = new Size(459, 841);
			TextBoxResultSAA.TabIndex = 5;
			TextBoxResultSAA.Text = "Результат";
			TextBoxResultSAA.TextAlign = HorizontalAlignment.Center;
			// 
			// TextBoxStartStepSAA
			// 
			TextBoxStartStepSAA.Location = new Point(11, 90);
			TextBoxStartStepSAA.Margin = new Padding(5, 6, 5, 6);
			TextBoxStartStepSAA.Name = "TextBoxStartStepSAA";
			TextBoxStartStepSAA.Size = new Size(183, 39);
			TextBoxStartStepSAA.TabIndex = 0;
			TextBoxStartStepSAA.TextChanged += TextBoxStartStepSAA_TextChanged;
			// 
			// groupBoxConditionSAA
			// 
			groupBoxConditionSAA.Controls.Add(pictureBoxFormulaSAA);
			groupBoxConditionSAA.Controls.Add(labelConditionSAA);
			groupBoxConditionSAA.Location = new Point(89, 83);
			groupBoxConditionSAA.Margin = new Padding(5, 6, 5, 6);
			groupBoxConditionSAA.Name = "groupBoxConditionSAA";
			groupBoxConditionSAA.Padding = new Padding(5, 6, 5, 6);
			groupBoxConditionSAA.Size = new Size(858, 290);
			groupBoxConditionSAA.TabIndex = 7;
			groupBoxConditionSAA.TabStop = false;
			groupBoxConditionSAA.Text = "Условие";
			// 
			// pictureBoxFormulaSAA
			// 
			pictureBoxFormulaSAA.Location = new Point(11, 146);
			pictureBoxFormulaSAA.Margin = new Padding(5, 6, 5, 6);
			pictureBoxFormulaSAA.Name = "pictureBoxFormulaSAA";
			pictureBoxFormulaSAA.Size = new Size(837, 131);
			pictureBoxFormulaSAA.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxFormulaSAA.TabIndex = 10;
			pictureBoxFormulaSAA.TabStop = false;
			// 
			// labelConditionSAA
			// 
			labelConditionSAA.AutoSize = true;
			labelConditionSAA.Location = new Point(11, 40);
			labelConditionSAA.Margin = new Padding(5, 0, 5, 0);
			labelConditionSAA.Name = "labelConditionSAA";
			labelConditionSAA.Size = new Size(414, 32);
			labelConditionSAA.TabIndex = 0;
			labelConditionSAA.Text = "Вычислить выражение по формуле.\r\n";
			// 
			// groupBoxVarsSAA
			// 
			groupBoxVarsSAA.Controls.Add(labelEnd);
			groupBoxVarsSAA.Controls.Add(TextBoxStopStepSAA);
			groupBoxVarsSAA.Controls.Add(labelStart);
			groupBoxVarsSAA.Controls.Add(TextBoxStartStepSAA);
			groupBoxVarsSAA.Location = new Point(23, 762);
			groupBoxVarsSAA.Margin = new Padding(5, 6, 5, 6);
			groupBoxVarsSAA.Name = "groupBoxVarsSAA";
			groupBoxVarsSAA.Padding = new Padding(5, 6, 5, 6);
			groupBoxVarsSAA.Size = new Size(593, 155);
			groupBoxVarsSAA.TabIndex = 8;
			groupBoxVarsSAA.TabStop = false;
			groupBoxVarsSAA.Text = "Входные данные:";
			// 
			// labelEnd
			// 
			labelEnd.AutoSize = true;
			labelEnd.Location = new Point(252, 51);
			labelEnd.Margin = new Padding(5, 0, 5, 0);
			labelEnd.Name = "labelEnd";
			labelEnd.Size = new Size(142, 32);
			labelEnd.TabIndex = 12;
			labelEnd.Text = "Конец шага";
			// 
			// TextBoxStopStepSAA
			// 
			TextBoxStopStepSAA.Location = new Point(252, 90);
			TextBoxStopStepSAA.Margin = new Padding(5, 6, 5, 6);
			TextBoxStopStepSAA.Name = "TextBoxStopStepSAA";
			TextBoxStopStepSAA.Size = new Size(183, 39);
			TextBoxStopStepSAA.TabIndex = 1;
			// 
			// labelStart
			// 
			labelStart.AutoSize = true;
			labelStart.Location = new Point(11, 51);
			labelStart.Margin = new Padding(5, 0, 5, 0);
			labelStart.Name = "labelStart";
			labelStart.Size = new Size(134, 32);
			labelStart.TabIndex = 2;
			labelStart.Text = "Старт шага";
			// 
			// groupBoxOutput
			// 
			groupBoxOutput.Controls.Add(TextBoxResultSAA);
			groupBoxOutput.Location = new Point(991, 26);
			groupBoxOutput.Margin = new Padding(5, 6, 5, 6);
			groupBoxOutput.Name = "groupBoxOutput";
			groupBoxOutput.Padding = new Padding(5, 6, 5, 6);
			groupBoxOutput.Size = new Size(471, 909);
			groupBoxOutput.TabIndex = 9;
			groupBoxOutput.TabStop = false;
			groupBoxOutput.Text = "Вывод данных:";
			// 
			// buttonHelp
			// 
			buttonHelp.FlatStyle = FlatStyle.Flat;
			buttonHelp.Location = new Point(483, 800);
			buttonHelp.Margin = new Padding(5, 6, 5, 6);
			buttonHelp.Name = "buttonHelp";
			buttonHelp.Size = new Size(93, 107);
			buttonHelp.TabIndex = 10;
			buttonHelp.Text = " ?";
			buttonHelp.UseVisualStyleBackColor = true;
			buttonHelp.Click += buttonHelp_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1485, 960);
			Controls.Add(buttonHelp);
			Controls.Add(groupBoxOutput);
			Controls.Add(groupBoxVarsSAA);
			Controls.Add(groupBoxConditionSAA);
			Controls.Add(ButtonResultSAA);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(5, 6, 5, 6);
			MaximizeBox = false;
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Спринт 6 | Таск 2 | Вариант 1 | Соснин Ф.М.";
			Load += FormMain_Load;
			groupBoxConditionSAA.ResumeLayout(false);
			groupBoxConditionSAA.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).EndInit();
			groupBoxVarsSAA.ResumeLayout(false);
			groupBoxVarsSAA.PerformLayout();
			groupBoxOutput.ResumeLayout(false);
			groupBoxOutput.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button ButtonResultSAA;
		private TextBox TextBoxResultSAA;
		private TextBox TextBoxStartStepSAA;
		private GroupBox groupBoxConditionSAA;
		private Label labelConditionSAA;
		private GroupBox groupBoxVarsSAA;
		private Label labelStart;
		private GroupBox groupBoxOutput;
		private PictureBox pictureBoxFormulaSAA;
		private Button buttonHelp;
		private Label labelEnd;
		private TextBox TextBoxStopStepSAA;
	}
}