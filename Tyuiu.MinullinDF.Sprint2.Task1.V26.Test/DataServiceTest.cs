using Tyuiu.MinullinDF.Sprint2.Task1.V26.Lib;
namespace Tyuiu.MinullinDF.Sprint2.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;
            var res = ds.GetLogicOperations(a,b,c,d);
            bool[] z = [true, true, true, false, true, false];
            CollectionAssert.AreEqual(z, res);
        }
    }
}
