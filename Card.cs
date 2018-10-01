namespace Deck_Of_Cards
{
    public class Card{
        public string stringVal;    
        public string suit;

        public int val ;


        public Card(string type, int value, string Valtype){
            suit = type;
            val = value;
            stringVal = Valtype;
        }
    }
}