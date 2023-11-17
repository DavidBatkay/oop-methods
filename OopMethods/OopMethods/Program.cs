namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Print("test");

            ConsoleHelper.Print("label","test");
            
            ConsoleHelper.Print("test",2);

            Console.WriteLine(MathHelper.Factorial(5));
        }
    }
}