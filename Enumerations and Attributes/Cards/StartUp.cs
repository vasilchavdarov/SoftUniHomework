using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    private static Card biggest;
    private static string winner;
    
    public static void Main(string[] args)
    {
        CardGame();
    }

    public static void WinnerCheck(Card card, string player)
    {
        if (card.CompareTo(biggest) > 0)
        {
            biggest = card;
            winner = player;
        }
    }

    public static void CardGame()
    {
        var namePlayer1 = Console.ReadLine();
        var namePlayer2 = Console.ReadLine();
        
        var deck = GenerateDeck();
        var firstPlayerDeck = new List<Card>();
        var secondPlayerDeck = new List<Card>();

        

        while (firstPlayerDeck.Count < 5 || secondPlayerDeck.Count < 5)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');

            try
            {
                var card = new Card(tokens[0], tokens[tokens.Length - 1]);

                if (deck.Contains(card))
                {
                    deck.Remove(card);

                    if (firstPlayerDeck.Count < 5)
                    {
                        firstPlayerDeck.Add(card);
                        WinnerCheck(card, namePlayer1);
                    }
                    else
                    {
                        secondPlayerDeck.Add(card);
                        WinnerCheck(card, namePlayer2);
                    }
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No such card exists.");                
            }
            
        }

        Console.WriteLine($"{winner} wins with {biggest.Rank} of {biggest.Suit}.");

    }

    public static List<Card> GenerateDeck()
    {
        var deck = new List<Card>();

        foreach (var suit in Enum.GetNames(typeof(Suit)))
        {
            foreach (var rank in Enum.GetNames(typeof(Rank)))
            {
                deck.Add(new Card(rank, suit));
            }
        }

        return deck;
    }

    public static void PrintDeck()
    {
        var deck = GenerateDeck();
        foreach (var card in deck)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }
    }

    public static void PrintAttribute()
    {
        var input = Console.ReadLine();

        if (input == "Rank")
        {
            PrintAttribute(typeof(Rank));
        }
        else
        {
            PrintAttribute(typeof(Suit));
        }

    }

    public static void PrintAttribute(Type type)
    {
        var attributes = type.GetCustomAttributes(false);
        Console.WriteLine(attributes[0]);
    }

    public static Card ReadCard()
    {

        var rankOfCard = Console.ReadLine();
        var suitOfCard = Console.ReadLine();

        var card = new Card(rankOfCard, suitOfCard);
        return card;
    }

    public static void PrintGreaterCard()
    {

        var card1 = ReadCard();
        var card2 = ReadCard();

        if (card1.CompareTo(card2) > 0)
        {
            Console.WriteLine(card1);
        }
        else
        {
            Console.WriteLine(card2);
        }
    }

    public static void PrintCardInfo()
    {
        var card = ReadCard();
        Console.WriteLine(card);
    }

    public static void PrintEnums(Type type)
    {
        var input = Console.ReadLine();
        Console.WriteLine(input + ":");


        foreach (var value in Enum.GetValues(type))
        {
            Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
        }
    }



}
