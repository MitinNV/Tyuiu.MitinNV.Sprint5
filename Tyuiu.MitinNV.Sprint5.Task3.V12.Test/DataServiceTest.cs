using Tyuiu.MitinNV.Sprint5.Task3.V12.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = "C:\\Users\\milirin\\AppData\\Local\\Temp\\tmpfn4wce.tmp";
            Assert.AreEqual(varForTest, ds.SaveToFileTextData(3));
        }
    }
}