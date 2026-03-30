namespace day3Lab_visualC__Player_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Create arrays of players for each team
            Player[] ahlyPlayers = {
                new Player("Shenawy", 1, Player.Role.GK),
                new Player("Maaloul", 21, Player.Role.DF)
            };

            Player[] zamalekPlayers = {
                new Player("Awad", 16, Player.Role.GK),
                new Player("Gaber", 4, Player.Role.DF)
            };

            // 2. Create Teams, passing the player arrays into the constructors
            Team team1 = new Team("Ahly", "Koller", ahlyPlayers);
            Team team2 = new Team("Zamalek", "Gomes", zamalekPlayers);

            Team[] leagueTeams = { team1, team2 };

            // 3. Create League Object
            League egyptianLeague = new League("Egyptian Premier League", leagueTeams);

            Console.WriteLine("BEFORE UPDATE:");
            Console.WriteLine(egyptianLeague["Ahly"]);

            // 4. Test Indexers according to your requirements

            if (egyptianLeague["Ahly"] is Team currentTeam)
            {
                // Updating player name via integer indexer
                currentTeam[21] = "Ali Maaloul (Captain)";
            }

            Console.WriteLine("\nAFTER UPDATE:");
            Console.WriteLine(egyptianLeague["Ahly"]);

            Console.ReadLine();
        }
    }
    
}
