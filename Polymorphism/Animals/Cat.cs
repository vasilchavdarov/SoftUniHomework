﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cat : Animal
{
    public Cat(string name, string favouritefood) 
        : base (name,favouritefood)
    {
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";
    }
}
