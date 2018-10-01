using System.Collections.Generic;
namespace Deck_Of_Cards{
    public class Player{
        public string name;

        public List<Card> playerCard = new List<Card>();


        public Player(string N){
            name = N;
        }

        public string drawCard(Deck CardList){
            var temp = CardList.cards[0];
            playerCard.Add(temp);
            CardList.deal();
            return (temp.suit + " " + temp.stringVal);
        }

        public string discard(int index){
            if(index < playerCard.Count){
                var temp = playerCard[index];
                playerCard.RemoveAt(index);
                return (temp.suit + " " + temp.stringVal);
            }else{
                return "No Card";
            }
        }
    }
}