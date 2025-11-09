using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    internal class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим!");
        }
    }
    class Pizza:Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }
}
