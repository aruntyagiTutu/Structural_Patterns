using System.Collections.Generic;

namespace Adapter_Pattern
{
    class DataSource
    {
        public IPlayer GetPlayer(int id)
        {
            // in real project we will fetch from a datasource(DB or external data API)
            var player = new Player();
            player.Name = "Sachin Tendulkar";
            player.Id = id;
            player.pictures = new List<string>();
            player.Age = 40;
            player.NumberOfMatches = 556;
            player.TotalRunScored = 15000;
            player.NumberOfInnings = 390;
            player.RecentInnings = new List<Inning>();
            player.TotalWickets = 100;
            return player;
        }
    }

    class Player: IPlayer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfInnings { get; set; }
        public int NumberOfMatches { get; set; }
        public int TotalRunScored { get; set; }
        public int TotalWickets { get; set; }
        public List<string> pictures { get; set; }
        public List<Inning> RecentInnings { get; set; }
    }

    class Inning
    {

    }
}