using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class IceCream
    {
        public enum Toppings
        {
            sprinkles,
            hotFudge,
            cherry
        }
        protected List<Toppings> toppings;
        public enum ConeType
        {
            standard,
            waffle,
            chocolateDip
        }
        ConeType coneType;

        protected int numScoops;

        public IceCream(ConeType coneType, int numScoops)
        {
            this.coneType = coneType;
            this.numScoops = numScoops;
            toppings = new List<Toppings>();
        }
        public IceCream(ConeType coneType, List<Toppings> toppings, int numScoops)
        {
            this.coneType = coneType;
            this.numScoops = numScoops;
            this.toppings = toppings;
        }

        public IceCream()
        {
            coneType = ConeType.standard;
            numScoops = 0;
            toppings = new List<Toppings>();
        }

        public virtual void DoSomething(Toppings topping)
        {
            // stuff
            this.toppings.Add(topping);
        }

        public void MoreStuff()
        {
            // more stuff
        }

        string ListToppings()
        {
            string text = "\n";
            for(int num = 0; num < toppings.Count; num++)
            {
                text += "\t" + toppings[num] + "\n";
            }
            return text;
        }

        public override string ToString()
        {
            return $"ConeType:{coneType}\nNumberOfScoops:{numScoops}\nToppings:{ListToppings()}";
        }
    }
}
