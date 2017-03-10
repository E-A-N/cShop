using System;

public class ChessPiece {

    private int x;
    private int y;

    public void setXY(){
        this.x = 0;
        this.y = 0;
    }


    public static void Main(){

        ChessPiece pawn = new ChessPiece();
        pawn.setXY();
        Console.WriteLine("Hello Robo!");
    }


}
