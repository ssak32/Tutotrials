using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework
{
    public class ChicagoStypePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = new Pizza();

            switch (type)
            {
                case "1":
                    pizza.Name = "Chicago Cheese Pizza";
                    break;

                case "2":
                    pizza.Name = "Chicago Pepperoni Pizza";
                    break;

                case "3":
                    pizza.Name = "Chicago Clam Pizza";
                    break;

                default:
                    pizza.Name = "Chicago Veggie Pizza";
                    break;
            }

            return pizza;
        }
    }
}
