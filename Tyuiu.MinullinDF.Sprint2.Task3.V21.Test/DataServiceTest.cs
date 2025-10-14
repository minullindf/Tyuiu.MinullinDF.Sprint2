using Tyuiu.MinullinDF.Sprint2.Task3.V21.Lib;
namespace Tyuiu.MinullinDF.Sprint2.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            double x = 1;
            DataService ds = new DataService();
            var res = ds.Calculate(x);
            Assert.AreEqual(2.0, res);
        }
    }
}
