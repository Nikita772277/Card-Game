using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Deck
    {
        Card card = new Card();
        private Card[] a =new Card[36];
        private List<Card> cards = new List<Card> (36);
        public void CreateDeck()
        {
            cards = new List<Card>(36);
            for (int i = 0; i <= 36;)
            {
                card.CreateCard();
                var c = card;
                if (false == cards.Contains(c))
                {

                    cards.Add(card);
                    i++;
                }
            }
        }
        public void GetDeck()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
