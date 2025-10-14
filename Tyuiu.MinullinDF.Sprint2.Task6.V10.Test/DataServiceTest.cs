using Tyuiu.MinullinDF.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MinullinDF.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 1;
            int n = 1;
            var res = ds.FindDateOfPreviousDay(g, m, n);
            String wait = "31.12.1999";
            Assert.AreEqual(wait, res);
        }
    }
}
