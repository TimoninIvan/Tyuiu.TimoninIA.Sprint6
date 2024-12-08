using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TimoninIA.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            string line;
            string paath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V13.txt");
            using (StreamReader sr = new StreamReader(path))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    string[] mass = line.Split(' ');
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i == mass.Length - 2)
                        {
                            res = res + mass[i] + " ";
                        }
                    }
                }
                res = res.Remove(res.Length - 1);
                return res;
            }
        }
    }
}