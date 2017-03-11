using System;

namespace ChessGame {
    public class ChessPiece {

        public int x;
        public int y;
        private bool canMove;

        public void init() {
            this.x = 99;
            this.y = 0;
            this.canMove = false;
        }
    }

    public class Pawn: ChessPiece {

        private bool isPawn = true;
    }
}
