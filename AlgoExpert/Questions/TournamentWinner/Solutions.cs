namespace AlgoExpert.TournamentWinner
{
    public class Solutions
    {
        public void Run(string[] args)
        {
            var competitions = new List<List<string>>()
            {
                new List<string> { "HTML", "C#" },
                new List<string> { "C#", "Python" },
                new List<string> { "Python", "HTML" }
            };

            var results = new List<int> { 0, 0, 1 };

            var tournamentWinner = TournamentWinner(competitions, results);
            Console.WriteLine(tournamentWinner);
        }
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            //O(n) time | O(k) space
            //n is the number of competitions and k is the number of teams
            var scores = new Dictionary<string, int>();
            var maxScore = 0;
            var winner = string.Empty;

            for (int i = 0; i < competitions.Count; i++)
            {
                var competition = competitions[i];
                var result = results[i];

                var homeTeam = competition[0];
                var awayTeam = competition[1];

                var winningTeam = result == 1 ? homeTeam : awayTeam;

                if (!scores.ContainsKey(winningTeam))
                {
                    scores[winningTeam] = 0;
                }

                scores[winningTeam] += 3;

                if (scores[winningTeam] > maxScore)
                {
                    maxScore = scores[winningTeam];
                    winner = winningTeam;
                }
            }

            return winner;
        }
    }
}

