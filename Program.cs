namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 18 && a <= 55)
            {
                Console.WriteLine("В армейку");
            }
            else if (a < 18)
            {
                Console.WriteLine("Рано еще");
            }
            else if (a > 55)
            {
                Console.WriteLine("На пенис");
            }
        }
    }
}