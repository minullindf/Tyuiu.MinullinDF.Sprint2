using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MinullinDF.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y = -4.04;
            if (x > 1)
            {
                y = x * Math.Pow((x + 9) / (x - 1), x);
            }
            if (x == 0)
            {
                y = ((x*x+10)/(x*x - Math.Sin(x*x) + 12));
            }
            if (x < 2 & x > -25)
            {
                y = Math.Pow(1+1/(x*x), x);
            }
            if (x < -25)
            {
                y = x + 10*x - (1/x);
            }
            return Math.Round(y, 3);
        }
    }
}
