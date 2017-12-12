﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public DateTime DateTime { get; set; }
        public GameResult Result { get; set; }

        public float HomeTeamBetRate { get; set; }
        public float AwayTeamBetRate { get; set; }
        public float DrawBetRate { get; set; }
        
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int HomeTeamGoals { get; set; }

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int AwayTeamGoals { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = new List<PlayerStatistic>();
        public ICollection<Bet> Bets { get; set; } = new List<Bet>();
    }
}
