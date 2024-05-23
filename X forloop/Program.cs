namespace X_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
