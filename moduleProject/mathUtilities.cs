/*
    Create a multiplication method that can multiply an infinte number of
    arguments recursively
*/


using System;
class Multiplication {

    //Use data offset to adjust array for non-result appending items
    private static int dataOffset = 2;

    private static void cloneArray(ref int[] ray1, ref int[] ray2, int iter = 0){
        for(;iter < ray1.Length - dataOffset; iter++){
            ray2[iter] = ray1[iter];
        }
    }

    private static int[] dataSantizer(params int[] nums){
        int[] ray = new int[nums.Length + dataOffset];
        cloneArray(nums,ray);
        return ray;
    }

    public static int calc(params int[] nums){
        //result will is used to assign recursive function calls
        int result;

        if (nums[0] == 0 || nums[1] == 0){
            result = 0;
        }
        else if (nums[0] == 0 || nums[1] == 0){
            result = 0;
        }
        else {
            result = nums[0] + calc(nums[0],nums[1] - 1);
        }

        /*
        if (nums[nums.Length - 1] == 0){
            int sumAssign = nums.Length - 4; //total sum
            int repAssign = nums.Length - 3; //number of times to add iteration
            int iterAssign = nums.Length - 2; //iterate through arguments
            int flagAssign = nums.Length - 1; //check if array is ititialized
            int sum = nums[sumAssign];
            int rep = nums[repAssign];
            int iter = nums[iterAssign];
            int flag = nums[flagAssign];

            sum += nums[iter]
            rep = rep - 1;
            if (rep - 1 == 0 && iter < sumAssign) {
                //repition value has been exhausted, move to next item
                iter++
            }
            else if (rep == 0){
                //the sum is being multiplied by zero
                return 0;
            }
            result = nums[iter] + calc(ray);
        }
        else {
            //
            int[] ray = new int[nums.Length + 3];
            this.cloneArray(nums,ray);
            ray[ray.Length - 1] = 0;
            result = ray;
        }
        */
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
