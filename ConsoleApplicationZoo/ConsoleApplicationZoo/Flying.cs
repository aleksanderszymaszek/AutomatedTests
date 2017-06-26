using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationZoo
{
    class Flying : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I fly");
        }
    }
}
