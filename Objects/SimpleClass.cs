using System;

// jeżeli odwołujemy się do składowych klasy (lub tworzymy obiekty tej klasy) z metody wewnętrznej, składowe mogą być PRYWATNE

public class SimpleClass
{
        private int x;
        private string str;

        private SimpleClass(int x, string str)
        {
            this.x = x;
            this.str = str;
        }

        private void Concat()
        {
            Console.WriteLine(x+str);
        }

        // utworzymy obiekt klasy SimpleClass z metody zmajdującej się w tej samej klasie
        public static void RunClass()
        {
            SimpleClass simple = new SimpleClass(10, "simpleObject");
            simple.Concat();
        }
 }


