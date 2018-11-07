    using System;
    public class SimpleClass1
    {   
        private int level;
        private string name;
        private SimpleClass1(int x, string str)
        {
            this.name=str;
            this.level=x;
        }
        private void PrintObjectData()
        {
            Console.WriteLine("SimpleObject name"+this.name+" , level: "+this.level);
        }

          public static SimpleClass1Test()
          {
            SimpleClass1 SimpleObject = SimpleClass1("Mag",70);
            SimpleObject.PrintObjectData();
          }  
    }

    


