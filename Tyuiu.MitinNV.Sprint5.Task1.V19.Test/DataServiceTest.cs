using Tyuiu.MitinNV.Sprint5.Task1.V19.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = "3,67";
            Assert.AreEqual(varForTest, ds.SaveToFileTextData(-5, 5));
        }
    }
}