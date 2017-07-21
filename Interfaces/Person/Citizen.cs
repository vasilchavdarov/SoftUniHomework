using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Citizen : IPerson, IBirthable, IIdentifiable
{
    public Citizen(string name, int age, string id, string birday)
    {
        this.Name = name;
        this.Age = age;
        this.Birthdate = birday;
        this.Id = id;
    }

    public int Age
    {
        get;

    }

    public string Birthdate
    {
        get;
    }

    public string Id
    {
        get;
    }

    public string Name
    {
        get;
    }
}
