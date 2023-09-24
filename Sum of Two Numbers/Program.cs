namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;
            bool isFound = false;
            for (int i = start; i <=end; i++)
            {
                for (int j = start; j <=end; j++)
                {
                    sum = i + j;
                    combinations++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                    
                }
                if (isFound)
                {

                    break;
                }

            }
            if (!isFound)
            {

                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber})");
            }

        }
    }
}