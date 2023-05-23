using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Game(Team team1, Team team2, Referee referee, Referee assistantReferee1, Referee assistantReferee2)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;
            Goals = new Dictionary<int, Player>();
        }

        private Team team1;
        private Team team2;

        public Team Team1
        {
            get { return team1; }
            private set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("Team 1 has only 11 players.");
                }
                team1 = value;
            }
        }

        public Team Team2
        {
            get { return team2; }
            private set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("Team 2 has only 11 players.");
                }
                team2 = value;
            }
        }

        public Referee Referee { get; private set; }
        public Referee AssistantReferee1 { get; private set; }
        public Referee AssistantReferee2 { get; private set; }
        public Dictionary<int, Player> Goals { get; private set; }

        public void ScoreGoal(int minute, Player player)
        {
            Goals.Add(minute, player);
        }

        public string GameResult()
        {
            int team1Goals = Goals.Count(g => Team1.Players.Contains(g.Value));
            int team2Goals = Goals.Count(g => Team2.Players.Contains(g.Value));
            return $"Team 1: {team1Goals}, Team 2: {team2Goals}";
        }

        public string Winner()
        {
            int team1Goals = Goals.Count(g => Team1.Players.Contains(g.Value));
            int team2Goals = Goals.Count(g => Team2.Players.Contains(g.Value));

            if (team1Goals > team2Goals)
            {
                return "Team 1 wins!";
            }
            else if (team2Goals > team1Goals)
            {
                return "Team 2 wins!";
            }
            else
            {
                return "Draw";
            }
        }
    }
}
