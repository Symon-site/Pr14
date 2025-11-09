using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    internal class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
    class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }
}
