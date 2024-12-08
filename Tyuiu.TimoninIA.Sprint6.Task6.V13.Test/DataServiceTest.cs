using Tyuiu.TimoninIA.Sprint6.Task6.V13.Lib;
namespace Tyuiu.TimoninIA.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            DataService dataService = new DataService();
            string path = "C:\\DataSprint5\\Sprint6Task6\\InPutDataFileTask6V13.txt";
            var res = dataService.CollectTextFromFile(path);
            Assert.AreEqual("WLCdQb  ehWGn McJC lhTKeblSG dXbj", res);
        }
    }
}