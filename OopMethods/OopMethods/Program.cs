namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ConsoleHelper.Print("test");

            ConsoleHelper.Print("label","test");
            
            ConsoleHelper.Print("test",2);

            Console.WriteLine(MathHelper.Factorial(5));

            int[] array = { 1, 2, 3, 4, 5, };
            ArrayHelper.IterateAndPrint(array);
            */
            ConsoleHelperWithDefaultArgs.Print("message","label");

            Console.WriteLine("Price= " + PriceCalculator.CalculatePrice(20,5,9));
        }
    }
}