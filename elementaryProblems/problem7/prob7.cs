/*
    7. Write a program that prints a multiplication table for numbers up to 12.
*/

using System;
class Problem7{

    string table;

    private int multiply(int root,int repetition){

        if (repetition == 0){
            return 0;
        }
        return root + multiply(root, repetition - 1);
    }

    private string renderInt(int num, int max){
        string equation = Convert.ToString("");
        for(int i = 0; i < max + 1; i++){
            equation += String.Format("{0} x {1} = {2} | ",i ,num ,this.multiply(i,num) );
        }
        equation += "\n";

        return equation;
    }

    public void setTable(int tableNum, int max) {
        string tableRows = Convert.ToString("");
        for(int r = 0;r < tableNum + 1; r++) {
            tableRows += this.renderInt(r,max);
        }

        this.table = tableRows;
    }

    public static void Main(){
        Problem7 app = new Problem7();
        app.setTable(6,6);

        Console.WriteLine(app.table);
        //Console.WriteLine(app.multiply(9,9));
    }
}
