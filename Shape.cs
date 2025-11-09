using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    internal abstract class Shape
    {
        public abstract void Draw();
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисую круг!");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисую треугольник!");
        }
    }
}
