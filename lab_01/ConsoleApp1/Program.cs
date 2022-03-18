using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            Object obj1 = new Object();
            Console.WriteLine(obj1);

            var a = new Fraction(5, 4);
            var b = new Fraction(1, 2);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            List<Stud> list = new List<Stud>();
            list.Add(new Stud() { Name = "aaa", Salary = 15615 });
            list.Add(new Stud() { Name = "bbb", Salary = 21734 });
            list.Add(new Stud() { Name = "ccc", Salary = 17457 });
            list.Add(new Stud() { Name = "ddd", Salary = 62373 });

            list.Sort();

            foreach(var element in list)
                {
                Console.WriteLine("element");
                }
        }
            


        public class Student: IEquatable<Student>
        {
            private string name;
            private int age;
            
            public Student(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public bool Equals(Student other)
            {
                if (other == null) return false;
                if (other == this) return true;

                return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
            }
        }

        class Stud : IComparable<Stud>
        {
            public int Salary { get; set; }
            public string Name { get; set; }

            public int CompareTo(Stud other)
            {
                
                if (this.Salary == other.Salary)
                {
                    return this.Name.CompareTo(other.Name);
                }
               
                return other.Salary.CompareTo(this.Salary);
            }

            public override string ToString()
            {
                
                return this.Salary.ToString() + "," + this.Name;
            }
        }


        public readonly struct Fraction
        {
            private readonly int num;
            private readonly int den;

            public Fraction(int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
                }
                num = numerator;
                den = denominator;
            }
            public static Fraction operator +(Fraction a) => a;
            public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

            public static Fraction operator +(Fraction a, Fraction b)
                => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

            public static Fraction operator -(Fraction a, Fraction b)
                => a + (-b);

            public static Fraction operator *(Fraction a, Fraction b)
                => new Fraction(a.num * b.num, a.den * b.den);

            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.num == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Fraction(a.num * b.den, a.den * b.num);
            }

            public override string ToString() => $"{num} / {den}";
        }



        public class Object
        {


            public override string ToString()
            {
                return "something";
            }
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


            public class Kon
            {
                private string name;

                public Kon(string name)
                {
                    this.name = name;
                }

                public Kon(Kon kon)
                {
                    this.name = kon.name;
                }
            }


        }

    }
}
