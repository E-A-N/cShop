using System;
class dynamicArray{

    public int[] storage;
    public int[] backUpStore;
    public int[] arrayMaker(params int[] rArgs){
        return rArgs;
    }

    public static void Main(string[] args){
        int[] testArray = {9,9,197};
        dynamicArray ray = new dynamicArray();
        ray.storage = ray.arrayMaker(2,4,6,8,10);
        ray.backUpStore = ray.arrayMaker(testArray);

        for(int i = 0; i < ray.storage.Length; i++){
            Console.WriteLine(ray.storage[i]);
        }
    }

}
