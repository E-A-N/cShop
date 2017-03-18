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

            //x/y values represent position to index within arrays NOT something on a plane
            int x = 0;
            int y = 1;
            int xVector = piece.x + (piece.mobility[x] * piece.direction[x]);
            int yVector = piece.y + (piece.mobility[y] * piece.direction[y]);
            int[] destiny = {xVector, yVector};
            return playField.board;
        }
        private void updatePiece(ChessPiece piece){
            Console.WriteLine("Herro Robo");
        }

        private int[,] setBoard(){
            int size = 8;
            int[,] board = new int [size,size];
            for (int h = 0; h < size - 1; h++){
                for (int w = 0; w < size - 1; w++){
                    //board[w,h] = OPEN;
                    board[w,h] = h;
                }
            }
            this.displayBoard();
            return board;
        }

        private void displayBoard(){
            int size = 8;
            for (int xx = 0; xx < size; xx++){
                for (int yy = 0; yy < size; yy++){
                    Console.WriteLine(this.board[yy,xx].ToString() + ' ');
                }
            }
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
            gameStage.init();
        }
    }
}
