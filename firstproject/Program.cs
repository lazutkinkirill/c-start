internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("write your name please: ");
        string? username = Console.ReadLine();

        if (username == "kirill")
        {
            Console.WriteLine("zdarova epta ");
        }
        else
        {
            Console.Write("hello, ");
            Console.WriteLine(username);
        }
    }
}