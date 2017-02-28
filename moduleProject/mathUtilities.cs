/*
    Create a multiplication method that can multiply an infinte number of
    arguments recursively
*/


using System;
class Multiplication {

    public static int calc(params int[] nums){
        //result will is used to assign recursive function calls
        int result;
        //nextRep will check if next number is 0
        int nextRep = 1;

        if (nums.Length < 3){
            int root = nums[0];
            int rep  = nums[1];
            result = (rep == 0) ? 0 : root + calc(root, rep - 1);
        }
        else {
            Console.WriteLine("Nums is too big!");
            int queue = nums[nums.Length - 1];
            int root = nums[0];
            int rep = nums[queue];
            result = (rep == 0)  ? 0 : root + calc(root, rep - 1);
        }
        return result;
    }

    public static void Main(string[] args){
        int[] ray = new int[5];
        ray[0] = 3;
        ray[1] = 3;
        int num = calc(ray);
        Console.WriteLine("Hello World? {0}",num);
        Console.WriteLine(ray.Length);
    }
}
