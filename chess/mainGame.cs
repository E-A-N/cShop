using System;

namespace ChessGame{

    public class ChessBoard {

        const int OPEN = 0;
        const int BLOCKED = 1;
        const int RANGE = 2;

        public int[,] board;

        private int[,] updateBoard(params int[] pieces){
            int group = pieces.Length - 1;
            for (int i = 0; i < group; i++){
                //hi
            }
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

            Pawn p1 = new Pawn();
            p1.init();
            Console.WriteLine("Hello Robo!");
            Console.WriteLine("The pawns x coordinate is: {0}",p1.x);

            ChessBoard gameStage = new ChessBoard();
            //gameStage.init();
            //Console.WriteLine ("{0}",string.Join(",",CB));
            //Console.WriteLine();
        }
    }
}
