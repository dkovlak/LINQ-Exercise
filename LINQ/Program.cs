namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();

            videoGames.Add("Tanki Online");
            videoGames.Add("The Legend of Zelda: Breath of the Wild");
            videoGames.Add("Red Dead Redemption 2");
            videoGames.Add("Cyberpunk 2077");
            videoGames.Add("Super Mario Odyssey");
            videoGames.Add("The Witcher 3: Wild Hunt");
            videoGames.Add("Minecraft");
            videoGames.Add("Fortnite");
            videoGames.Add("Overwatch");
            videoGames.Add("Call of Duty: Warzone");

            var length = videoGames.OrderBy(x => x.Length);

            int count = 0;
            Console.WriteLine("~~~~~ List of Video Games ~~~~~");
            foreach (string game in length)
            {
                count++;
                Console.WriteLine($"Game #{count}: {game}");
            }



        }
    }
}
