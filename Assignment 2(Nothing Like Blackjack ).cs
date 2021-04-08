using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
/// <summary>
/// Programming Assignment 2 solution
/// </summary>
class Program
{
/// <summary>
/// Deals 2 cards to 3 players and displays cards for players
/// </summary>
/// <param name="args">command-line arguments</param>
static void Main(string[] args)
{
// print welcome message
Console.WriteLine("*****************************WELCOME to FAMOUS CASINO*****************************");
// create and shuffle a deck
Deck deck = new Deck();
deck.Shuffle();
//deck.Print();
// deal 2 cards each to 3 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
Console.WriteLine();
Console.WriteLine();
//First card to each player
Card card1play1 = deck.TakeTopCard();
Card card1play2 = deck.TakeTopCard();
Card card1play3 = deck.TakeTopCard();
Card card2play1 = deck.TakeTopCard();
Card card2play2 = deck.TakeTopCard();
Card card2play3 = deck.TakeTopCard();

// flip all the cards over
card1play1.FlipOver();
card1play2.FlipOver();
card1play3.FlipOver();
card2play1.FlipOver();
card2play2.FlipOver();
card2play3.FlipOver();
// print the cards for player 1
Console.WriteLine("Cards of Player 1");
Console.WriteLine("1st Card is " + card1play1.Rank + " of " + card1play1.Suit);
Console.WriteLine("2nd Card is " + card2play1.Rank + " of " + card2play1.Suit);
Console.WriteLine();
// print the cards for player 2
Console.WriteLine("Cards of Player 2");
Console.WriteLine("1st Card is " + card1play2.Rank + " of " + card1play2.Suit);
Console.WriteLine("2nd Card is " + card2play2.Rank + " of " + card2play2.Suit);
Console.WriteLine();
// print the cards for player 3
Console.WriteLine("Cards of Player 3");
Console.WriteLine("1st Card is " + card1play3.Rank + " of " + card1play3.Suit);
Console.WriteLine("2nd Card is " + card2play3.Rank + " of " + card2play3.Suit);
Console.WriteLine();
}
}
}
