using Tyuiu.MinullinDF.Sprint2.Task3.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая вычисляет требуемое значение функции Y   *");
        Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
        Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x;
        Console.WriteLine("Введите значение переменной X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.Calculate(x);
        Console.WriteLine(Math.Round(res, 3));
        Console.ReadKey();
    }
}