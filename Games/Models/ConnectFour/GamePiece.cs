using Games.Models.ConnectFour.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Models.ConnectFour
{
    public class GamePiece
    {
        public PieceColor Color;

        public GamePiece()
        {
            Color = PieceColor.Blank;
        }

        public GamePiece(PieceColor color)
        {
            Color = color;
        }
    }
}
