namespace PRODIGY_SD_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string Choice;
            do
            {
                Console.WriteLine("Choose your difficulty level:");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Hard");
                Choice = Console.ReadLine()!;
            } while (Choice != "1" && Choice != "2");

            IRandomNumberStrategy strategy = CreateNumberSelectingStrategyFactory.CreateNumberSelectingStrategy(Choice);

            GuessingGame game = new GuessingGame(strategy);
            game.Build();

        }
    }
}
