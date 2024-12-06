using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TimoninIA.Sprint6.Task0.V27.Lib
{
    public class DataService : ISprint6Task0V27
    {
        public double Calculate(int x)
        {
            double y = 4 * Math.Pow(x, 2) - Math.Pow(x, 3) - (1.5 * x);
            return y;
        }
    }
}