using Tyuiu.MinullinDF.Sprint2.Task4.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая вычисляет требуемое значение с           *");
        Console.WriteLine("* с использованием тенарного оператора где пользователь вводит значения   *");
        Console.WriteLine("* переменных с клавиатуры                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("Введите значение переменной X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.Calculate(x, y);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}