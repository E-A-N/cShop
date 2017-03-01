using System;
class dynamicArray{

    private int[] arrayMaker(params int[] rArgs){
        return rArgs;
    }

    public static void Main(string[] args){
        dynamicArray ray = new dynamicArray;
        ray.arrayMaker(2,4,6,8,10);

        for(int i = 0; i < ray.arrayMaker.Length; i++){
            Console.WriteLine(i);
        }
    }

}
