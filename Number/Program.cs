using System.ComponentModel.Design;

namespace Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= end; i++)
            {

                for (int j = start; j <= end; j++)

                {

                    for (int k = start; k <= end; k++)
                    {
                        sum = j + k;
                        if (sum % 2 == 0)

                            for (int l = start; l <= end; l++)
                            {
                                if (i > l)
                                {
                                    if (i % 2 == 0 && l % 2 != 0)

                                        Console.WriteLine($"{i}{j}{k}{l}");


                                    else if (i % 2 != 0 && l % 2 == 0)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{l}");
                                    }

                                }
                            }
                    }
                }
            }
        }
    }
}
