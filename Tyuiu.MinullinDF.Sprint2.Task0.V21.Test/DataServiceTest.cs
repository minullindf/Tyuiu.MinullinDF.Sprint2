using Tyuiu.MinullinDF.Sprint2.Task0.V21.Lib;

namespace Tyuiu.MinullinDF.Sprint2.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1705;
            int y = 775;
            var res = ds.GetCompareOperations(x, y);
            bool[] c = [false, false, false, false, false, false];
            CollectionAssert.AreEqual(c, res);
        }
    }
}
