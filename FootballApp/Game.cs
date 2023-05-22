using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    internal class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private Referee assistantReferee1;
        private Referee assistantReferee2;
        private Goal[] goals;
        private string result;
        private Team winner;
       

        public Team Team1 { get { return team1; } }
        public Team Team2 { get { return team2; } }
        public Referee Referee { get {  return referee; } }

        public Referee AssistantReferee1 { get { return assistantReferee1; } }
        public Referee AssistantReferee2 { get { return assistantReferee2;  } }
        public Goal[] Goals { get { return goals; } }

        public string Result { get { return result; } }

        public Team Winner { get { return winner; } }

        public Game(Team _team1, Team _team2, Referee _referee, Referee _assistantReferee1, Referee _assistantReferee2, Goal[] _goals)
        {
            team1 = _team1;
            team2 = _team2;
            referee  = _referee;
            assistantReferee1 = _assistantReferee1;
            assistantReferee2 = _assistantReferee2;
            goals = _goals;
            calculateResult();
        }

        private void calculateResult()
        {
              int score1 = 0;
              int score2 = 0;
            foreach (var goal in goals)
            {
               if (team1.Players.Contains(goal.Player))
                {
                    score1 += goal.IsAuto ? 0 : 1;
                    score2 += goal.IsAuto ? 1 : 0;
                }
                
               else if (team2.Players.Contains(goal.Player))
                {
                    score1 += goal.IsAuto ? 1 : 0;
                    score2 += goal.IsAuto ? 0 : 1;
                }
            }

            result = $"{score1}:{score2}";
            winner = score1 > score2 ? team1 : team2;
        }
    }
}
