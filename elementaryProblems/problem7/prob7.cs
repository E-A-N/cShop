/*
    7. Write a program that prints a multiplication table for numbers up to 12.
*/

using System;
class Problem7{

    public const int MAX = 4;
    string table;

    private int multiply(int root,int repition){
        int result = 0;
        for(int z = 0; z < repition; z++){
            result += root;
        }

        return result;
    }

    private string renderInt(int num, int max){
        string equation = Convert.ToString("");
        for(int i = 0; i < max + 1; i++){
            equation += String.Format("{0} x {1} = {2} | ",i ,num ,this.multiply(i,num) );
        }
        equation += "\n";

        return equation;
    }

    public setTable(int num){
        string tableRows = Convert.ToString("");
        for(int r = 0;r < num; r++){
            tableRows += this.renderInt(r,MAX);
        }

        this.table = tableRows;
    }

    public static void Main(){
        Problem7 app = new Problem7();
        app.setTable(4);

        Console.WriteLine(app.table);
        //Console.WriteLine(app.multiply(9,9));
    }
}
