namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            int numberOfWays = 0;

            for (int x1 = 0; x1 <= result; x1++)
            {
                for (int x2 = 0; x2 <= result; x2++)
                {
                    int x3 = result - x1 - x2;
                    if (x3 >= 0)
                    {
                        numberOfWays++;
                    }
                }
            }

            Console.WriteLine(numberOfWays);
        }
    }
}