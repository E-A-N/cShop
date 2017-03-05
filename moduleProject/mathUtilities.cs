/*
    Create a multiplication method that can multiply an infinte number of
    arguments recursively.

    restraints: No loops, No "*" operator, No multiplication methods
*/


using System;
class Multiplication {

    //Use data offset to adjust array for non-result appending items
    private const int dataOFFSET = 6;
    private static void cloneArray(ref int[] specimen, ref int[] clone){
        /*
            Clones array in place with the exception of offset values
            that are managed within the dataSanitizing function
        */
        int relevantData = specimen.Length - dataOFFSET;
        for(int i = 0; i < relevantData; i++){
            clone[i] = specimen[i];
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
        int size = ray.Length;
        cloneArray(ref nums,ref ray);
        ray[size - 6] = ray[0]; //root
        ray[size - 5] = ray[1]; //rep
        ray[size - 4] = 0; //sum
        ray[size - 3] = 0; //is incrementing (pseudo boolean)
        ray[size - 2] = 1; //iteration
        ray[size - 1] = -77777; //boundary
        return ray;
    }

    private static int calc(params int[] nums){
        //result is used to assign recursive f unction calls
        int result;
        int size = nums.Length;
        int root = size - 6; //increment this value by rep
        int rep = size - 5;  //current number to multiply
        int sum = size - 4;  //number of times to add iteration
        int inc = size - 3; //boolean flag 1 if incrementing else 0
        int iter = size - 2; //current multiplication root
        int boundary = size - 1;

        //debug loops
        /*
        for (int x = 0; x > 0; x--){
            Console.WriteLine("X in array is currently: {0}" , nums[size - x]);
        }
        */

        //Sum is currently not being increased, update root with current iteration
        nums[root] = (nums[inc] == 1) ? nums[root] : nums[iter];

        if (nums[root] == 0 || nums[rep] == 0){
        //If multiplying by 0 than number final product is always 0
            result = 777;
        }
        else if (nums[iter] < boundary && nums[rep] > 1){
        //If iterations are before stopping point and repitions are left
            //check for new recurisve iteration
            nums[iter] = (nums[rep] - 1 == 0) ? nums[iter]++ : nums[iter];

            //Allocate the repition supply of root value and rep value in array
            nums[sum] += nums[root];
            nums[rep] -= 1;
            nums[inc] = 1;
            result = nums[sum] + calc(nums);

        }
        else if (nums[iter] == boundary) {
        //get rid of left side of comparison above, only use for explict testing
            result = sum;
        }
        else {
            Console.WriteLine("Error in control flow!!");
            result = 999;
        }

        return result;
    }
    public static int multiply(params int[] numbers){

        //in case of multiple arguments organize array elements
        int[] cleanInputs = dataSanitize(numbers);

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
