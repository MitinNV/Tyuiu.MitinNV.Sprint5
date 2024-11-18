using Tyuiu.MitinNV.Sprint5.Task7.V10.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = "PATH";
            Assert.AreEqual(varForTest, ds.LoadDataAndSave("C:\\DataSprint5\\InPutDataFileTask7V10.txt"));
        }
    }
}