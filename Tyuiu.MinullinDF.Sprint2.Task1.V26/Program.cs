using Tyuiu.MinullinDF.Sprint2.Task1.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:2.1 Логические операции                                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций(|, &, ||, &&, !, ^, последовательность      *");
        Console.WriteLine("* операций не должна нарушаться (True, True, True, False, True, False),   *");
        Console.WriteLine("*  при a = 654, b = 671, c = 874, d = 137                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" a = 654, b = 671, c = 874, d = 137");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int a = 654;
        int b = 671;
        int c = 874;
        int d = 137;
        var res = ds.GetLogicOperations(a, b, c, d);
        Console.WriteLine("[{0}]", string.Join(", ", res));
    }
}