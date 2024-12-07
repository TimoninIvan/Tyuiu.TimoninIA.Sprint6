using Tyuiu.TimoninIA.Sprint6.Task3.V25.Lib;
namespace Tyuiu.TimoninIA.Sprint6.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
            {
                {14, 5, -9, 18, 21},
                {-5, -12, -12, 4, 28},
                {27, -2, -14, 23, 27},
                {-19, -15, 17, 15, 1},
                {33, 2, 6, 24, 24}
            };
            var res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5]
            {
                {14, 5, -9, 18, 21},
                {-5, -12, -12, 4, 28},
                {27, -2, -14, 23, 27},
                {-19, -15, 17, 15, 1},
                {33, 2, 6, 24, 24}
            };







        }
    }
}