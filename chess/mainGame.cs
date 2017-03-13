using System;

namespace ChessGame{

    public class ChessBoard {

        private const int OPEN = 0;
        private const int BLOCKED = 1;
        private const int RANGE = 2;

        public int[,] board;

        private int[,] updateBoard(ChessBoard playField, ChessPiece piece){
        /*
            playField parameter should represent the current state of the game in regards to pieces and their positions.

            "dest" parameter should represent the trajectory of a particular piece.
                dest should equal pieces x and y position on board, plus their mobility and direction
        */
            int x = 0;
            int y = 1;
            int[] destiny = new int[piece.x + (piece.mobility[x] * piece.direction[x]), piece.y + (piece.mobiilty[y] * piece.direction[y]);
            return playField.board;
        }
        private void updatePiece(ref ChessPiece piece){

        }

        private int[,] setBoard(){
            int size = 8;
            int[,] board = new int [size,size];
            for (int y = 0; y < size - 1; y++){
                for (int x = 0; x < size - 1; x++){
                    board[x,y] = OPEN;
                }
            }

            return board;
        }
        public void init(){
            this.board = this.setBoard();
        }
        public static void Main(){

            ChessPiece p1 = new ChessPiece();
            p1.init("pawn");
            Console.WriteLine("Hello Robo!");
            Console.WriteLine("The pawns x coordinate is: {0}",p1.x);

            ChessBoard gameStage = new ChessBoard();
            //gameStage.init();
            //Console.WriteLine ("{0}",string.Join(",",CB));
            //Console.WriteLine();
        }
    }
}
