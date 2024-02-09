namespace Giveaway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isFollower;

            Random random = new Random();

            List<Players> playersList = new List<Players>();

            while (input != "end")
            {
                string status = Console.ReadLine();
                string[] inputParts = input.Split(" ");
                string firstName = inputParts[0];
                string lastName = inputParts[1];
                int number = int.Parse(inputParts[2]);


                Players players = new Players()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Number = number
                };

                if (status == "yes")
                {
                    isFollower = true;
                    playersList.Add(players);
                }
                else
                {
                    isFollower = false;

                }

                input = Console.ReadLine();
            }
            Players randomPlayer = GetRandomPlayer(playersList, random);


            Console.WriteLine($"Winner: Number {randomPlayer.Number} - {randomPlayer.FirstName} {randomPlayer.LastName}");
        }

        static Players GetRandomPlayer(List<Players> playersList, Random random)
        {
            int randomIndex = random.Next(0, playersList.Count);
            return playersList[randomIndex];
        }
    }
    
}