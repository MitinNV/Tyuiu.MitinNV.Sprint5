using Tyuiu.MitinNV.Sprint5.Task4.V8.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 5.199;
            Assert.AreEqual(varForTest, ds.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask4V8.txt"));
        }
    }
}