using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TimoninIA.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = (stopValue - startValue) + 1;
            array = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round((5 * i + 2.5) / (Math.Sin(i) + 3) + 2 * i + Math.Cos(i), 2);
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}