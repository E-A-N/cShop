/*
    Create a multiplication method that can multiply an infinte number of
    arguments recursively.

    restraints: No loops, No "*" operator, No multiplication methods
*/


using System;
class Multiplication {

    //Use data offset to adjust array for non-result appending items
    private const int dataOFFSET = 2;
    private static void cloneArray(ref int[] ray1, ref int[] ray2){
        /*
            Clones array in place with the exception of offset values
            managed within the dataSanitizing method
        */
        int relevantData = ray1.Length - dataOFFSET;
        for(int i = 0; i < relevantData; i++){
            ray2[i] = ray1[i];
        }
    }

private static int[] dataSanitize(params int[] nums){
        /*
            This function appends neccesary arguments to an array of parameters
            to enable a solution using as few data types as possible.
            This function will allow the muliplication fuction to execute
            a solution recursively.
        */
        int[] ray = new int[nums.Length + dataOFFSET];
        cloneArray(ref nums,ref ray);
        return ray;
    }

    private static int calc(params int[] nums){
        //result is used to assign recursive function calls
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
    public static int multiply(params int[] numbers){

        //in case of multiple arguments organize array elements
        numbers = numbers.Length > 2 ? dataSanitize(numbers) : numbers;

        //compute the numbers
        int answer = calc(numbers);
        return answer;
    }
    public static void Main(string[] args){
        int[] ray = new int[5];
        ray[0] = 3;
        ray[1] = 3;
        int num = multiply(ray);
        Console.WriteLine("Hello World? {0}",num);
        Console.WriteLine(ray.Length);
    }
}
