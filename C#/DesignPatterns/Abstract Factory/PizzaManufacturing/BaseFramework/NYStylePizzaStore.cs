using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = new Pizza();

            switch (type)
            {
                case "1":
                    pizza.Name = "NY Cheese Pizza";
                    break;

                case "2":
                    pizza.Name = "NY Pepperoni Pizza";
                    break;

                case "3":
                    pizza.Name = "NY Clam Pizza";
                    break;

                default:
                    pizza.Name = "NY Veggie Pizza";
                    break;
            }

            return pizza;
        }
    }
}
