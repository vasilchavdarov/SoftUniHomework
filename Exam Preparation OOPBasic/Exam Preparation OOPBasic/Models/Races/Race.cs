﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Race
{
    public int Length { get; set; }
    public string Route { get; set; }
    public int PrizePool { get; set; }
    public Dictionary<int, Car> Participants { get; set; }
    public List<Car> Winners { get; set; }

    public Race(int lenght, string route, int prizePool)
    {
        this.Length = lenght;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
        this.Winners = new List<Car>();
    }

    public abstract int GetPerfomance(int id);

    public Dictionary<int, Car> GetWinners()
    {
        var winners = this.Participants.OrderByDescending(n => this.GetPerfomance(n.Key)).Take(3).ToDictionary(n => n.Key, m => m.Value);

        return winners;
    }

    public List<int> GetPrizes()
    {
        var result = new List<int>();
        result.Add((this.PrizePool * 50) / 100);
        result.Add((this.PrizePool * 30) / 100);
        result.Add((this.PrizePool * 20) / 100);

        return result;
    }

    public string StartRace()
    {
        var winners = GetWinners();
        var prizes = GetPrizes();
        
        var sb = new StringBuilder();
        sb.AppendLine($"{Route} - {Length}");
        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners.ElementAt(i);
            sb.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerfomance(car.Key)}PP - ${prizes[i]}");
        }

        return sb.ToString().Trim();
    }
}
