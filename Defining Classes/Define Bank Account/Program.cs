using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var dictionary = new Dictionary<int, BankAccount>();

        var input = Console.ReadLine();
        while (input != "End")
        {
            var arguments = input.Split();

            switch (arguments[0])
            {
                case "Create":
                    Create(arguments, dictionary);
                    break;
                case "Deposit":
                    Deposit(arguments, dictionary);
                    break;
                case "Withdraw":
                    Withdraw(arguments, dictionary);
                    break;
                case "Print":
                    Print(arguments, dictionary);
                    break;
                default:
                    break;
            }

            input = Console.ReadLine();
        }
    }

    private static void Print(string[] arguments, Dictionary<int, BankAccount> dictionary)
    {
        var id = int.Parse(arguments[1]);
        if (dictionary.ContainsKey(id))
        {
            Console.WriteLine(dictionary[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] arguments, Dictionary<int, BankAccount> dictionary)
    {
        var id = int.Parse(arguments[1]);
        var amount = double.Parse(arguments[2]);
        if (dictionary.ContainsKey(id))
        {
            if (dictionary[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                dictionary[id].Withdraw(amount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] arguments, Dictionary<int, BankAccount> dictionary)
    {
        var id = int.Parse(arguments[1]);
        var amount = double.Parse(arguments[2]);
        if (dictionary.ContainsKey(id))
        {
            dictionary[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] arguments, Dictionary<int, BankAccount> dictionary)
    {
        var id = int.Parse(arguments[1]);
        if (!dictionary.ContainsKey(id))
        {
            var acc = new BankAccount();
            acc.ID = id;
            dictionary.Add(id, acc);
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }
}

