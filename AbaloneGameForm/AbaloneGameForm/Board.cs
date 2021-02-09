using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaloneGameForm
{
    class Board
    {
        public static int CENTER_ROW_INDEX = 4;
        public static int COLUMNS = 17;
        public static int ROWS = 9;
        Player player1, player2;

        public Board()
        {
            player1 = new Player(1);
            player2 = new Player(2);
        }
        internal void Paint(Graphics graphics)
        {
            player1.Paint(graphics);
            player2.Paint(graphics);
        }

        internal void Click(Point location)
        {
            int row = (location.Y - 40) / (Piece.PIECESIZE + 4);
            int col = (location.X - 47) / (Piece.PIECESIZE * 2 / 3);
            Piece piece1 = player1.GetPiece(row, col);
            Piece piece2 = player2.GetPiece(row, col);
        }
    }
}
