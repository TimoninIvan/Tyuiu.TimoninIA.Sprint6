namespace Tyuiu.TimoninIA.Sprint6.Task1.V11
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
            groupBoxOne_ZNA = new GroupBox();
            labelCondition_ZNA = new Label();
            groupBoxTwo_ZNA = new GroupBox();
            buttonPerform_ZNA = new Button();
            buttonReference_ZNA = new Button();
            textBoxInputEnd_ZNA = new TextBox();
            textBoxInputStart_ZNA = new TextBox();
            labelEnd_ZNA = new Label();
            labelStart_ZNA = new Label();
            groupBoxThree_ZNA = new GroupBox();
            textBoxResult_ZNA = new TextBox();
            labelResult_ZNA = new Label();
            groupBoxOne_ZNA.SuspendLayout();
            groupBoxTwo_ZNA.SuspendLayout();
            groupBoxThree_ZNA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOne_ZNA
            // 
            groupBoxOne_ZNA.Controls.Add(labelCondition_ZNA);
            groupBoxOne_ZNA.Font = new Font("Segoe UI", 12F);
            groupBoxOne_ZNA.Location = new Point(12, 12);
            groupBoxOne_ZNA.Name = "groupBoxOne_ZNA";
            groupBoxOne_ZNA.Size = new Size(535, 341);
            groupBoxOne_ZNA.TabIndex = 0;
            groupBoxOne_ZNA.TabStop = false;
            groupBoxOne_ZNA.Text = "Условие";
            // 
            // labelCondition_ZNA
            // 
            labelCondition_ZNA.AutoSize = true;
            labelCondition_ZNA.Location = new Point(6, 25);
            labelCondition_ZNA.Name = "labelCondition_ZNA";
            labelCondition_ZNA.Size = new Size(416, 63);
            labelCondition_ZNA.TabIndex = 0;
            labelCondition_ZNA.Text = "Протабуллировать функцию (x) на заданном диапазоне.\r\nРезультат вывести в форме таблицы\r\n\r\n";
            // 
            // groupBoxTwo_ZNA
            // 
            groupBoxTwo_ZNA.Controls.Add(buttonPerform_ZNA);
            groupBoxTwo_ZNA.Controls.Add(buttonReference_ZNA);
            groupBoxTwo_ZNA.Controls.Add(textBoxInputEnd_ZNA);
            groupBoxTwo_ZNA.Controls.Add(textBoxInputStart_ZNA);
            groupBoxTwo_ZNA.Controls.Add(labelEnd_ZNA);
            groupBoxTwo_ZNA.Controls.Add(labelStart_ZNA);
            groupBoxTwo_ZNA.Font = new Font("Segoe UI", 12F);
            groupBoxTwo_ZNA.Location = new Point(12, 359);
            groupBoxTwo_ZNA.Name = "groupBoxTwo_ZNA";
            groupBoxTwo_ZNA.Size = new Size(535, 79);
            groupBoxTwo_ZNA.TabIndex = 1;
            groupBoxTwo_ZNA.TabStop = false;
            groupBoxTwo_ZNA.Text = "Вывод данных";
            // 
            // buttonPerform_ZNA
            // 
            buttonPerform_ZNA.BackColor = Color.Green;
            buttonPerform_ZNA.Location = new Point(381, 18);
            buttonPerform_ZNA.Name = "buttonPerform_ZNA";
            buttonPerform_ZNA.Size = new Size(148, 55);
            buttonPerform_ZNA.TabIndex = 6;
            buttonPerform_ZNA.Text = "Выполнить";
            buttonPerform_ZNA.UseVisualStyleBackColor = false;
            // 
            // buttonReference_ZNA
            // 
            buttonReference_ZNA.BackColor = Color.FromArgb(0, 192, 192);
            buttonReference_ZNA.Location = new Point(294, 18);
            buttonReference_ZNA.Name = "buttonReference_ZNA";
            buttonReference_ZNA.Size = new Size(81, 55);
            buttonReference_ZNA.TabIndex = 5;
            buttonReference_ZNA.Text = "Справка";
            buttonReference_ZNA.UseVisualStyleBackColor = false;
            // 
            // textBoxInputEnd_ZNA
            // 
            textBoxInputEnd_ZNA.Location = new Point(151, 49);
            textBoxInputEnd_ZNA.Multiline = true;
            textBoxInputEnd_ZNA.Name = "textBoxInputEnd_ZNA";
            textBoxInputEnd_ZNA.Size = new Size(121, 30);
            textBoxInputEnd_ZNA.TabIndex = 3;
            // 
            // textBoxInputStart_ZNA
            // 
            textBoxInputStart_ZNA.Location = new Point(0, 49);
            textBoxInputStart_ZNA.Multiline = true;
            textBoxInputStart_ZNA.Name = "textBoxInputStart_ZNA";
            textBoxInputStart_ZNA.Size = new Size(124, 30);
            textBoxInputStart_ZNA.TabIndex = 2;
            // 
            // labelEnd_ZNA
            // 
            labelEnd_ZNA.AutoSize = true;
            labelEnd_ZNA.Location = new Point(151, 28);
            labelEnd_ZNA.Name = "labelEnd_ZNA";
            labelEnd_ZNA.Size = new Size(97, 21);
            labelEnd_ZNA.TabIndex = 1;
            labelEnd_ZNA.Text = "Конец шага:";
            // 
            // labelStart_ZNA
            // 
            labelStart_ZNA.AutoSize = true;
            labelStart_ZNA.Location = new Point(6, 25);
            labelStart_ZNA.Name = "labelStart_ZNA";
            labelStart_ZNA.Size = new Size(93, 21);
            labelStart_ZNA.TabIndex = 0;
            labelStart_ZNA.Text = "Старт шага:";
            // 
            // groupBoxThree_ZNA
            // 
            groupBoxThree_ZNA.Controls.Add(textBoxResult_ZNA);
            groupBoxThree_ZNA.Controls.Add(labelResult_ZNA);
            groupBoxThree_ZNA.Font = new Font("Segoe UI", 12F);
            groupBoxThree_ZNA.Location = new Point(562, 12);
            groupBoxThree_ZNA.Name = "groupBoxThree_ZNA";
            groupBoxThree_ZNA.Size = new Size(226, 426);
            groupBoxThree_ZNA.TabIndex = 1;
            groupBoxThree_ZNA.TabStop = false;
            groupBoxThree_ZNA.Text = "Вывод данных";
            // 
            // textBoxResult_ZNA
            // 
            textBoxResult_ZNA.Location = new Point(6, 49);
            textBoxResult_ZNA.Multiline = true;
            textBoxResult_ZNA.Name = "textBoxResult_ZNA";
            textBoxResult_ZNA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZNA.Size = new Size(214, 371);
            textBoxResult_ZNA.TabIndex = 1;
            // 
            // labelResult_ZNA
            // 
            labelResult_ZNA.AutoSize = true;
            labelResult_ZNA.Location = new Point(6, 25);
            labelResult_ZNA.Name = "labelResult_ZNA";
            labelResult_ZNA.Size = new Size(83, 21);
            labelResult_ZNA.TabIndex = 0;
            labelResult_ZNA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTwo_ZNA);
            Controls.Add(groupBoxThree_ZNA);
            Controls.Add(groupBoxOne_ZNA);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            groupBoxOne_ZNA.ResumeLayout(false);
            groupBoxOne_ZNA.PerformLayout();
            groupBoxTwo_ZNA.ResumeLayout(false);
            groupBoxTwo_ZNA.PerformLayout();
            groupBoxThree_ZNA.ResumeLayout(false);
            groupBoxThree_ZNA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_ZNA;
        private Label labelCondition_ZNA;
        private GroupBox groupBoxTwo_ZNA;
        private GroupBox groupBoxThree_ZNA;
        private Label labelResult_ZNA;
        private Label labelEnd_ZNA;
        private Label labelStart_ZNA;
        private Button buttonPerform_ZNA;
        private Button buttonReference_ZNA;
        private TextBox textBoxInputEnd_ZNA;
        private TextBox textBoxInputStart_ZNA;
        private TextBox textBoxResult_ZNA;
    }
}
