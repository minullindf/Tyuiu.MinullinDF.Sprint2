using Tyuiu.MinullinDF.Sprint2.Task0.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 1705;
        int y = 775;

        DataService ds = new DataService();
        var res = ds.GetCompareOperations(x, y);
        Console.WriteLine("[{0}]", string.Join(", ", res));
    }
}