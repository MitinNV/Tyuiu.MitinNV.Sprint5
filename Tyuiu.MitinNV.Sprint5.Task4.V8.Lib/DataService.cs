using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string x;
            double res;
            x = File.ReadAllText(path).Replace(".", ",");
            res = Convert.ToDouble(x);
            return Math.Round(((res*res) / Math.Sin(res)) + 3, 3);
        }
    }
}
