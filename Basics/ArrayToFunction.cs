using System;
using System.Text;

    public class ArrayToFunction
    {
        // simple examples passing arrays to functions

        private static void ArrayPrint(int[,] arr){
            for (int i=0; i<arr.Rank; i++){
                for (int j=0; j<arr.GetLength(i); j++)
                    {
                        Console.Write(arr[i,j]+ " ");
                    }
                    Console.WriteLine();
            }
        }

       public static void ArrayToFunctionTest(){
           Console.WriteLine("---\nArrayToFunction---");
           int[,] a = { 
               {1,2,3},
               {4,5,6}
           };
           ArrayPrint(a);
       }
    }
