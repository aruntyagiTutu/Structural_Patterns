using System.Collections.Generic;
using System.Linq;

namespace Adapter_Pattern
{
    interface IPlayerIOSAdapter
    {
        string Name{get;}
        int Age{get;}
        string Picture{get;}
        decimal AvgScore{get;} // up to two fixed decimal place
        int Id{get;}
    }

    class PlayerIOSAdapter: IPlayerIOSAdapter
    {
        IPlayer player;
        public PlayerIOSAdapter(IPlayer player)
        {
            this.player = player;
        }

        public string Name { get => player.Name;  }
        public int Age { get => player.Age; }
        public string Picture { get => player.pictures[0]; }
        public decimal AvgScore { get => GetAvgScore(); }
        public int Id { get => player.Id; }

        private decimal GetAvgScore()
        {
            // some calculations here...
            return (decimal)0.00;
        }
    }

    interface IPlayerAndroidAdapter
    {
         string Name{get;}
        int Age{get;}
        string Picture{get;}
        decimal AvgScore{get;} // up to two decimal place
        int Id{get;}
    }

    class PlayerAndroidAdapter: IPlayerAndroidAdapter
    {
         IPlayer player;
        public PlayerAndroidAdapter(IPlayer player)
        {
            this.player = player;
        }

        public string Name { get => player.Name;  }
        public int Age { get => player.Age; }
        public string Picture { get => player.pictures[0]; }
        public decimal AvgScore { get => GetAvgScore(); }
        public int Id { get => player.Id; }
        private decimal GetAvgScore()
        {
            // some calculations here...
            return (decimal)0.0;
        }
    }

    interface IPlayerWebAdapter
    {
        string Name{get;}
        int Age{get;}
        List<string> Pictures{get;}
        int Id{get;}
        List<Inning> RecentInnings{get;}
    }
    class PlayerWebAdapter: IPlayerWebAdapter
    {
        IPlayer player;
        public PlayerWebAdapter(IPlayer player)
        {
            this.player = player;
        }

        public string Name { get => player.Name;  }
        public int Age { get => player.Age; }
        public List<string> Pictures { get => player.pictures; }
        public int Id { get => player.Id; }

        public List<Inning> RecentInnings => player.RecentInnings.Take(10).ToList();
    }

    interface IPlayer
    {
         int Id { get;  }
         string Name { get;  }
         int Age { get;  }
         int NumberOfInnings { get;  }
         int NumberOfMatches { get;  }
         int TotalRunScored { get;  }
         int TotalWickets { get;  }
         List<string> pictures { get;  }
         List<Inning> RecentInnings { get;  }
    }

}