using System;

/*HERMETYZACJA
-jeżeli brak modyfikatora, domyślnie ustawiany jest dostęp PRIVATE
-PUBLIC: dostęp dla wszystkich klas w przestrzeni nazw
-PRIVATE: dostęp spoza klasy niemożliwy
-PROTECTED: dostęp dla klas dziedziczących
-INTERNAL: dostęp tylko wewnątrz BIBLIOTEKI DLL
-PROTECTED INTERNAL: dostęp dla klas potomych w BIBLIOTECE DLL
*/

public class Hermetization
{
    public static int x;
    private static int y;
    protected static int z;

    public static void Test()
    {
        //tutaj mamy dostęp do wszystkich składowych klasy
        Console.WriteLine($"Wewnątrz klasy Hermetization:x={x}, y={y}, z={z}");
    }
}

public class Class1
{
    public static void Test()
    {
        Console.WriteLine("x="+Hermetization.x);
        //Console.WriteLine("y="+Hermetization.y); //brak dostępu
        //Console.WriteLine("z="+Hermetization.z); //brak dostępu
    }
}

public class Class2 : Hermetization //class2 dziedziczy po Hermetization
{
    public static void Class2Test()
    {
        Console.WriteLine("z="+Hermetization.z); //tutaj mamy dostęp do składowej PROTECTED
    }

}






    