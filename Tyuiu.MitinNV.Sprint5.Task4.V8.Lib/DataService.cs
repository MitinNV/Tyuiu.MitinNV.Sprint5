using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            double x;
            x = Convert.ToDouble(File.ReadAllText(path));

            return Math.Round(((x*x) / Math.Sin(x)) + 3, 3);
        }
    }
}
