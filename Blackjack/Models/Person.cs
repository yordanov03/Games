using Blackjack.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Person
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public int Score
        {
            get
            {
                return ScoreCalculation();
            }
        }

        public int VisibleScore
        {
            get
            {
                return ScoreCalculation(true);
            }
        }

        public bool HasNaturalBlackjack =>
            Cards.Count == 2
            && Score == 21
            && Cards.Any(x => x.Value == CardValue.Ace)
            && Cards.Any(x => x.IsTenCard);

        public bool IsBusted => Score > 21;


        private int ScoreCalculation(bool onlyVisible = false)
        {
            var cards = Cards;

            //1. Go through the cards to include only visible ones if onlyVisible is true
            if (onlyVisible)
            {
                cards = Cards.Where(x => x.IsVisible).ToList();
            }

            //2. If the total sum is less than 21, return value
            var totalScore = cards.Sum(x => x.Score);
            if (totalScore <= 21)
            {
                return totalScore;
            }

            //3. If no aces and sum is more than 21 => bust
            bool hasAces = cards.Any(x => x.Value == CardValue.Ace);
            if(!hasAces && totalScore > 21)
            {
                return totalScore;
            }

            //4. If any Aces and sum >21, make Aces 1
            var acesCount = cards.Where(x => x.Value == CardValue.Ace).Count();
            var acesScore = cards.Sum(x => x.Score);

            ////5. While there are Aces left...
            while (acesCount > 0)
            {
                //6. Make an Ace worth 1 point
                acesCount -= 1;
                acesScore -= 10;
                //7. If the score is now less than or equal to 21, 
                //   return the score.
                if (acesScore <= 21) return acesScore;
            }

            //If score is never returned, person has a bust
            return cards.Sum(x => x.Score);
        }
    }
}
