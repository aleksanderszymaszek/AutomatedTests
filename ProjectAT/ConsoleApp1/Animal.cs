using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public int Size { get; set; }

        public int Age { get; set; }

        public abstract void Move();
    }
}
