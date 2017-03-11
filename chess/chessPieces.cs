using System;

public class ChessPiece {

    private int x;
    private int y;
    private bool canMove;

    public void init(){
        this.x = 0;
        this.y = 0;
        this.canMove = false;
    }


    public static void Main(){

        ChessPiece pawn = new ChessPiece();
        pawn.init();
        Console.WriteLine("Hello Robo!");
    }


}
