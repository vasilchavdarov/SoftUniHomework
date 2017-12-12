using P03_SalesDatabase.Data;
using System;

namespace P03_SalesDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new SalesContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
