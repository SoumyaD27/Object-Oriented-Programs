using System;
namespace DeckOfCards
{
    public class Program
    {
        public static void main(String[] args)
        {
            Console.WriteLine("The deck will randomly print out a card from a full deck each time");

            Dealer player = new Dealer();
            player.deal();
        }
    }
}