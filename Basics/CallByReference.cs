using System;
using System.Text;


    public class CallByReference
    {
        public static void CallingRef(ref int a, ref StringBuilder stb) //przekazujemy referenjcę
        {
            a++;
            stb.Append("To jest napis dodany przez metodę");
            stb = null;
            Console.WriteLine("Wewnątrz metody (parametry): ");
            Console.WriteLine($"a: {a}. stb: {stb}");
            
        }

        public static int CallingOut(out int wynik, int int1, int int2)
        {
            wynik = int1 + int2;
            return wynik;
        }

        public static void CallByReferenceTest()
        {
            Console.WriteLine("\n---CallByReferenceTest---");
            int value1 = 10;
            StringBuilder string1 = new StringBuilder("Default");
            CallingRef(ref value1,ref string1); // w wywołaniu tez trzeba dopisać ref do parametrów
            Console.WriteLine("Poza metodą (oryginalne zmienne): ");
            Console.WriteLine($"value1: {value1}, string1: {string1}");

            
            //metoda z OUT: nie musimy przekazywać na wejściu parametru out, ale musi on być na wyjściu (również referencja)
            int wynik = 0;
            Console.WriteLine("Wynik dodawania: "+CallingOut(out wynik, 100, 101));
            Console.WriteLine("Oryginalna zmienna wynik: "+wynik  );
        }
        /*Wniosek: przekazując zmienne jako referenję:
         -przekazujemy oryginalne zmienne: zmienną wartościową jako referencję do wartości, zm. referencyjną jako nią samą
         -pracujemy na oryginalnych zmiennych
         */
    }
    