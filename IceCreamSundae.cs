using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class IceCreamSundae : IceCream
    {
        public IceCreamSundae()
        {
            toppings = new List<Toppings>();
        }
        public override void DoSomething(Toppings toppings)
        {
            // do stuff in here...
            numScoops++;
            base.DoSomething(toppings);
        }
    }
}
