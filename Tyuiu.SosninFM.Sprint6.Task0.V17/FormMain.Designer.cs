
using Tyuiu.SosninFM.Sprint6.Task0.V17.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task0.V17
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			groupBoxTask_SAA = new GroupBox();
			textBoxTask_SAA = new TextBox();
			pictureBoxFormula_SAA = new PictureBox();
			groupBoxInPutData_SAA = new GroupBox();
			labelX_SAA = new Label();
			textBoxX_SAA = new TextBox();
			groupBoxOutPutData_SAA = new GroupBox();
			labelRes_SAA = new Label();
			textBoxRes_SAA = new TextBox();
			buttonDone_SAA = new Button();
			buttonHelp_SAA = new Button();
			groupBoxTask_SAA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SAA).BeginInit();
			groupBoxInPutData_SAA.SuspendLayout();
			groupBoxOutPutData_SAA.SuspendLayout();
			SuspendLayout();
			// 
			// groupBoxTask_SAA
			// 
			groupBoxTask_SAA.Controls.Add(textBoxTask_SAA);
			groupBoxTask_SAA.Controls.Add(pictureBoxFormula_SAA);
			groupBoxTask_SAA.Location = new Point(26, 52);
			groupBoxTask_SAA.Margin = new Padding(6, 7, 6, 7);
			groupBoxTask_SAA.Name = "groupBoxTask_SAA";
			groupBoxTask_SAA.Padding = new Padding(6, 7, 6, 7);
			groupBoxTask_SAA.Size = new Size(986, 455);
			groupBoxTask_SAA.TabIndex = 0;
			groupBoxTask_SAA.TabStop = false;
			groupBoxTask_SAA.Text = "Условие";
			groupBoxTask_SAA.Enter += groupBoxCond_Enter;
			// 
			// textBoxTask_SAA
			// 
			textBoxTask_SAA.BorderStyle = BorderStyle.None;
			textBoxTask_SAA.Location = new Point(13, 47);
			textBoxTask_SAA.Margin = new Padding(6, 7, 6, 7);
			textBoxTask_SAA.Multiline = true;
			textBoxTask_SAA.Name = "textBoxTask_SAA";
			textBoxTask_SAA.ReadOnly = true;
			textBoxTask_SAA.Size = new Size(789, 394);
			textBoxTask_SAA.TabIndex = 2;
			textBoxTask_SAA.Text = "Вычислить выражение по формуле";
			// 
			// pictureBoxFormula_SAA
			// 
			pictureBoxFormula_SAA.Image = (Image)resources.GetObject("pictureBoxFormula_SAA.Image");
			pictureBoxFormula_SAA.Location = new Point(815, 47);
			pictureBoxFormula_SAA.Margin = new Padding(6, 7, 6, 7);
			pictureBoxFormula_SAA.Name = "pictureBoxFormula_SAA";
			pictureBoxFormula_SAA.Size = new Size(158, 138);
			pictureBoxFormula_SAA.TabIndex = 0;
			pictureBoxFormula_SAA.TabStop = false;
			// 
			// groupBoxInPutData_SAA
			// 
			groupBoxInPutData_SAA.Controls.Add(labelX_SAA);
			groupBoxInPutData_SAA.Controls.Add(textBoxX_SAA);
			groupBoxInPutData_SAA.Location = new Point(26, 522);
			groupBoxInPutData_SAA.Margin = new Padding(6, 7, 6, 7);
			groupBoxInPutData_SAA.Name = "groupBoxInPutData_SAA";
			groupBoxInPutData_SAA.Padding = new Padding(6, 7, 6, 7);
			groupBoxInPutData_SAA.Size = new Size(433, 150);
			groupBoxInPutData_SAA.TabIndex = 1;
			groupBoxInPutData_SAA.TabStop = false;
			groupBoxInPutData_SAA.Text = "Ввод данных";
			groupBoxInPutData_SAA.Enter += groupBoxInPutData_SAA_Enter;
			// 
			// labelX_SAA
			// 
			labelX_SAA.AutoSize = true;
			labelX_SAA.Location = new Point(15, 39);
			labelX_SAA.Margin = new Padding(6, 0, 6, 0);
			labelX_SAA.Name = "labelX_SAA";
			labelX_SAA.Size = new Size(179, 32);
			labelX_SAA.TabIndex = 1;
			labelX_SAA.Text = "Переменная X:";
			// 
			// textBoxX_SAA
			// 
			textBoxX_SAA.Location = new Point(13, 79);
			textBoxX_SAA.Margin = new Padding(6, 7, 6, 7);
			textBoxX_SAA.Name = "textBoxX_SAA";
			textBoxX_SAA.Size = new Size(212, 39);
			textBoxX_SAA.TabIndex = 0;
			textBoxX_SAA.TextChanged += textBoxX_SAA_TextChanged;
			textBoxX_SAA.KeyPress += textBoxX_SAA_KeyPress;
			// 
			// groupBoxOutPutData_SAA
			// 
			groupBoxOutPutData_SAA.Controls.Add(labelRes_SAA);
			groupBoxOutPutData_SAA.Controls.Add(textBoxRes_SAA);
			groupBoxOutPutData_SAA.Location = new Point(509, 522);
			groupBoxOutPutData_SAA.Margin = new Padding(6, 7, 6, 7);
			groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
			groupBoxOutPutData_SAA.Padding = new Padding(6, 7, 6, 7);
			groupBoxOutPutData_SAA.Size = new Size(490, 150);
			groupBoxOutPutData_SAA.TabIndex = 2;
			groupBoxOutPutData_SAA.TabStop = false;
			groupBoxOutPutData_SAA.Text = "Вывод данных";
			// 
			// labelRes_SAA
			// 
			labelRes_SAA.AutoSize = true;
			labelRes_SAA.Location = new Point(13, 39);
			labelRes_SAA.Margin = new Padding(6, 0, 6, 0);
			labelRes_SAA.Name = "labelRes_SAA";
			labelRes_SAA.Size = new Size(125, 32);
			labelRes_SAA.TabIndex = 1;
			labelRes_SAA.Text = "Результат:";
			// 
			// textBoxRes_SAA
			// 
			textBoxRes_SAA.Location = new Point(20, 79);
			textBoxRes_SAA.Margin = new Padding(6, 7, 6, 7);
			textBoxRes_SAA.Name = "textBoxRes_SAA";
			textBoxRes_SAA.ReadOnly = true;
			textBoxRes_SAA.Size = new Size(396, 39);
			textBoxRes_SAA.TabIndex = 0;
			textBoxRes_SAA.TextChanged += textBox2_TextChanged;
			// 
			// buttonDone_SAA
			// 
			buttonDone_SAA.Location = new Point(628, 687);
			buttonDone_SAA.Margin = new Padding(6, 7, 6, 7);
			buttonDone_SAA.Name = "buttonDone_SAA";
			buttonDone_SAA.Size = new Size(370, 81);
			buttonDone_SAA.TabIndex = 3;
			buttonDone_SAA.Text = "Выполнить";
			buttonDone_SAA.UseVisualStyleBackColor = true;
			buttonDone_SAA.Click += buttonDone_SAA_Click;
			// 
			// buttonHelp_SAA
			// 
			buttonHelp_SAA.FlatStyle = FlatStyle.Flat;
			buttonHelp_SAA.Location = new Point(509, 687);
			buttonHelp_SAA.Margin = new Padding(6, 7, 6, 7);
			buttonHelp_SAA.Name = "buttonHelp_SAA";
			buttonHelp_SAA.Size = new Size(106, 81);
			buttonHelp_SAA.TabIndex = 4;
			buttonHelp_SAA.Text = "?";
			buttonHelp_SAA.UseVisualStyleBackColor = true;
			buttonHelp_SAA.Click += buttonHelp_SAA_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1042, 798);
			Controls.Add(buttonHelp_SAA);
			Controls.Add(buttonDone_SAA);
			Controls.Add(groupBoxOutPutData_SAA);
			Controls.Add(groupBoxInPutData_SAA);
			Controls.Add(groupBoxTask_SAA);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(6, 7, 6, 7);
			MaximizeBox = false;
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Спринт 6 | Таск 0 | Вариант17 | Соснин Ф. М.";
			groupBoxTask_SAA.ResumeLayout(false);
			groupBoxTask_SAA.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SAA).EndInit();
			groupBoxInPutData_SAA.ResumeLayout(false);
			groupBoxInPutData_SAA.PerformLayout();
			groupBoxOutPutData_SAA.ResumeLayout(false);
			groupBoxOutPutData_SAA.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxTask_SAA;
		private System.Windows.Forms.PictureBox pictureBoxFormula_SAA;
		private System.Windows.Forms.GroupBox groupBoxInPutData_SAA;
		private System.Windows.Forms.TextBox textBoxX_SAA;
		private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
		private System.Windows.Forms.Label labelRes_SAA;
		private System.Windows.Forms.TextBox textBoxRes_SAA;
		private System.Windows.Forms.Label labelX_SAA;
		private System.Windows.Forms.Button buttonDone_SAA;
		private System.Windows.Forms.Button buttonHelp_SAA;
		private System.Windows.Forms.TextBox textBoxTask_SAA;
	}
}