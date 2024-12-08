using Tyuiu.TimoninIA.Sprint6.Task7.V3.Lib;

namespace Tyuiu.TimoninIA.Sprint6.Task7.V3
{
    public partial class FormMain : Form
    {
        string path;
        DataService ds = new DataService();
        int rows;
        int cols;
        int[,] matrix;
        public FormMain()
        {
            InitializeComponent();
        }
        public int[,] GiveMatrix(string path)
        {
            string file = File.ReadAllText(path);
            string[] fileList = file.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int rows = fileList.GetLength(0);
            int cols = fileList[0].Split(';').GetLength(0);
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(fileList[i].Split(';')[j]);
                }
            }
            return matrix;
        }
        private void buttonLoad_MSM_Click(object sender, EventArgs e)
        {
            openFileDialog_MSM.ShowDialog();
            path = openFileDialog_MSM.FileName;
            matrix = GiveMatrix(path);
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            dataGridViewInput_MSM.ClearSelection();
            dataGridViewOutput_MSM.ClearSelection();
            dataGridViewInput_MSM.RowCount = rows;
            dataGridViewInput_MSM.ColumnCount = cols;
            dataGridViewOutput_MSM.RowCount = rows;
            dataGridViewOutput_MSM.ColumnCount = cols;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewInput_MSM.Columns[i].Width = 25;
                dataGridViewOutput_MSM.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++) for (int j = 0; j < cols; j++) dataGridViewInput_MSM.Rows[i].Cells[j].Value = matrix[i, j];
            groupBoxInput_MSM.Text = groupBoxInput_MSM.Text + " " + path;
            buttonExecute_MSM.Enabled = true;
        }

        private void buttonExecute_MSM_Click(object sender, EventArgs e)
        {
            matrix = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++) for (int j = 0; j < cols; j++) dataGridViewOutput_MSM.Rows[i].Cells[j].Value = matrix[i, j];
            buttonSave_MSM.Enabled = true;
        }

        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonSave_MSM_Click(object sender, EventArgs e)
        {
            saveFileDialog_MSM.FileName = "OutPutFileTask7.csv";
            saveFileDialog_MSM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MSM.ShowDialog();
            string NewPath = saveFileDialog_MSM.FileName;
            if (File.Exists(NewPath)) File.Delete(NewPath);
            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < cols; j++)
                {
                    line += Convert.ToString(matrix[i, j]) + ";";
                }
                File.AppendAllText(NewPath, line.Trim(';') + Environment.NewLine);
            }
        }
    }
}