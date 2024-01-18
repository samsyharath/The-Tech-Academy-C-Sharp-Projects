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
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            //game.Players = new List<string>() { "Jesse", "Sam", "Joe" };
            //game.ListPlayers();

            ////game.Play();
            //Console.ReadLine();

            Player player = new Player();
            player.Name = "Jesse";
            game += player;
            game = game - player;
            Deck deck = new Deck();
            deck.Shuffle();
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        
    }
}
