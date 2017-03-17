using System;
/*
    This program is to practice  conventions in designing/organizing
    abstractions.
*/
namespace ConsoleApplication{

    public class abstracts {

        public static void fizzBuzz(int num){
            bool multipleOf3;
            bool multipleOf5;
            bool multipleOf3And5;

            for(int x = 0; x < num; x++){
                multipleOf3 = (x % 3 == 0);
                multipleOf5 = (x % 5 == 0);
                multipleOf3And5 = (multipleOf3 && multipleOf5);

                if(multipleOf3And5){
                    Console.WriteLine("FizzBuzz Baybeh!");
                    continue;
                }
                if(multipleOf3){
                    Console.WriteLine("Buzz!");
                    continue;
                }
                if(multipleOf5){
                    Console.WriteLine("Fizz!");
                    continue;
                }
                Console.WriteLine(x);
            }
        }


        public static void Main(){
                fizzBuzz(100);
        }
    }
}
