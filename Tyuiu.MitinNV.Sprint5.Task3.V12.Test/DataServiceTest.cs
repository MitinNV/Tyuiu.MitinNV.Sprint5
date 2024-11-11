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
            var varForTest = 0;
            Assert.AreEqual(varForTest, ds.YOURFUNCTION());
        }
    }
}