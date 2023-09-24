namespace Open_A_Secret_Door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endofHundreds=int.Parse(Console.ReadLine());
            int endofTens=int.Parse(Console.ReadLine());
            int endofNumbers=int.Parse(Console.ReadLine());

            for (int i = 2; i <=endofHundreds; i+=2)
            {
                for (int j = 2; j <=endofTens; j++)
                {
                    if (j == 2 || j == 3 || j == 5 || j == 7)
                    {
                        for (int k = 2; k <= endofNumbers; k += 2)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                        }
                    }
                }
            }
        }
    }
}