namespace AtelierVariable.Exos;

internal static class FirstExo
{
    public static void Run()
    {
        byte b = byte.MaxValue;
        short s = short.MaxValue;
        int res = b + s;
        Console.WriteLine($"{b} + {s} = {res}");
    }
}
