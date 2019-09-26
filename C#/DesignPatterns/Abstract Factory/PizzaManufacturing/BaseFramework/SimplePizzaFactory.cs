using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(String type)
        {
            Pizza pizza = new Pizza();

            switch (type)
            {
                case "1": 
                    pizza.Name = "Cheese Pizza"; 
                    break;

                case "2": 
                    pizza.Name = "Pepperoni Pizza"; 
                    break;

                case "3": 
                    pizza.Name = "Clam Pizza"; 
                    break;

                default:
                    pizza.Name = "Veggie Pizza";
                    break;
            }

            return pizza;
        }
    }
}
