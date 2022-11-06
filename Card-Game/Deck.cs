using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Deck
    {        
        private List<Card> cards = new List<Card> (36);
        public void CreateDeck()
        {
            for (int i = 1; i <= 36;)
            {
                var card = new Card();
                card.CreateCard();
                var c = card;
                if (false == cards.Contains(card))
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
