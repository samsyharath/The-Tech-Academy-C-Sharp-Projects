using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Sam", "Joe" };
            game.ListPlayers();

            //game.Play();
            Console.ReadLine();


            //Deck deck = new Deck();
            //int timesShuffled = 0;
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{ Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

        
    }
}
