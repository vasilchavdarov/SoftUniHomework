﻿using System;
using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new StudentSystemContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
