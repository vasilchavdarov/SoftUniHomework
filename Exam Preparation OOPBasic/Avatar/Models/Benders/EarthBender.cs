﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EarthBender : Bender
{
    private double groundSaturation;
    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return this.groundSaturation * Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Ground Saturation: {this.groundSaturation:f2}";
    }
}
