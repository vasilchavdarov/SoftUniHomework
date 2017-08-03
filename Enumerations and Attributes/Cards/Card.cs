using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Card : IComparable<Card>
{
    public Card(string rank, string suit)
    {
        this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
        this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
    }

    public Rank Rank { get; set; }
    public Suit Suit { get; set; }

    public int Power
    {
        get
        {
            return (int)this.Rank + (int)this.Suit;
        }
    }

    public override string ToString()
    {
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power}";
    }

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var comparison = this.Suit.CompareTo(other.Suit);
        if (comparison != 0)
        {
            return comparison;
        }
        return this.Rank.CompareTo(other.Rank);
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        var card = obj as Card;

        return this.Power.Equals(card.Power);
    }
}
