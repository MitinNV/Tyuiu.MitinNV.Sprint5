using Tyuiu.MitinNV.Sprint5.Task0.V22.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = "-0,444";
            Assert.AreEqual(varForTest, ds.SaveToFileTextData(3));
        }
    }
}