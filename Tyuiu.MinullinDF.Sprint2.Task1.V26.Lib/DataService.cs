using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MinullinDF.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return [
                (a == b) | (a <= b),
                (b<c) & (d!=a),
                (b>=d) || (a<=d),
                (c!=a) && (c<d),
                !(a==d),
                (c!=a) ^ (b>d),
                ];
        }
    }
}
