using Blackjack.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class CardDeck
    {
        protected Stack<Card> Cards { get; set; }
        public int Count
        {
            get
            {
                return Cards.Count;
            }
        }

        public CardDeck()
        {
            var initilizedCards = new Stack<Card>(PopulateCards());
            ShuffleCards(initilizedCards);
        }

        public void Add(Card card)
        {
            Cards.Push(card);
        }

        public Card Draw()
        {
            return Cards.Pop();
        }

        private List<Card> PopulateCards()
        {
            List<Card> cards = new List<Card>();

            foreach (var suit in (CardSuit[])Enum.GetValues(typeof(CardValue)))
            {
                foreach (var value in (CardValue[])Enum.GetValues(typeof(CardValue)))
                {
                    Card newCard = new Card()
                    {
                        Suit = suit,
                        Value = value,
                        ImageName = "card" + suit.GetDisplayName() + value.GetDisplayName()
                    };
                    cards.Add(newCard);
                }
            }

            return cards;
        }

        public void ShuffleCards(Stack<Card> cards)
        {
            var array = cards.ToArray();
            Random rnd = new Random();

            for (int i = array.Count()-1; i > 0; --i)
            {
                int c = rnd.Next(i + 1);

                Card temp = array[i];
                array[i] = array[c];
                array[c] = temp;

            }

            for (int i = 0; i < array.Count(); i++)
            {
                Cards.Push(array[i]);
            }
        }
    }
}
