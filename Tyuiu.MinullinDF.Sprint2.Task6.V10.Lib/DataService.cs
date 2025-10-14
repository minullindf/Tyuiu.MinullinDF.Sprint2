using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MinullinDF.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => throw new ArgumentOutOfRangeException("Месяц должен быть от 1 до 12")
            };

            int prevDay, prevMonth, prevYear;

            if (n > 1)
            {
                prevDay = n - 1;
                prevMonth = m;
                prevYear = g;
            }
            else
            {
                if (m == 1)
                {
                    prevMonth = 12;
                    prevYear = g - 1;
                }
                else
                {
                    prevMonth = m - 1;
                    prevYear = g;
                }

                prevDay = prevMonth switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28,
                    _ => 0
                };
            }

            return $"{prevDay:D2}.{prevMonth:D2}.{prevYear}";
        }
    }
}
