using Tyuiu.MinullinDF.Sprint2.Task4.V1.Lib;
namespace Tyuiu.MinullinDF.Sprint2.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2, res);
        }
    }
}
