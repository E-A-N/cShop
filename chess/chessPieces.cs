using System;

namespace ChessGame {
    public class ChessPiece {

        public int x;
        public int y;
        public int destiny;
        public string type;
        public int[] mobility;
        public int[] direction;
        public bool canMove;

        public void init(string type) {
            this.x = 0;
            this.y = 0;
            this.destiny = 0;
            this.canMove = false;
            this.type = type;

            switch(type){
                case "pawn":
                    this.mobility = new int[] {0,1};
                    //modify direction by a product of one for x and/or y coordinate
                    this.direction = new int[] {0,1};
                    break;
            }
        }
    }

    public class Pawn: ChessPiece {

        private bool isPawn = true;
    }
}
