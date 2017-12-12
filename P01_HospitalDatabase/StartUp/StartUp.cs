using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Initializer;
using P01_HospitalDatabase.Data.Models;
using System;

namespace P01_HospitalDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DatabaseInitializer.ResetDatabase();
        }
    }
}
