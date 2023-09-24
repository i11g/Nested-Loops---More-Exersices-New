namespace Call_The_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMan=int.Parse(Console.ReadLine());
            int numberGirls=int.Parse(Console.ReadLine());
            int numberTables=int.Parse(Console.ReadLine());

            int countMeethings = 0;

            for (int i = 1; i <=numberMan; i++)
            {
                for (int j = 1; j <=numberGirls; j++)
                {
                    countMeethings++;
                    if(countMeethings > numberTables)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}