using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework
{
    public abstract class PizzaStore
    {        
        public String Name { get; set; }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            this.Name = pizza.Name;
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(String type);
    }
}
