using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            return Convert.ToString(Math.Round(Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2)), 3));
        }
    }
}
