namespace CornelGuevarraPS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers from 1-20: ");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
