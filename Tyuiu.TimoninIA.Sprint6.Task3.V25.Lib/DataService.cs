using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TimoninIA.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] thirdRow = new int[5];
            for (int i = 0; i < thirdRow.Length; i++)
            {
                thirdRow[i] = matrix[i, 2];
            }
            Array.Sort(thirdRow);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 2] = thirdRow[i];
            }
            return matrix;
        }
    }
}