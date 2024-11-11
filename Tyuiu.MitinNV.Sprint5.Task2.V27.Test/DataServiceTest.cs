using Tyuiu.MitinNV.Sprint5.Task2.V27.Lib;

namespace Tyuiu.MitinNV.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = "0;4;0\n0;0;4\n4;0;8";
            Assert.AreEqual(varForTest, ds.SaveToFileTextData(new int[,] { {1, 4, 3 }, {1,1,4 }, {4,3,8 } }));
        }
    }
}