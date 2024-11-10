using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++) 
            {
                if (!(3 * x + 0.5 == 0))
                {
                    res += Math.Sin(x) + ((2) / (3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x;
                }
            }

            return Convert.ToString(Math.Round(res, 2));
        }
    }
}
