using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.TimoninIA.Sprint6.Task3.V25
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
            groupBoxTask_NVI = new GroupBox();
            buttonHelp_NVI = new Button();
            dataGridMatrix_NVI = new DataGridView();
            textBoxTask_NVI = new TextBox();
            groupBoxResult_NVI = new GroupBox();
            dataGridMatrixResult_NVI = new DataGridView();
            buttonDone_NVI = new Button();
            groupBoxTask_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMatrix_NVI).BeginInit();
            groupBoxResult_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMatrixResult_NVI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_NVI
            // 
            groupBoxTask_NVI.Controls.Add(buttonDone_NVI);
            groupBoxTask_NVI.Controls.Add(buttonHelp_NVI);
            groupBoxTask_NVI.Controls.Add(dataGridMatrix_NVI);
            groupBoxTask_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTask_NVI.Location = new Point(12, 12);
            groupBoxTask_NVI.Name = "groupBoxTask_NVI";
            groupBoxTask_NVI.Size = new Size(631, 426);
            groupBoxTask_NVI.TabIndex = 0;
            groupBoxTask_NVI.TabStop = false;
            groupBoxTask_NVI.Text = "Условие";
            // 
            // buttonHelp_NVI
            // 
            buttonHelp_NVI.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVI.Location = new Point(81, 372);
            buttonHelp_NVI.Name = "buttonHelp_NVI";
            buttonHelp_NVI.Size = new Size(37, 34);
            buttonHelp_NVI.TabIndex = 1;
            buttonHelp_NVI.Text = "?";
            buttonHelp_NVI.UseVisualStyleBackColor = false;
            buttonHelp_NVI.Click += buttonHelp_NVI_Click;
            // 
            // dataGridMatrix_NVI
            // 
            dataGridMatrix_NVI.AllowUserToResizeColumns = false;
            dataGridMatrix_NVI.AllowUserToResizeRows = false;
            dataGridMatrix_NVI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMatrix_NVI.ColumnHeadersVisible = false;
            dataGridMatrix_NVI.Location = new Point(377, 26);
            dataGridMatrix_NVI.Name = "dataGridMatrix_NVI";
            dataGridMatrix_NVI.ReadOnly = true;
            dataGridMatrix_NVI.RowHeadersVisible = false;
            dataGridMatrix_NVI.RowHeadersWidth = 51;
            dataGridMatrix_NVI.Size = new Size(248, 380);
            dataGridMatrix_NVI.TabIndex = 1;
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Location = new Point(6, 26);
            textBoxTask_NVI.Multiline = true;
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(365, 380);
            textBoxTask_NVI.TabIndex = 0;
            textBoxTask_NVI.Text = "Дана матрица 5 на 5 \r\n14   5  -9  18  21\r\n\r\n-5 -12 -12   4  28\r\n\r\n27  -2 -14  23  27\r\n\r\n-19 -15  17  15   1\r\n\r\n33   2   6  24  24\r\nОтсортировать 3 столбец по возрастанию";
            // 
            // groupBoxResult_NVI
            // 
            groupBoxResult_NVI.Controls.Add(dataGridMatrixResult_NVI);
            groupBoxResult_NVI.Location = new Point(649, 12);
            groupBoxResult_NVI.Name = "groupBoxResult_NVI";
            groupBoxResult_NVI.Size = new Size(271, 426);
            groupBoxResult_NVI.TabIndex = 2;
            groupBoxResult_NVI.TabStop = false;
            groupBoxResult_NVI.Text = "Результат";
            // 
            // dataGridMatrixResult_NVI
            // 
            dataGridMatrixResult_NVI.AllowUserToResizeColumns = false;
            dataGridMatrixResult_NVI.AllowUserToResizeRows = false;
            dataGridMatrixResult_NVI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMatrixResult_NVI.ColumnHeadersVisible = false;
            dataGridMatrixResult_NVI.Location = new Point(6, 26);
            dataGridMatrixResult_NVI.Name = "dataGridMatrixResult_NVI";
            dataGridMatrixResult_NVI.ReadOnly = true;
            dataGridMatrixResult_NVI.RowHeadersVisible = false;
            dataGridMatrixResult_NVI.RowHeadersWidth = 51;
            dataGridMatrixResult_NVI.Size = new Size(259, 380);
            dataGridMatrixResult_NVI.TabIndex = 2;
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.FlatStyle = FlatStyle.Flat;
            buttonDone_NVI.Location = new Point(179, 372);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(102, 34);
            buttonDone_NVI.TabIndex = 2;
            buttonDone_NVI.Text = "Выполнить";
            buttonDone_NVI.UseVisualStyleBackColor = true;
            buttonDone_NVI.Click += buttonDone_NVI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(groupBoxResult_NVI);
            Controls.Add(groupBoxTask_NVI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 25 | Носков В. И.";
            Load += FormMain_Load;
            groupBoxTask_NVI.ResumeLayout(false);
            groupBoxTask_NVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMatrix_NVI).EndInit();
            groupBoxResult_NVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMatrixResult_NVI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NVI;
        private TextBox textBoxTask_NVI;
        private DataGridView dataGridMatrix_NVI;
        private Button buttonHelp_NVI;
        private GroupBox groupBoxResult_NVI;
        private DataGridView dataGridMatrixResult_NVI;
        private Button buttonDone_NVI;
    }
}