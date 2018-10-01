using System;
using System.Collections.Generic;
namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Card_deck = new Deck();
            Player Player_1 = new Player("Brian");
            Card_deck.shuffleCard();
            for(int i = 0; i<13 ; i ++){
            System.Console.WriteLine(Player_1.drawCard(Card_deck));
            }
            System.Console.WriteLine();
            System.Console.WriteLine(Player_1.discard(12));

            
        }
    }
}
