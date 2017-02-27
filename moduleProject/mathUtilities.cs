
using System;
class Multiplication {

    public static int calc(params int[] nums){
        int root = nums[0];
        int rep  = nums[1];

        if (rep == 0) {
            return 0;
        }
        return root + calc(root, rep - 1);
    }

    public static void Main(string[] args){
        int num = calc(3,3);
        Console.WriteLine("Hello World? {0}",num);
    }
}
