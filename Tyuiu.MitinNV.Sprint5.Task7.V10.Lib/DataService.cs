using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string res = File.ReadAllText(path);
            string tempFilePath = Path.GetTempFileName();
            string newRes = "";

            for (int i = 0; i < res.Length; i++)
            {
                if (((int)res[i] >= 65 && (int)res[i] <= 90) || ((int)res[i] >= 97 && (int)res[i] <= 122))
                {
                    newRes += res[i].ToString().ToLower();
                } else
                {
                    newRes += res[i];
                }
            }

            File.WriteAllText(tempFilePath, newRes);

            return tempFilePath;
        }
    }
}
