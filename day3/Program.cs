namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            task00.Run();
            task02.Run();
            long num1 = 222000L;
            long num2 = 10200L;
            Console.WriteLine(num1 + " X " + num2 + " = " + task03.Multiply((int)num1, (int)num2));
            task04.Run();

            task05.Run();
        }
    }
}
