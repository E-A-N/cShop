
/*
6. Write a program that asks the user for a number n and gives him the
possibility to choose between computing the sum and computing the product of 1,…,n.
*/


using System;
class nameAndNum {

    //attributes
    private string name;
    private int number;
    private int decision;

    //setters
    private void setName(){
      string name;
      Console.WriteLine("Herro Robo, what is your name?: ");
      name = Console.ReadLine();
      Console.WriteLine("It\'s nice to meet you, {0}",name);

      this.name = name;
    }
    private void setNumber(){
      int num;
      Console.WriteLine("Herro {0}, what\'s your favorite number?: ",this.name);
      num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("{0} is your number, {1}!",num,this.name);

      this.number = num;
    }
    private void setDecision(){
      int decision;
      string msg = "Press 1 to get sums to {0}: \nPress 2 to get product to {0}: \nPress 0 to quit!";
      Console.WriteLine(msg,this.number);
      decision = Convert.ToInt32(Console.ReadLine());
      this.decision = decision;
    }

    //Behaviors
    private void reiterateDecision(int choice){
      string msg;
      switch(choice){

          case 1:
              msg = "You wish to add all of the numbers from 0  to {0}! Cool {1}!";
              Console.WriteLine(msg,this.number,this.name);
              break;

          case 2:
              msg = "You wish to multiply all of the numbers from 0 to {0}! That\'s pretty awesome {1}!";
              Console.WriteLine(msg,this.number,this.name);
              break;

          case 0:
              msg = "Sorry {0}, that\'s unfortunate!";
              Console.WriteLine(msg,this.name);
              break;

      }
    }

    private void multiplicationRoute(){
        int accumulator = 0;
        for (int i = 0; i < this.decision; i++){
            accumulator = accumulator * i;
        }

    }

    public static void Main (string[] args) {
      nameAndNum app; //initialize program

      app = new nameAndNum(); //instantiate program
      app.setName();
      app.setNumber();
      app.setDecision();
      app.reiterateDecision(app.decision);
    }
}
