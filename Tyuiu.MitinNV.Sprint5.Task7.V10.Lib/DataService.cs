using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MitinNV.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string res = File.ReadAllText(path).ToLower();
            string tempFilePath = Path.GetTempFileName();


            File.WriteAllText(tempFilePath, res);

            return tempFilePath;
        }
    }
}
