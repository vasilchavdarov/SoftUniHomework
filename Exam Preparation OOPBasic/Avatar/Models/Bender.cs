﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name,int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract double GetPower();

    public override string ToString()
    {
        var name = GetType().Name;
        var index = name.IndexOf("Bender");
        name = name.Insert(index, " ");

        return $"{name}: {this.Name}, Power: {this.Power}";
    }

}
