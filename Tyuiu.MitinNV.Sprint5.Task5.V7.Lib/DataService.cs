using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            int number = Convert.ToInt32(File.ReadAllText(path).Split(" ")[0]);

            int res = 1;
            for (int i = 1; i <= number; i++)
            {
                res *= i;
            }

            return res;
        }
    }
}
