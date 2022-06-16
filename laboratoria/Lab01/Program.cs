using System;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(5, 4);
            Ulamek b = new Ulamek(5, 4);
            Console.WriteLine( );
        }


        //klasa ulamek
        public class Ulamek
        {
            //2 prywatne zmienne licznik i mianownik
            private int licznik;
            private int mianownik;

            //konstruktor bez argumentów
            public Ulamek()
            {

            }

            //konstruktor z dwoma argumentami
            public Ulamek(int licznik, int mianownik)
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }
            //konstruktor kopiujący 1 argument
            public Ulamek(Ulamek previousUlamek)
            {
                licznik = previousUlamek.licznik;
            }

            //metoda ToString
              public void ToString()
            {

            }         

            //przeładowanie + przez zmiane liczby parametrów
            public int Add(int a, int b)
            {
                int sum = a + b;
                return sum;
            }
            public int Add(int a, int b, int c)
            {
                int sum = a + b + c;
                return sum;
            }
            // przeładowanie -
            public int Substract(int a, int b)
            {
                int sum = a - b;
                return sum;
            }
            public int Substract(int a, int b, int c)
            {
                int sum = a - b - c;
                return sum;
            }
            //przeładowanie *
            public int Multiply(int a, int b)
            {
                int sum = a * b;
                return sum;
            }
            public int Multiply(int a, int b, int c)
            {
                int sum = a * b * c;
                return sum;
            }
            //przeładowanie /
            public int Divide(int a, int b)
            {
                int sum = a / b;
                return sum;
            }
            public int Divide(int a, int b, int c)
            {
                int sum = a / b / c;
                return sum;
            }

        }
      



    }
}
