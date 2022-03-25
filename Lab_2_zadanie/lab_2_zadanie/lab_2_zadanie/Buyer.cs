using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();
        
        public Buyer(string name, int age) : base(name, age) {}

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }
        public void RemoveProduct(int index)
        {
           tasks.RemoveAt(index);
        }
        public override void Print()
        {
            Console.WriteLine($"\t{this.Name}: ({this.Age} y.o)");
            if (tasks.Any())
            {
                foreach (Product task in tasks)
                {
                    task.Print();
                }
            }
        }
    } 
}