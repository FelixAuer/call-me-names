namespace CallMeNamesTool;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NameCaller.Call(args[0]));
    }
}