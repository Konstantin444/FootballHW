using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Team(Coach coach, List<Player> players)
        {
            Coach = coach;
            Players = players;
        }

        private List<Player> players;

        public Coach Coach { get; set; }
        public List<Player> Players
        {
            get { return players; }
            set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new ArgumentException("A team must have a minimum of 11 players and 22 players at most.");
                }
                players = value;
            }
        }
        public double AverageAge => Players.Average(x => x.Age);
    }
}
