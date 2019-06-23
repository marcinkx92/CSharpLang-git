using System;
using System.Text;


    public class ThisKeyword
    {
        public class Subclass
        {
            
        }
        private Subclass sb= null;
        private int x;

        //THIS pozwala uniknąć konfliktu nazw
        public ThisKeyword(int x)
        {
            this.x = x;
        }

    }
    
    //INDEKSATORY - przykład użycia THIS
    //INDEKSATOR pozwala używać indeksów [] jak w tablicach dla własnej klasy-kolekcji
    public class SimpleCollection<T> //klasa mająca właściwość tworzenia tablic
    {
        private T[] arr = new T[100]; // tablica klasy T

        public T this[int i]
        {
            get { return arr[i];}
            set { arr[i] = value; }
        }
        
    }

public class IndexerTest
{
    public static void Test()
    {
        var  ind = new SimpleCollection<string>();
        Console.WriteLine(ind[0]);
    }
}

