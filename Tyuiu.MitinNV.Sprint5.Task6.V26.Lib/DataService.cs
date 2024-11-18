using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        { 
            string data = File.ReadAllText(path);
            int res = 0;

            foreach (var item in data)
            {
                if (item == '?')
                {
                    res++;
                }
            }

            return res;
        }
    }
}
