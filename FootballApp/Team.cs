using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballApp
{
    internal class Team

    {
        private int MIN_PLAYERS = 11;
        private int MAX_PLAYERS = 22;
        private Coach coach;
        private FootballPlayer[] players = new FootballPlayer[] {};

        public Coach Coach { get { return coach; } }
        public FootballPlayer[] Players { get { return players; } }

        public Team(Coach _coach, FootballPlayer[] _players)
           
        {

            if (_players.Length < MIN_PLAYERS || _players.Length > MAX_PLAYERS)
            {
                throw new ArgumentException("Players must be at least 11 and at most 22");
            }

            coach = _coach;
            players = _players;
        }

        public double averagePlayerAge()
        {
            double totalAge = 0;
            foreach(var player in players)
            {
                totalAge += player.Age;
            }

            return totalAge / players.Length;
        }

        public override string ToString()
        {
            return $"{coach.Name}'s team";
        }
    }
}
