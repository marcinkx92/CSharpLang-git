using System;
using System.Text;


    public class CallByValue
    {
        public static void Calling(int a, StringBuilder stb) //otrzymałem kopię zm. wartościowej i kopię zm. referencyjnej
        {
            a++; //zmieniam kopię wartości
            stb.Append("To jest napis dodany przez metodę"); //zmieniam kopię referencji = modyfikuję też wskazywany obiekt
            stb = null;
            Console.WriteLine("Wewnątrz metody (parametry): ");
            Console.WriteLine($"a: {a}. stb: {stb}");
            
        }

        public static void Test()
        {
            Console.WriteLine("\n---CallByValueTest---");
            int value1 = 10;
            StringBuilder stb = new StringBuilder("Default");
            Calling(value1, stb);
            Console.WriteLine("Poza metodą (oryginalne zmienne): ");
            Console.WriteLine($"value1: {value1}, stb: {stb}");

        }
        /*Wniosek: przekazując zmienne jako parametr:
         -przekazujemy kopię wartości i kopię referencji
         -oryginalne zmienne nie naruszą się
         -w przypadku przekazania zm. referencyjnej mamy dostęp (modyfikujemy) do wskazywanego obiektu*/
    }
    