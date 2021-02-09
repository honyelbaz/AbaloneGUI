using System;
using System.Collections.Generic;
using System.Drawing;

namespace AbaloneGameForm
{
    internal class Player
    {
        Dictionary<int, Piece> pieces = new Dictionary<int, Piece>();
        private int color;

        public Player(int color)
        {
            this.color = color;
            int row = color == 1 ? 0 : Board.ROWS - 1;
            int factor = color == 1 ? 1 :  -1;
            int [] count = { 5, 6, 3 };
            int[] col_start = { 4, 3, 6 };
            for (int i = 0; i < 3; i++,row+=factor)
            {
                for (int j = col_start[i]; j < col_start[i] +2*count[i]; j+=2)
                {
                    pieces.Add(row*Board.COLUMNS+j, new Piece(color, row, j));
                }
            }
           
        }

        internal void Paint(Graphics graphics)
        {
            foreach (Piece piece in pieces.Values)
                piece.Paint(graphics);
        }

        internal Piece GetPiece(int row, int col)
        {
            int key = row * Board.COLUMNS + col;
            return pieces.ContainsKey(key) ? pieces[key] : null;
        }
    }
}