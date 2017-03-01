/*
    Create a multiplication method that can multiply an infinte number of
    arguments recursively
*/


using System;
class Multiplication {

    private int[] cloneArray(ref int[] ray1, ref int[] ray2, int iter = 0){
        ray2[iter] = ray1[iter];
        return cloneArray(ray1,ray2,iter++)
    }

    public static int calc(params int[] nums){
        //result will is used to assign recursive function calls
        int result;
        if (nums[nums.Length - 1] == 0){
                int sumAssign; //total sum
                int repAssign; //number of times to add iteration
                int iterAssign; //iterate through arguments
                int flagAssign; //check if array is ititialized
                int sum = ray[ray.Length - 4];
                int rep = ray[ray.Length - 3];
                int iter = ray[ray.Length - 2];
                int flag = ray[ray.Length - 1];
                result = ray[iter] + calc(ray);
        }
        else {
            int[] ray = new int[nums.Length + 3];

            result
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
