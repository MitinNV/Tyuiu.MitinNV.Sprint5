using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task2.V27.Lib
{
    public class DataService : ISprint5Task2V27
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            var res = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j]%2 == 1)
                    {
                        matrix[i, j] = 0;
                    }
                } 
            }

            foreach (var item in matrix)
            {
                res += Convert.ToString(item);
            }

            return res;
        }
    }
}
