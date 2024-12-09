
using Tyuiu.SosninFM.Sprint6.Task4.V7.Lib;

namespace Tyuiu.SosninFM.Sprint6.Task4.V7
{
    partial class FormMain_LED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LED));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_LED = new GroupBox();
            pictureBoxTask_LED = new PictureBox();
            textBoxTask_LED = new TextBox();
            groupBoxVar_LED = new GroupBox();
            buttonHelp_LED = new Button();
            buttonSave_LED = new Button();
            buttonDone_LED = new Button();
            labelStop_LED = new Label();
            textBoxStop_LED = new TextBox();
            labelStart_LED = new Label();
            textBoxStart_LED = new TextBox();
            groupBoxResult_LED = new GroupBox();
            textBoxResult_LED = new TextBox();
            chart_LED = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTask_LED = new Panel();
            panelGRAF_LED = new Panel();
            splitter_LED = new Splitter();
            panelRESILT_LED = new Panel();
            groupBoxTask_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_LED).BeginInit();
            groupBoxVar_LED.SuspendLayout();
            groupBoxResult_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_LED).BeginInit();
            panelGRAF_LED.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(pictureBoxTask_LED);
            groupBoxTask_LED.Controls.Add(textBoxTask_LED);
            groupBoxTask_LED.Dock = DockStyle.Top;
            groupBoxTask_LED.Location = new Point(0, 0);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Padding = new Padding(5);
            groupBoxTask_LED.Size = new Size(1156, 159);
            groupBoxTask_LED.TabIndex = 0;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие:";
            // 
            // pictureBoxTask_LED
            // 
            pictureBoxTask_LED.Image = (Image)resources.GetObject("pictureBoxTask_LED.Image");
            pictureBoxTask_LED.Location = new Point(45, 98);
            pictureBoxTask_LED.Name = "pictureBoxTask_LED";
            pictureBoxTask_LED.Size = new Size(376, 55);
            pictureBoxTask_LED.TabIndex = 1;
            pictureBoxTask_LED.TabStop = false;
            // 
            // textBoxTask_LED
            // 
            textBoxTask_LED.Location = new Point(6, 26);
            textBoxTask_LED.Multiline = true;
            textBoxTask_LED.Name = "textBoxTask_LED";
            textBoxTask_LED.ReadOnly = true;
            textBoxTask_LED.Size = new Size(513, 66);
            textBoxTask_LED.TabIndex = 1;
            textBoxTask_LED.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в tetBox, построить график функции и сохранить\r\nв файл OutPutFile по нажатию кнопки";
            // 
            // groupBoxVar_LED
            // 
            groupBoxVar_LED.Controls.Add(buttonHelp_LED);
            groupBoxVar_LED.Controls.Add(buttonSave_LED);
            groupBoxVar_LED.Controls.Add(buttonDone_LED);
            groupBoxVar_LED.Controls.Add(labelStop_LED);
            groupBoxVar_LED.Controls.Add(textBoxStop_LED);
            groupBoxVar_LED.Controls.Add(labelStart_LED);
            groupBoxVar_LED.Controls.Add(textBoxStart_LED);
            groupBoxVar_LED.Location = new Point(533, 0);
            groupBoxVar_LED.Name = "groupBoxVar_LED";
            groupBoxVar_LED.Size = new Size(615, 159);
            groupBoxVar_LED.TabIndex = 0;
            groupBoxVar_LED.TabStop = false;
            groupBoxVar_LED.Text = "Ввод данных";
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_LED.BackColor = Color.Cyan;
            buttonHelp_LED.Location = new Point(512, 51);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(94, 56);
            buttonHelp_LED.TabIndex = 1;
            buttonHelp_LED.Text = "Справка";
            buttonHelp_LED.UseVisualStyleBackColor = false;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // buttonSave_LED
            // 
            buttonSave_LED.BackColor = Color.DeepSkyBlue;
            buttonSave_LED.Location = new Point(412, 51);
            buttonSave_LED.Name = "buttonSave_LED";
            buttonSave_LED.Size = new Size(94, 56);
            buttonSave_LED.TabIndex = 3;
            buttonSave_LED.Text = "Сохранить";
            buttonSave_LED.UseVisualStyleBackColor = false;
            buttonSave_LED.Click += buttonSave_LED_Click;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.BackColor = Color.MediumSpringGreen;
            buttonDone_LED.Location = new Point(306, 51);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(100, 56);
            buttonDone_LED.TabIndex = 1;
            buttonDone_LED.Text = "Выполнить";
            buttonDone_LED.UseVisualStyleBackColor = false;
            buttonDone_LED.Click += buttonDone_LED_Click;
            // 
            // labelStop_LED
            // 
            labelStop_LED.AutoSize = true;
            labelStop_LED.Location = new Point(163, 42);
            labelStop_LED.Name = "labelStop_LED";
            labelStop_LED.Size = new Size(91, 20);
            labelStop_LED.TabIndex = 2;
            labelStop_LED.Text = "Конец шага";
            // 
            // textBoxStop_LED
            // 
            textBoxStop_LED.Location = new Point(163, 65);
            textBoxStop_LED.Name = "textBoxStop_LED";
            textBoxStop_LED.Size = new Size(137, 27);
            textBoxStop_LED.TabIndex = 1;
            textBoxStop_LED.Text = "5";
            textBoxStop_LED.TextAlign = HorizontalAlignment.Center;
            // 
            // labelStart_LED
            // 
            labelStart_LED.AutoSize = true;
            labelStart_LED.Location = new Point(21, 42);
            labelStart_LED.Name = "labelStart_LED";
            labelStart_LED.Size = new Size(85, 20);
            labelStart_LED.TabIndex = 1;
            labelStart_LED.Text = "Старт шага";
            // 
            // textBoxStart_LED
            // 
            textBoxStart_LED.Location = new Point(21, 65);
            textBoxStart_LED.Name = "textBoxStart_LED";
            textBoxStart_LED.Size = new Size(136, 27);
            textBoxStart_LED.TabIndex = 1;
            textBoxStart_LED.Text = "-5";
            textBoxStart_LED.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxResult_LED
            // 
            groupBoxResult_LED.Controls.Add(textBoxResult_LED);
            groupBoxResult_LED.Dock = DockStyle.Left;
            groupBoxResult_LED.Location = new Point(0, 159);
            groupBoxResult_LED.Name = "groupBoxResult_LED";
            groupBoxResult_LED.Size = new Size(415, 462);
            groupBoxResult_LED.TabIndex = 1;
            groupBoxResult_LED.TabStop = false;
            groupBoxResult_LED.Text = "Вывод данных";
            // 
            // textBoxResult_LED
            // 
            textBoxResult_LED.Dock = DockStyle.Left;
            textBoxResult_LED.Location = new Point(3, 23);
            textBoxResult_LED.Multiline = true;
            textBoxResult_LED.Name = "textBoxResult_LED";
            textBoxResult_LED.ReadOnly = true;
            textBoxResult_LED.ScrollBars = ScrollBars.Vertical;
            textBoxResult_LED.Size = new Size(403, 436);
            textBoxResult_LED.TabIndex = 0;
            // 
            // chart_LED
            // 
            chartArea1.Name = "ChartArea1";
            chart_LED.ChartAreas.Add(chartArea1);
            chart_LED.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_LED.Legends.Add(legend1);
            chart_LED.Location = new Point(415, 159);
            chart_LED.Name = "chart_LED";
            chart_LED.Padding = new Padding(5);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_LED.Series.Add(series1);
            chart_LED.Size = new Size(741, 462);
            chart_LED.TabIndex = 2;
            chart_LED.Text = "График функции";
            title1.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.MidnightBlue;
            title1.Name = "Titlefun";
            title1.ShadowColor = Color.Empty;
            title1.Text = "График функции";
            chart_LED.Titles.Add(title1);
            // 
            // panelTask_LED
            // 
            panelTask_LED.Location = new Point(0, 0);
            panelTask_LED.Name = "panelTask_LED";
            panelTask_LED.Size = new Size(1156, 159);
            panelTask_LED.TabIndex = 3;
            // 
            // panelGRAF_LED
            // 
            panelGRAF_LED.Controls.Add(splitter_LED);
            panelGRAF_LED.Location = new Point(429, 165);
            panelGRAF_LED.Name = "panelGRAF_LED";
            panelGRAF_LED.Size = new Size(727, 456);
            panelGRAF_LED.TabIndex = 3;
            // 
            // splitter_LED
            // 
            splitter_LED.Location = new Point(0, 0);
            splitter_LED.Name = "splitter_LED";
            splitter_LED.Size = new Size(10, 456);
            splitter_LED.TabIndex = 0;
            splitter_LED.TabStop = false;
            // 
            // panelRESILT_LED
            // 
            panelRESILT_LED.Location = new Point(0, 159);
            panelRESILT_LED.Name = "panelRESILT_LED";
            panelRESILT_LED.Padding = new Padding(5);
            panelRESILT_LED.Size = new Size(423, 462);
            panelRESILT_LED.TabIndex = 3;
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 621);
            Controls.Add(chart_LED);
            Controls.Add(groupBoxResult_LED);
            Controls.Add(groupBoxVar_LED);
            Controls.Add(groupBoxTask_LED);
            Controls.Add(panelTask_LED);
            Controls.Add(panelRESILT_LED);
            Controls.Add(panelGRAF_LED);
            MinimumSize = new Size(1174, 668);
            Name = "FormMain_LED";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск4 | Вариант 24 | Лавринович Е.Д.";
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_LED).EndInit();
            groupBoxVar_LED.ResumeLayout(false);
            groupBoxVar_LED.PerformLayout();
            groupBoxResult_LED.ResumeLayout(false);
            groupBoxResult_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_LED).EndInit();
            panelGRAF_LED.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_LED;
        private GroupBox groupBoxVar_LED;
        private TextBox textBoxTask_LED;
        private PictureBox pictureBoxTask_LED;
        private Label labelStop_LED;
        private TextBox textBoxStop_LED;
        private Label labelStart_LED;
        private TextBox textBoxStart_LED;
        private Button buttonHelp_LED;
        private Button buttonSave_LED;
        private Button buttonDone_LED;
        private GroupBox groupBoxResult_LED;
        private TextBox textBoxResult_LED;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_LED;
        private Panel panelTask_LED;
        private Panel panelGRAF_LED;
        private Panel panelRESILT_LED;
        private Splitter splitter_LED;
    }
}
