using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TimoninIA.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            // Замена четных чисел на -1 в первом столбце
            for (int i = 0; i < rowCount; i++)
            {
                if (matrix[i, 0] % 2 == 0)
                {
                    matrix[i, 0] = -1;
                }
            }

            return matrix;
        }
    }
}
