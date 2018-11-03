using System;
using System.Text;


    public class ArrayClass
    {
         private static int[] ArraySort(int[] arr){
            Array.Sort(arr); // sortowanie tablicy podanej jako parametr - nie tworzymy nowego obiektu !!!
            return arr;
        }

        private static void ArrayPrint(int[] arr){
            Console.Write("\nArrayPrint:[");
            foreach (int p in arr) Console.Write(p+",");
            Console.Write("]");
        }

        private static void ArrayCopy(){
            int[] a = new int[] {5,4,3};
            int[] b = new int[a.Length];
            a.CopyTo(b,0);
            Console.WriteLine("b: "+string.Join(",",b));
        }

        public static void ArrayClassTest(){
            Console.WriteLine("---\nArrayClass---");
            ArraySort(new int[] {5,3,1,90,2});
            ArrayCopy();
            ArrayPrint(new int[] {7,9,9,10,11,12});
        }
    }
