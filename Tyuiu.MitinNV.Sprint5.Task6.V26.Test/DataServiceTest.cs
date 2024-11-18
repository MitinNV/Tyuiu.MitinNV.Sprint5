using Tyuiu.MitinNV.Sprint5.Task6.V26.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 6;
            Assert.AreEqual(varForTest, ds.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask6V26.txt"));
        }
    }
}