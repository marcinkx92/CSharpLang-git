using System;
using System.Text;


    public class CallByValue
    {
        public static void Calling(int a, StringBuilder stb)
        {
            a++;
            stb.Append("To jest napis dodany przez metodę");
            stb = null;
            Console.WriteLine("Wewnątrz metody (parametry): ");
            Console.WriteLine($"a: {a}. stb: {stb}");
            
        }

        public static void CallByValueTest()
        {
            Console.WriteLine("\n---CallByValueTest---");
            int value1 = 10;
            StringBuilder string1 = new StringBuilder("Default");
            Calling(value1, string1);
            Console.WriteLine("Poza metodą (oryginalne zmienne): ");
            Console.WriteLine($"value1: {value1}, string1: {string1}");

        }
        /*Wniosek: przekazując zmienne jako parametr:
         -przekazujemy kopię wartości i kopię referencji
         -oryginalne zmienne nie naruszą się
         -w przypadku przekazania zm. referencyjnej mamy dostęp (modyfikujemy) do wskazywanego obiektu*/
    }
    