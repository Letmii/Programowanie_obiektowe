using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop : IThing
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private Person[] people;

        private Product[] products;

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }
        public void Print()
        {
            Console.WriteLine($"Shop: {this.name}" );
            
            Console.WriteLine("--People:--");
            foreach (Person person in people)
            {
                person.Print();
            }
            
            Console.WriteLine("--Products:--");
            foreach (Product product in products)
            {
                product.Print();
            }
        }
    }
}
