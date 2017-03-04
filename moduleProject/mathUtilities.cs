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
        ray[size - 6] = 0;
        ray[size - 5] = 0;
        ray[size - 4] = 0;
        ray[size - 3] = 0;
        ray[size - 2] = 0;
        ray[size - 1] = 0;
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
        int bounds = size - 1;

        //Sum is currently not being increased, update root with current iteration
        nums[root] = (nums[inc] == 1) ? nums[root] : nums[iter];
        if (nums[root] == 0 || nums[rep] == 0){
        //If multiplying by 0 than number final product is always 0
            result = 0;
        }
        else if (nums[iter] < nums[bounds] && nums[rep] > 1){
        //If iterations are before stopping point and repitions are left
            nums[sum] += nums[root];
            nums[inc] = 1;


            result = nums[sum] + calc(nums);

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
        numbers = (numbers.Length > 2) ? dataSanitize(numbers) : numbers;

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
