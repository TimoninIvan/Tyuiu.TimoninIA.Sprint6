using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TimoninIA.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {

            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;



            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < colums; j++)
                {
                    if (matrix[1, i] % 2 == 0)
                    {
                        matrix[1, i] = 0;
                    }

                }




            }
            return matrix;



















        }
    }
}