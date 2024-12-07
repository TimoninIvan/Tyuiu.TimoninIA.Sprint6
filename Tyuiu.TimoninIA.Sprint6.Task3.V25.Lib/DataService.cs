using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TimoninIA.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            int[,] res = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((matrix[i, j] % 2 == 0) && (i == 2))
                    {
                        res[i, j] = 0;
                    }
                    else
                        res[i, j] = matrix[i, j];
                }
            }
            return res;
        }
    }
}