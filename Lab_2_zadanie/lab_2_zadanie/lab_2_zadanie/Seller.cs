using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Seller : Person
    {
        public Seller(string name,int age) : base(name,age) {}
        public override void Print()
        {
            Console.WriteLine($"\t{this.Name}: ({this.Age} y.o)");
        }
    }
}
