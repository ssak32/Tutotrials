using BaseFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaManufacturing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select type of Pizza");
            Console.WriteLine("1. Cheese Pizza");
            Console.WriteLine("2. Pepperoni Pizza");
            Console.WriteLine("3. Clam Pizza");
            Console.WriteLine("4. Veggie Pizza");

            String type = Console.ReadLine().ToString();

            PizzaStore pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza(type);

            Console.WriteLine("Your order is ready: " + pizzaStore.Name);
            Console.ReadLine();
        }
    }
}
