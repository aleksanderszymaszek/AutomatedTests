using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type animals You want to add:");
            Console.WriteLine("Type Exit to close program");

            while (true)
            {
                string animal = Console.ReadLine();
                if (animal == "Exit")
                {
                    break;
                }
                else if (animal == "dog")
                {
                    Animal dog = new Dog();
                    dog.Move();
                    
                }
                else if (animal == "bird")
                {
                    Animal bird = new Bird();
                    bird.Move();

                }
                else if (animal == "fish")
                {
                    Animal fish = new Fish();
                    fish.Move();

                }

            }
        }
    }
}
