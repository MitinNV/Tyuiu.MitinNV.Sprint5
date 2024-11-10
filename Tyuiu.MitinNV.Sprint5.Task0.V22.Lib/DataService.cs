using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            var res = Math.Round(Math.Pow(1 - x, 2) / (-3 * x));
            return Convert.ToString(res);
        }
    }
}
