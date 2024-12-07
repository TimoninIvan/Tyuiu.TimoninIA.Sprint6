using Tyuiu.TimoninIA.Sprint6.Task5.V17.Lib;
namespace Tyuiu.TimoninIA.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V17.txt");

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonLaunch_SMA_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_SMA.ColumnCount = 2;
            dataGridViewOutput_SMA.Columns[0].Width = 20;
            dataGridViewOutput_SMA.Columns[1].Width = 50;

            this.chartOutput_SMA.ChartAreas[0].AxisX.Title = "int X";
            this.chartOutput_SMA.ChartAreas[0].AxisY.Title = "int Y";

            chartOutput_SMA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutput_SMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartOutput_SMA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonChoose_SMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonAbout_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, Выполнил студент группы ИИПБ 24-1, Тимонин Иван Александрович", "О программе", MessageBoxButtons.OK);
        }
    }
}