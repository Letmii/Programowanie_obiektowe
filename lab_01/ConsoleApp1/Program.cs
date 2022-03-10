using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {



        }
        

        public class Ulamek
        {
            private int Licznik { get; set; }
            private int Mianownik { get; set; }

            public Ulamek(int licznik, int mianownik)
            {
                this.Licznik = licznik;
                this.Mianownik = mianownik;
            }

            
            public Ulamek()
            {
               
            }


            public class Student
            {
                private string name;

                public Student(string name)
                {
                    this.name = name;
                }

                public Student(Student student)
                {
                    this.name = student.name;
                }
            }


        }
    }
}
