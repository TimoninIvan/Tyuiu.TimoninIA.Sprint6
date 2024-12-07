using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.TimoninIA.Sprint6.Task5.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_SMA = new GroupBox();
            buttonAbout_SMA = new Button();
            buttonLaunch_SMA = new Button();
            buttonChoose_SMA = new Button();
            textBoxTask_SMA = new TextBox();
            groupBoxOutput_SMA = new GroupBox();
            dataGridViewOutput_SMA = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartOutput_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_SMA.SuspendLayout();
            groupBoxOutput_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_SMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOutput_SMA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(buttonAbout_SMA);
            groupBoxTask_SMA.Controls.Add(buttonLaunch_SMA);
            groupBoxTask_SMA.Controls.Add(buttonChoose_SMA);
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Location = new Point(12, 12);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(784, 94);
            groupBoxTask_SMA.TabIndex = 0;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            // 
            // buttonAbout_SMA
            // 
            buttonAbout_SMA.Location = new Point(700, 12);
            buttonAbout_SMA.Name = "buttonAbout_SMA";
            buttonAbout_SMA.Size = new Size(75, 66);
            buttonAbout_SMA.TabIndex = 3;
            buttonAbout_SMA.Text = "Справка";
            buttonAbout_SMA.UseVisualStyleBackColor = true;
            buttonAbout_SMA.Click += buttonAbout_SMA_Click;
            // 
            // buttonLaunch_SMA
            // 
            buttonLaunch_SMA.Location = new Point(538, 12);
            buttonLaunch_SMA.Name = "buttonLaunch_SMA";
            buttonLaunch_SMA.Size = new Size(75, 66);
            buttonLaunch_SMA.TabIndex = 1;
            buttonLaunch_SMA.Text = "Запуск";
            buttonLaunch_SMA.UseVisualStyleBackColor = true;
            buttonLaunch_SMA.Click += buttonLaunch_SMA_Click;
            // 
            // buttonChoose_SMA
            // 
            buttonChoose_SMA.Location = new Point(619, 12);
            buttonChoose_SMA.Name = "buttonChoose_SMA";
            buttonChoose_SMA.Size = new Size(75, 66);
            buttonChoose_SMA.TabIndex = 2;
            buttonChoose_SMA.Text = "Открыть файл";
            buttonChoose_SMA.UseVisualStyleBackColor = true;
            buttonChoose_SMA.Click += buttonChoose_SMA_Click;
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Location = new Point(6, 22);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(560, 66);
            textBoxTask_SMA.TabIndex = 1;
            textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // groupBoxOutput_SMA
            // 
            groupBoxOutput_SMA.Controls.Add(dataGridViewOutput_SMA);
            groupBoxOutput_SMA.Location = new Point(12, 112);
            groupBoxOutput_SMA.Name = "groupBoxOutput_SMA";
            groupBoxOutput_SMA.Size = new Size(200, 326);
            groupBoxOutput_SMA.TabIndex = 0;
            groupBoxOutput_SMA.TabStop = false;
            groupBoxOutput_SMA.Text = "Вывод данных";
            // 
            // dataGridViewOutput_SMA
            // 
            dataGridViewOutput_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_SMA.Location = new Point(6, 22);
            dataGridViewOutput_SMA.Name = "dataGridViewOutput_SMA";
            dataGridViewOutput_SMA.Size = new Size(188, 298);
            dataGridViewOutput_SMA.TabIndex = 1;
            // 
            // chartOutput_SMA
            // 
            chartArea1.Name = "ChartArea1";
            chartOutput_SMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOutput_SMA.Legends.Add(legend1);
            chartOutput_SMA.Location = new Point(346, 121);
            chartOutput_SMA.Name = "chartOutput_SMA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOutput_SMA.Series.Add(series1);
            chartOutput_SMA.Size = new Size(300, 300);
            chartOutput_SMA.TabIndex = 1;
            chartOutput_SMA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartOutput_SMA);
            Controls.Add(groupBoxOutput_SMA);
            Controls.Add(groupBoxTask_SMA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 17 |  Тимонин  И.А.";
            Load += FormMain_Load;
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            groupBoxOutput_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_SMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOutput_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SMA;
        private TextBox textBoxTask_SMA;
        private GroupBox groupBoxOutput_SMA;
        private Button buttonAbout_SMA;
        private Button buttonLaunch_SMA;
        private Button buttonChoose_SMA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridViewOutput_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput_SMA;
    }
}