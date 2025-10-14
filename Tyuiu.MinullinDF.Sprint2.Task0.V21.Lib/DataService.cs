using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MinullinDF.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return [x == y, x != y, x < y, x > y, x <= y, x >= y];
        }
    }
}
