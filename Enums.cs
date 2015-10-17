// **********
// RunUO Shard - Enums.cs
// **********

namespace Server.Engines.TexasHoldem
{
    public enum PlayerAction
    {
        Fold,
        Check,
        Call,
        Bet,
        Raise,
        AllIn,
        None
    }

    public enum PokerGameState
    {
        Inactive,
        DealHoleCards,
        PreFlop,
        Flop,
        PreTurn,
        Turn,
        PreRiver,
        River,
        PreShowdown,
        Showdown,
        DetermineWinners,
        Intermission
    }

    public enum Suit
    {
        Diamonds = 1,
        Hearts = 2,
        Clubs = 3,
        Spades = 4
    }

    public enum Rank
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public enum HandRank
    {
        None,
        OnePair,
        TwoPairs,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalFlush
    }

    public enum RankResult
    {
        Better,
        Worse,
        Same
    }
}