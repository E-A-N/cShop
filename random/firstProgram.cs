nameSpace Test_Program {
    class MainClass {
    
        public static int doubler(int num){
            return num * num;
        }
        
        public static void Main (string[] args){
        
            string xIS = "X is ";
            string yIS = "Y is ";
            string xyIS = "X + Y is ";
            int[] rayA = { 2,3,4,5,6,7,8,9,45};

            Console.WriteLine(rayA[3]);

            for (int x = 0; x < 10; x++){
                for (int y = 0; y < 10; y++){
                    Console.WriteLine("{0} {1}, {2} {3}", xIS, rayA[x], yIS, rayA[y]);
                    Console.WriteLine( doubler(rayA[x]) + doubler(rayA[y]) );              
                }
            }        
        }
     }
}
