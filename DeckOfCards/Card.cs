using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
           int[] deck = new int[52];
            String[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            String[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            Card()
            {
                for (int i = 0; i < deck.Length; i++)
                {
                    deck[i] = i;
                }
            }
        
    }
}
