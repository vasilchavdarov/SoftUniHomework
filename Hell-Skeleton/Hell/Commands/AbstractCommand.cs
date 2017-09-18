﻿using System;
using System.Collections.Generic;

public abstract class AbstractCommand : ICommand
{
    public AbstractCommand(IList<string> args, IManager manager)
    {
        this.Args = args;
        this.Manager = manager;
    }

    public IList<string> Args { get; set; }

    public IManager Manager { get; set; }

    public abstract string Execute();
}