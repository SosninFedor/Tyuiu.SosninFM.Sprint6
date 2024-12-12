using System.Windows.Forms;
using System.Xml.Linq;
using Tyuiu.SosninFM.Sprint6.Task7.V27.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.SosninFM.Sprint6.Task7.V27
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			groupBox3 = new GroupBox();
			dataGridViewOut = new DataGridView();
			textBox1 = new TextBox();
			groupBox1 = new GroupBox();
			dataGridViewIn = new DataGridView();
			groupBox2 = new GroupBox();
			buttonDone = new Button();
			buttonSave = new Button();
			buttonInfo = new Button();
			openFileDialogTask = new OpenFileDialog();
			toolTipbutton = new ToolTip(components);
			saveFileDialogMatrix = new SaveFileDialog();
			panelLeft = new Panel();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dataGridViewOut);
			groupBox3.Location = new Point(564, 181);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(550, 383);
			groupBox3.TabIndex = 29;
			groupBox3.TabStop = false;
			groupBox3.Text = "Вывод";
			// 
			// dataGridViewOut
			// 
			dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewOut.Location = new Point(6, 22);
			dataGridViewOut.Name = "dataGridViewOut";
			dataGridViewOut.Size = new Size(537, 343);
			dataGridViewOut.TabIndex = 0;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 108);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(1107, 65);
			textBox1.TabIndex = 26;
			textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dataGridViewIn);
			groupBox1.Location = new Point(6, 179);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(534, 385);
			groupBox1.TabIndex = 28;
			groupBox1.TabStop = false;
			groupBox1.Text = "Вывод";
			// 
			// dataGridViewIn
			// 
			dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewIn.Location = new Point(3, 22);
			dataGridViewIn.Name = "dataGridViewIn";
			dataGridViewIn.Size = new Size(525, 345);
			dataGridViewIn.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(buttonDone);
			groupBox2.Controls.Add(buttonSave);
			groupBox2.Controls.Add(buttonInfo);
			groupBox2.Location = new Point(6, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1108, 90);
			groupBox2.TabIndex = 27;
			groupBox2.TabStop = false;
			// 
			// buttonDone
			// 
			buttonDone.FlatStyle = FlatStyle.Flat;
			buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
			buttonDone.Location = new Point(21, 22);
			buttonDone.Name = "buttonDone";
			buttonDone.Size = new Size(119, 48);
			buttonDone.TabIndex = 20;
			buttonDone.UseVisualStyleBackColor = true;
			buttonDone.Click += buttonDone_Click;
			// 
			// buttonSave
			// 
			buttonSave.FlatStyle = FlatStyle.Flat;
			buttonSave.Image = Properties.Resources.door_out;
			buttonSave.Location = new Point(173, 24);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(139, 46);
			buttonSave.TabIndex = 18;
			buttonSave.UseVisualStyleBackColor = true;
			buttonSave.Click += buttonSave_Click;
			// 
			// buttonInfo
			// 
			buttonInfo.BackColor = SystemColors.MenuHighlight;
			buttonInfo.Location = new Point(973, 9);
			buttonInfo.Name = "buttonInfo";
			buttonInfo.Size = new Size(106, 71);
			buttonInfo.TabIndex = 19;
			buttonInfo.UseVisualStyleBackColor = false;
			// 
			// openFileDialogTask
			// 
			openFileDialogTask.FileName = "openFileDialog1";
			// 
			// panelLeft
			// 
			panelLeft.Location = new Point(653, 12);
			panelLeft.Name = "panelLeft";
			panelLeft.Size = new Size(200, 100);
			panelLeft.TabIndex = 21;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1126, 576);
			Controls.Add(panelLeft);
			Controls.Add(groupBox3);
			Controls.Add(textBox1);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Name = "Form1";
			Text = "Медяничев Денис|АСоИУБ 24-1";
			Load += Form1_Load;
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox3;
		private DataGridView dataGridViewOut;
		private TextBox textBox1;
		private GroupBox groupBox1;
		private DataGridView dataGridViewIn;
		private GroupBox groupBox2;
		private Button buttonDone;
		private Button buttonSave;
		private Button buttonInfo;
		private OpenFileDialog openFileDialogTask;
		private ToolTip toolTipbutton;
		private SaveFileDialog saveFileDialogMatrix;
		private Panel panelLeft;
	}
}