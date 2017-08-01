using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CoffeeMachine
{
    private int coins;
    private List<CoffeeType> coffeeSold;

    public CoffeeMachine()
    {
        this.coffeeSold = new List<CoffeeType>();
    }

    public IEnumerable<CoffeeType> CoffeesSold {
        get
        {
            return this.coffeeSold;
        }
    }

    public void BuyCoffee(string size, string type)
    {
        var coffePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
        var coffeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        if (coins >= (int)coffePrice)
        {
            this.coffeeSold.Add(coffeType);
            coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {

        var rem = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)rem;
    }

}
