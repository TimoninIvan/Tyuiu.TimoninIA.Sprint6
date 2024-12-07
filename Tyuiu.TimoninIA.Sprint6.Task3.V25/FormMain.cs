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
        int[,] matrix = {     {14, 5, -9, 18, 21 },
                              {-5, -12, -12, 4, 28 },
                              {27, -2, -14, 23, 27 },
                              {-19, -15, 17, 15, 1 },
                              {33, 2, 6, 24, 24 } };

        private void buttonHelp_NVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Выполнил студент группы ИИПБ-24-1 Тимонин Иван Александрович", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridMatrix_NVI.RowCount = rows;
            dataGridMatrix_NVI.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridMatrix_NVI.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridMatrix_NVI.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }

        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridMatrixResult_NVI.RowCount = rows;
            dataGridMatrixResult_NVI.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridMatrixResult_NVI.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridMatrixResult_NVI.Rows[i].Cells[j].Value = mtrx[i, j].ToString();
                }
            }
        }
    }
}