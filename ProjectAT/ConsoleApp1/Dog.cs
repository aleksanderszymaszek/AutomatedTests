using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : WalkingAnimals
    {
        public Dog(int age, int size)
        {
            Age = age;
            Size = size;
        }

        public override void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }
}
