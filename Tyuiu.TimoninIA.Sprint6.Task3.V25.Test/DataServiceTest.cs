using Tyuiu.TimoninIA.Sprint6.Task3.V25.Lib;
namespace Tyuiu.TimoninIA.Sprint6.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            int[,] matrix = { {14, 5, -9, 18, 21 },
                              {-5, -12, -12, 4, 28 },
                              {27, -2, -14, 23, 27 },
                              {-19, -15, 17, 15, 1 },
                              {33, 2, 6, 24, 24 } };
            int[,] waitMatrix = { {14, 5, -14, 18, 21 },
                              {-5, -12, -12, 4, 28 },
                              {27, -2, -9, 23, 27 },
                              {-19, -15, 6, 15, 1 },
                              {33, 2, 17, 24, 24 } };
            CollectionAssert.AreEqual(ds.Calculate(matrix), waitMatrix);
        }
    }
}