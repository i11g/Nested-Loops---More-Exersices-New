namespace Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numberOfRowsFirstSector=int.Parse(Console.ReadLine());
            int numberOfSeatsOddRows=int.Parse(Console.ReadLine());

            for (char ch = 'A'; ch <= lastSector; ch++)
            {
                for (int rows = 1; rows <=numberOfRowsFirstSector; rows++)
                {   
                   
                    for (int i = 0; i <=numberOfSeatsOddRows; i++)
                    {
                        Console.WriteLine($"{ch}{rows}{i}");
                    }
                }
            }
            
        }
    }
}