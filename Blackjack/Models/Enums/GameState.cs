using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models.Enums
{
    public enum GameState
    {
        NotStarted,
        Betting,
        Dealing,
        InProgress,
        Insurance,
        Payout,
        Shuffling,
        EscortedOut
    }
}
