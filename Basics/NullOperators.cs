using System;
using System.Text;


public class NullOperators
{
    static string str;
    public static void NullOperatorsTest()
    {    Console.WriteLine("\n---NullOperators---");
        //  NULL-COALESCING OPERATOR
        //Unikamy przypisania wartości NULL - gdy zmienna=null, przypisujemy wartość alternatywną
        string str2 = str ?? "Wartość zamiast null";
        Console.WriteLine("Str2: "+str2);
        
        //NULL-CONDITIONAL OPERATOR (Elvis)
        //Jeżeli str=null to wartością całego wyrażenia będzie null a nie wyjątek
        var len = str?.Length;
        Console.WriteLine("len: "+len); //null zamiast NullReferenceException
        var isNull = str?.Contains(str?.Substring(0,1)); //2 x null
        Console.WriteLine("isNull: "+isNull);
    }

}
