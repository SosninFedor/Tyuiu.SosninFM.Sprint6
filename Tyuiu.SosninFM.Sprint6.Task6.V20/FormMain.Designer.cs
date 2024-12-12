namespace Tyuiu.SosninFM.Sprint6.Task6.V20
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			panel1 = new Panel();
			button_Spr = new Button();
			button_Go = new Button();
			button_Imput = new Button();
			panel2 = new Panel();
			openFilePath = new TextBox();
			label1 = new Label();
			textBox_Imput = new TextBox();
			panel3 = new Panel();
			label2 = new Label();
			textBox_Res = new TextBox();
			openFileDialog1 = new OpenFileDialog();
			toolTip1 = new ToolTip(components);
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(button_Spr);
			panel1.Controls.Add(button_Go);
			panel1.Controls.Add(button_Imput);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(984, 120);
			panel1.TabIndex = 0;
			// 
			// button_Spr
			// 
			button_Spr.BackColor = Color.FromArgb(192, 192, 0);
			button_Spr.Location = new Point(930, 43);
			button_Spr.Name = "button_Spr";
			button_Spr.Size = new Size(42, 39);
			button_Spr.TabIndex = 23;
			button_Spr.Text = "?";
			button_Spr.UseVisualStyleBackColor = false;
			button_Spr.Click += button_Spr_Click;
			// 
			// button_Go
			// 
			button_Go.BackColor = SystemColors.ControlDark;
			button_Go.Image = (Image)resources.GetObject("button_Go.Image");
			button_Go.Location = new Point(125, 31);
			button_Go.Name = "button_Go";
			button_Go.Size = new Size(67, 63);
			button_Go.TabIndex = 1;
			toolTip1.SetToolTip(button_Go, "Нажмите чтобы выполнить");
			button_Go.UseVisualStyleBackColor = false;
			button_Go.Click += button_Go_Click;
			// 
			// button_Imput
			// 
			button_Imput.BackColor = SystemColors.HotTrack;
			button_Imput.Image = (Image)resources.GetObject("button_Imput.Image");
			button_Imput.Location = new Point(43, 31);
			button_Imput.Name = "button_Imput";
			button_Imput.Size = new Size(67, 63);
			button_Imput.TabIndex = 0;
			toolTip1.SetToolTip(button_Imput, "Нажмите для открытия файла");
			button_Imput.UseVisualStyleBackColor = false;
			button_Imput.Click += button_Imput_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(openFilePath);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(textBox_Imput);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 120);
			panel2.Name = "panel2";
			panel2.Size = new Size(487, 541);
			panel2.TabIndex = 1;
			// 
			// openFilePath
			// 
			openFilePath.Location = new Point(68, 6);
			openFilePath.Name = "openFilePath";
			openFilePath.Size = new Size(410, 23);
			openFilePath.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(12, 3);
			label1.Name = "label1";
			label1.Size = new Size(50, 22);
			label1.TabIndex = 1;
			label1.Text = "Ввод";
			// 
			// textBox_Imput
			// 
			textBox_Imput.Dock = DockStyle.Bottom;
			textBox_Imput.Location = new Point(0, 45);
			textBox_Imput.Multiline = true;
			textBox_Imput.Name = "textBox_Imput";
			textBox_Imput.Size = new Size(487, 496);
			textBox_Imput.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(label2);
			panel3.Controls.Add(textBox_Res);
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(484, 120);
			panel3.Name = "panel3";
			panel3.Size = new Size(500, 541);
			panel3.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(216, 3);
			label2.Name = "label2";
			label2.Size = new Size(60, 22);
			label2.TabIndex = 2;
			label2.Text = "Вывод";
			// 
			// textBox_Res
			// 
			textBox_Res.Dock = DockStyle.Bottom;
			textBox_Res.Location = new Point(0, 45);
			textBox_Res.Multiline = true;
			textBox_Res.Name = "textBox_Res";
			textBox_Res.Size = new Size(500, 496);
			textBox_Res.TabIndex = 1;
			textBox_Res.TabStop = false;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// toolTip1
			// 
			toolTip1.ToolTipIcon = ToolTipIcon.Info;
			toolTip1.ToolTipTitle = "Подсказка";
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ScrollBar;
			ClientSize = new Size(984, 661);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(700, 500);
			Name = "FormMain";
			Text = "Спринт 6 | Таск 6 | Вариант 20 | Кокоулин И.В.";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Button button_Imput;
		private Label label1;
		private TextBox textBox_Imput;
		private Label label2;
		private TextBox textBox_Res;
		private Button button_Go;
		private Button button_Spr;
		private OpenFileDialog openFileDialog1;
		private ToolTip toolTip1;
		private TextBox openFilePath;
	}
}
