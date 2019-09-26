using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.Interfaces
{
    interface IProcessPizza
    {
        String Name { get; set; }

        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
