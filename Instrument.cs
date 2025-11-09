using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    internal class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыку!");
        }
    }

    class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Брень-Брень!");
        }
    }
    class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум-Бум!");
        }
    }
}
