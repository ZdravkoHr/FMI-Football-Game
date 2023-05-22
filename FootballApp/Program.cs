using FootballApp;
using System.Collections;

FootballPlayer[] players1 = new FootballPlayer[]
{
   new FootballPlayer("Player1", 1, 20, 1.84f),
   new FootballPlayer("Player2", 2, 20, 1.84f),
   new FootballPlayer("Player3", 3, 20, 1.84f),
   new FootballPlayer("Player4", 4, 20, 1.84f),
   new FootballPlayer("Player5", 5, 20, 1.84f),
   new FootballPlayer("Player6", 6, 20, 1.84f),
   new FootballPlayer("Player7", 7, 20, 1.84f),
   new FootballPlayer("Player8", 8, 20, 1.84f),
   new FootballPlayer("Player9", 9, 20, 1.84f),
   new FootballPlayer("Player10", 10, 20, 1.84f),
   new FootballPlayer("Player11", 11, 20, 1.84f),
};

FootballPlayer[] players2 = new FootballPlayer[]
{
   new FootballPlayer("Player12", 1, 20, 1.84f),
   new FootballPlayer("Player13", 2, 20, 1.84f),
   new FootballPlayer("Player14", 3, 20, 1.84f),
   new FootballPlayer("Player15", 4, 20, 1.84f),
   new FootballPlayer("Player16", 5, 20, 1.84f),
   new FootballPlayer("Player17", 6, 20, 1.84f),
   new FootballPlayer("Player18", 7, 20, 1.84f),
   new FootballPlayer("Player19", 8, 20, 1.84f),
   new FootballPlayer("Player20", 9, 20, 1.84f),
   new FootballPlayer("Player21", 10, 20, 1.84f),
   new FootballPlayer("Player22", 11, 20, 1.84f),
};

Coach coach1 = new Coach("Coach1", 39);
Coach coach2 = new Coach("Coach2", 42);

Referee referee1 = new Referee("Referee1", 24);
Referee referee2 = new Referee("Referee2", 28);
Referee referee3 = new Referee("Referee3", 26);
Referee referee4 = new Referee("Referee4", 30);


Team myTeam = new Team(coach1, players1);
Team enemyTeam = new Team(coach2, players2);

Goal[] goals = new Goal[]
{
    new Goal(25, players1[2], false),
    new Goal(40, players1[1], false),
    new Goal(65.3f, players1[2], false),
    new Goal(15.3f, players1[2], true),
    new Goal(35, players2[7], false)
};

Game yesterdaysGame = new Game(myTeam, enemyTeam, referee1, referee2, referee3, goals);


Console.WriteLine($"Winner is {yesterdaysGame.Winner}, score: {yesterdaysGame.Result}");

