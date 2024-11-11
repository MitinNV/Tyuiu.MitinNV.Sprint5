using Tyuiu.MitinNV.Sprint5.Task5.V7.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 24234;
            Assert.AreEqual(varForTest, ds.LoadFromDataFile("С:\\DataSprint5\\InPutDataFileTask5V7.txt"));
        }
    }
}