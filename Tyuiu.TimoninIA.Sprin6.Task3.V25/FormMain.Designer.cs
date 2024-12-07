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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxYsl_KDA = new GroupBox();
            textBox1 = new TextBox();
            groupBoxOut_KDA = new GroupBox();
            dataGridView_Output_KDA = new DataGridView();
            dataGridView_Input_KDA = new DataGridView();
            buttonHelp_KDA = new Button();
            buttonDone_KDA = new Button();
            groupBoxYsl_KDA.SuspendLayout();
            groupBoxOut_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Output_KDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Input_KDA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Controls.Add(textBox1);
            groupBoxYsl_KDA.Location = new Point(13, 13);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(239, 300);
            groupBoxYsl_KDA.TabIndex = 0;
            groupBoxYsl_KDA.TabStop = false;
            groupBoxYsl_KDA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(11, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 212);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxOut_KDA
            // 
            groupBoxOut_KDA.Controls.Add(dataGridView_Output_KDA);
            groupBoxOut_KDA.Location = new Point(502, 13);
            groupBoxOut_KDA.Name = "groupBoxOut_KDA";
            groupBoxOut_KDA.Size = new Size(238, 259);
            groupBoxOut_KDA.TabIndex = 1;
            groupBoxOut_KDA.TabStop = false;
            groupBoxOut_KDA.Text = "Вывод данных";
            // 
            // dataGridView_Output_KDA
            // 
            dataGridView_Output_KDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Output_KDA.ColumnHeadersVisible = false;
            dataGridView_Output_KDA.Location = new Point(11, 39);
            dataGridView_Output_KDA.Name = "dataGridView_Output_KDA";
            dataGridView_Output_KDA.RowHeadersVisible = false;
            dataGridView_Output_KDA.Size = new Size(213, 210);
            dataGridView_Output_KDA.TabIndex = 3;
            // 
            // dataGridView_Input_KDA
            // 
            dataGridView_Input_KDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Input_KDA.ColumnHeadersVisible = false;
            dataGridView_Input_KDA.Location = new Point(269, 52);
            dataGridView_Input_KDA.Name = "dataGridView_Input_KDA";
            dataGridView_Input_KDA.RowHeadersVisible = false;
            dataGridView_Input_KDA.Size = new Size(213, 210);
            dataGridView_Input_KDA.TabIndex = 2;
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.Location = new Point(586, 287);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(33, 23);
            buttonHelp_KDA.TabIndex = 3;
            buttonHelp_KDA.Text = "?";
            buttonHelp_KDA.UseVisualStyleBackColor = true;
            buttonHelp_KDA.Click += buttonHelp_KDA_Click;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.Location = new Point(637, 287);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(89, 23);
            buttonDone_KDA.TabIndex = 4;
            buttonDone_KDA.Text = "Выполнить";
            buttonDone_KDA.UseVisualStyleBackColor = true;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 322);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(dataGridView_Input_KDA);
            Controls.Add(groupBoxOut_KDA);
            Controls.Add(groupBoxYsl_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 25 | Тимонин.И.А";
            Load += FormMain_Load;
            groupBoxYsl_KDA.ResumeLayout(false);
            groupBoxYsl_KDA.PerformLayout();
            groupBoxOut_KDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Output_KDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Input_KDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYsl_KDA;
        private TextBox textBox1;
        private GroupBox groupBoxOut_KDA;
        private DataGridView dataGridView_Output_KDA;
        private DataGridView dataGridView_Input_KDA;
        private Button buttonHelp_KDA;
        private Button buttonDone_KDA;
    }
}