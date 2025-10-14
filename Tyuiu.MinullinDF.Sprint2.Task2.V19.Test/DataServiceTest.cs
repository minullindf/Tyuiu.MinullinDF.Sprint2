using Tyuiu.MinullinDF.Sprint2.Task2.V19.Lib;
namespace Tyuiu.MinullinDF.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 4;
            int y = 4;
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
