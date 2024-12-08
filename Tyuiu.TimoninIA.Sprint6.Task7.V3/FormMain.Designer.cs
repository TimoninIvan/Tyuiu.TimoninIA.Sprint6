using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.TimoninIA.Sprint6.Task7.V3
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
            panelUP_MSM = new Panel();
            buttonHelp_MSM = new Button();
            buttonLoad_MSM = new Button();
            buttonSave_MSM = new Button();
            buttonExecute_MSM = new Button();
            groupBoxTask_MSM = new GroupBox();
            textBoxTask_MSM = new TextBox();
            panelFill_MSM = new Panel();
            groupBoxOutput_MSM = new GroupBox();
            dataGridViewOutput_MSM = new DataGridView();
            panelLeft_MSM = new Panel();
            groupBoxInput_MSM = new GroupBox();
            dataGridViewInput_MSM = new DataGridView();
            splitter1 = new Splitter();
            openFileDialog_MSM = new OpenFileDialog();
            toolTipHelp_MSM = new ToolTip(components);
            saveFileDialog_MSM = new SaveFileDialog();
            panelUP_MSM.SuspendLayout();
            groupBoxTask_MSM.SuspendLayout();
            panelFill_MSM.SuspendLayout();
            groupBoxOutput_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).BeginInit();
            panelLeft_MSM.SuspendLayout();
            groupBoxInput_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MSM).BeginInit();
            SuspendLayout();
            // 
            // panelUP_MSM
            // 
            panelUP_MSM.Controls.Add(buttonHelp_MSM);
            panelUP_MSM.Controls.Add(buttonLoad_MSM);
            panelUP_MSM.Controls.Add(buttonSave_MSM);
            panelUP_MSM.Controls.Add(buttonExecute_MSM);
            panelUP_MSM.Controls.Add(groupBoxTask_MSM);
            panelUP_MSM.Dock = DockStyle.Top;
            panelUP_MSM.Location = new Point(0, 0);
            panelUP_MSM.Name = "panelUP_MSM";
            panelUP_MSM.Size = new Size(784, 162);
            panelUP_MSM.TabIndex = 0;
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_MSM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MSM.Location = new Point(692, 12);
            buttonHelp_MSM.Name = "buttonHelp_MSM";
            buttonHelp_MSM.Size = new Size(80, 80);
            buttonHelp_MSM.TabIndex = 2;
            buttonHelp_MSM.Text = "Справка";
            toolTipHelp_MSM.SetToolTip(buttonHelp_MSM, "Информация об авторе приложения");
            buttonHelp_MSM.UseVisualStyleBackColor = true;
            buttonHelp_MSM.Click += buttonHelp_MSM_Click;
            // 
            // buttonLoad_MSM
            // 
            buttonLoad_MSM.Location = new Point(12, 12);
            buttonLoad_MSM.Name = "buttonLoad_MSM";
            buttonLoad_MSM.Size = new Size(80, 80);
            buttonLoad_MSM.TabIndex = 2;
            buttonLoad_MSM.Text = "Загрузить";
            toolTipHelp_MSM.SetToolTip(buttonLoad_MSM, "Загрузка файла");
            buttonLoad_MSM.UseVisualStyleBackColor = true;
            buttonLoad_MSM.Click += buttonLoad_MSM_Click;
            // 
            // buttonSave_MSM
            // 
            buttonSave_MSM.Enabled = false;
            buttonSave_MSM.Location = new Point(184, 12);
            buttonSave_MSM.Name = "buttonSave_MSM";
            buttonSave_MSM.Size = new Size(80, 80);
            buttonSave_MSM.TabIndex = 2;
            buttonSave_MSM.Text = "Сохранить";
            toolTipHelp_MSM.SetToolTip(buttonSave_MSM, "Сохранение файла");
            buttonSave_MSM.UseVisualStyleBackColor = true;
            buttonSave_MSM.Click += buttonSave_MSM_Click;
            // 
            // buttonExecute_MSM
            // 
            buttonExecute_MSM.Enabled = false;
            buttonExecute_MSM.Location = new Point(98, 12);
            buttonExecute_MSM.Name = "buttonExecute_MSM";
            buttonExecute_MSM.Size = new Size(80, 80);
            buttonExecute_MSM.TabIndex = 2;
            buttonExecute_MSM.Text = "Выполнить";
            toolTipHelp_MSM.SetToolTip(buttonExecute_MSM, "Запуск обработки файла");
            buttonExecute_MSM.UseVisualStyleBackColor = true;
            buttonExecute_MSM.Click += buttonExecute_MSM_Click;
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Dock = DockStyle.Bottom;
            groupBoxTask_MSM.Location = new Point(0, 98);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Size = new Size(784, 64);
            groupBoxTask_MSM.TabIndex = 0;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Dock = DockStyle.Fill;
            textBoxTask_MSM.Location = new Point(3, 19);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.ReadOnly = true;
            textBoxTask_MSM.Size = new Size(778, 42);
            textBoxTask_MSM.TabIndex = 0;
            textBoxTask_MSM.Text = resources.GetString("textBoxTask_MSM.Text");
            // 
            // panelFill_MSM
            // 
            panelFill_MSM.Controls.Add(groupBoxOutput_MSM);
            panelFill_MSM.Dock = DockStyle.Fill;
            panelFill_MSM.Location = new Point(394, 162);
            panelFill_MSM.Name = "panelFill_MSM";
            panelFill_MSM.Size = new Size(390, 349);
            panelFill_MSM.TabIndex = 1;
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_MSM.Controls.Add(dataGridViewOutput_MSM);
            groupBoxOutput_MSM.Dock = DockStyle.Fill;
            groupBoxOutput_MSM.Location = new Point(0, 0);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Size = new Size(390, 349);
            groupBoxOutput_MSM.TabIndex = 0;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод:";
            // 
            // dataGridViewOutput_MSM
            // 
            dataGridViewOutput_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MSM.ColumnHeadersVisible = false;
            dataGridViewOutput_MSM.Dock = DockStyle.Fill;
            dataGridViewOutput_MSM.Location = new Point(3, 19);
            dataGridViewOutput_MSM.Name = "dataGridViewOutput_MSM";
            dataGridViewOutput_MSM.RowHeadersVisible = false;
            dataGridViewOutput_MSM.Size = new Size(384, 327);
            dataGridViewOutput_MSM.TabIndex = 0;
            // 
            // panelLeft_MSM
            // 
            panelLeft_MSM.Controls.Add(groupBoxInput_MSM);
            panelLeft_MSM.Dock = DockStyle.Left;
            panelLeft_MSM.Location = new Point(0, 162);
            panelLeft_MSM.Name = "panelLeft_MSM";
            panelLeft_MSM.Size = new Size(391, 349);
            panelLeft_MSM.TabIndex = 2;
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_MSM.Controls.Add(dataGridViewInput_MSM);
            groupBoxInput_MSM.Dock = DockStyle.Fill;
            groupBoxInput_MSM.Location = new Point(0, 0);
            groupBoxInput_MSM.Name = "groupBoxInput_MSM";
            groupBoxInput_MSM.Size = new Size(391, 349);
            groupBoxInput_MSM.TabIndex = 0;
            groupBoxInput_MSM.TabStop = false;
            groupBoxInput_MSM.Text = "Ввод:";
            // 
            // dataGridViewInput_MSM
            // 
            dataGridViewInput_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_MSM.ColumnHeadersVisible = false;
            dataGridViewInput_MSM.Dock = DockStyle.Fill;
            dataGridViewInput_MSM.Location = new Point(3, 19);
            dataGridViewInput_MSM.Name = "dataGridViewInput_MSM";
            dataGridViewInput_MSM.RowHeadersVisible = false;
            dataGridViewInput_MSM.Size = new Size(385, 327);
            dataGridViewInput_MSM.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(391, 162);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 349);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialog_MSM
            // 
            openFileDialog_MSM.FileName = "openFileDialogLoad";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(panelFill_MSM);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_MSM);
            Controls.Add(panelUP_MSM);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 3 | Тимонин И.А";
            panelUP_MSM.ResumeLayout(false);
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            panelFill_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MSM).EndInit();
            panelLeft_MSM.ResumeLayout(false);
            groupBoxInput_MSM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MSM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUP_MSM;
        private Panel panelFill_MSM;
        private Panel panelLeft_MSM;
        private Splitter splitter1;
        private GroupBox groupBoxTask_MSM;
        private TextBox textBoxTask_MSM;
        private GroupBox groupBoxInput_MSM;
        private Button buttonHelp_MSM;
        private Button buttonLoad_MSM;
        private Button buttonExecute_MSM;
        private GroupBox groupBoxOutput_MSM;
        private OpenFileDialog openFileDialog_MSM;
        private ToolTip toolTipHelp_MSM;
        private DataGridView dataGridViewOutput_MSM;
        private DataGridView dataGridViewInput_MSM;
        private Button buttonSave_MSM;
        private SaveFileDialog saveFileDialog_MSM;
    }
}