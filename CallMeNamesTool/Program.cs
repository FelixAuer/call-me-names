namespace CallMeNamesTool;

internal class Program
{
    private static readonly List<string> Names = new() { "Seppi", "Peppi", "Tom", "Jerry", "Heppo", "Peppo" };

    static void Main(string[] args)
    {
        Console.WriteLine("I'm now calling you " + Names[(new Random().Next(Names.Count))]);
    }
}