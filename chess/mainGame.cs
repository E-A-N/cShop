using System;

namespace ChessGame{

    public class ChessBoard {
        private static int[,] makeBoard(){
            int size = 8;
            int[,] board = new int [size,size];
            for (int y = 0; y < size - 1; y++){
                for (int x = 0; x < size - 1; x++){
                    board[x,y] = 0;
                }
            }

            return board;
        }

        public static void Main(){

            Pawn p1 = new Pawn();
            p1.init();
            Console.WriteLine("Hello Robo!");
            Console.WriteLine("The pawns x coordinate is: {0}",p1.x);
        }
    }
}
