using System.Drawing.Drawing2D;
using Tyuiu.TimoninIA.Sprint6.Task3.V25.Lib;
namespace Tyuiu.TimoninIA.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск3 Выполнил студент группы ИИПБ-24-1 Тимонин Иван Александрович");
        }
        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mt);
            int row = res.GetUpperBound(0) + 1;
            int col = res.Length / row;
            dataGridView_Output_KDA.ColumnCount = col;
            dataGridView_Output_KDA.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                dataGridView_Output_KDA.Columns[i].Width = 25;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridView_Output_KDA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }

        }

        int[,] mt = { {14, 5, -9, 18, 21},
                {-5, -12, -12, 4, 28},
                {27, -2, -14, 23, 27},
                {-19, -15, 17, 15, 1},
                {33, 2, 6, 24, 24} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mt.GetUpperBound(0) + 1;
            int cols = mt.Length / rows;
            dataGridView_Input_KDA.ColumnCount = cols;
            dataGridView_Input_KDA.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridView_Input_KDA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView_Input_KDA.Rows[i].Cells[j].Value = Convert.ToString(mt[i, j]);
                }
            }
        }


    }
}