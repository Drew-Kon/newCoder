namespace Practice
{
    class Program
    {
        static void Main(string []args)
        {
            int a,b,c;
            a = 30;
            b = 60;
            c = b--;
            c = a >= 100 ? b : c / 10;
            Console.Write($"{c}");
            Console.ReadKey();
        }
    }
}