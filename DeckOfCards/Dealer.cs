using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Dealer
    {
        private Card cards[];

        public Dealer()
        {
            
            for (int i = 0; i < deck[i] ; i++)
            {
                Card card = new Card(52); //Instantiate a Card
                deck[i] = card; //Adding card to the Deck
            }
        }
    }

    public void deal()
    {
        for (int i = 0; i < 52; i++)
        {
            String suit = (deck[i] / 13);
            String rank = (deck[i] % 13);
            Console.WriteLine(rank + " of " + suit);
            Console.WriteLine("Remaining cards: " + remainingCards);
        }
    }
}
    
}
