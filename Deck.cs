using System;
using System.Collections.Generic;
namespace Deck_Of_Cards{
    public class Deck{

        public string[] StringVal = {"Ace","2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public string[] Suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
        
        public List<Card> cards = new List<Card>();

        public List<Card> cards2 = new List<Card>();

        
        public Deck(){
            for (int i = 0; i < StringVal.Length; i++)
            {
               for (int j = 0; j < Suit.Length; j++)
               {
                   Card card = new Card(Suit[j], i+1, StringVal[i]);
                   cards.Add(card);
                   cards2.Add(card);
               } 
            }
        }

        public Card deal(){
            Card temp = cards[0];
            cards.RemoveAt(0);
            return temp;
        }

        public void reset(){
            cards.Clear();
            cards = cards2;
        }

        public void shuffleCard(){
            Random rand = new Random();
            for(int i = 0; i < cards.Count; i++){
                int choice = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[choice];
                cards[choice] = temp;
            }
        }

        

        

    }

    
}
