using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.name = name;
        this.favouriteFood = favouriteFood;
    }

    public string FavoriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}
