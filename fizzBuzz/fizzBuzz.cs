/*
    Write a program that prints the numbers 1 to 100.  But for multiples of three
    print "Fizz" instead and for the multiples of five print "Buzz".  For numbers
    which are multiples of both three and five print "FizzBuzz"
*/

﻿using System;
namespace ConsoleApplication {
    public class Program {

        public static void fizzBuzz(int num){
             for (int i = 0; i < num; i++){
                 if (i % 3 == 0){
                     if (i % 5 == 0){
                         Console.WriteLine("FizzBuzz baybeh!!");
                     }
                     else {
                         Console.WriteLine("Fizz");
                     }
                 }
                 else if (i % 5 == 0){
                     Console.WriteLine("Buzz");
                 }
                 else{
                     Console.WriteLine(i);
                 }
             }
        }

        public static void Main(string[] args){
            int cap = 100;
            bool isFive;
            bool isFour;
            bool isBoth;
            isFive = (5 == 5);
            isFour = (4 == 4);
            isBoth = (isFive && isFour);
            Console.WriteLine(isBoth);
            //fizzBuzz(cap);
        }
    }
}
