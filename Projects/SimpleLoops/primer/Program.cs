using System;

class Program
{
    static void Main()
    {
        var age = int.Parse(Console.ReadLine());
        var washingMachinePrice = double.Parse(Console.ReadLine());
        var presentPrice = int.Parse(Console.ReadLine());

        var savings = 0;
        var moneyFromPresents = 0;
        var bonus = 10;
        var evenbird = 0;
        var oddbird = 0;
        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                savings += bonus;
                savings -= 1;
                bonus += 10;
                evenbird++;

            }
            else
            {
                moneyFromPresents += presentPrice;
                oddbird++;
            }
        }

        var allMoney = savings + moneyFromPresents;
        if (allMoney >= washingMachinePrice)
        {
            Console.WriteLine("Yes! {0:F2}", allMoney - washingMachinePrice);
        }
        else
        {
            Console.WriteLine("No! {0:F2}", washingMachinePrice - allMoney);
        }
        Console.WriteLine(evenbird);
        Console.WriteLine(oddbird);
    }
}