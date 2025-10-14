using Tyuiu.MinullinDF.Sprint2.Task5.V14.Lib;
namespace Tyuiu.MinullinDF.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 1;
            int d = 2;
            var res = ds.FindDayName(k, d);
            String wait = "Вторник";
            Assert.AreEqual(wait, res);
        }
    }
}
