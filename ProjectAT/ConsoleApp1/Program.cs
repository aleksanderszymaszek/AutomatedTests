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
            var list = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Wartosc wynosi: {list[i]}");
            }

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Console.WriteLine($"Wartosc wynosi: {item}");
            }

            foreach (var item in list)
            {
                Console.WriteLine($"Wartosc wynosi: {item}");
            }

            foreach (int item in list)
            {
                Console.WriteLine($"Wartosc wynosi: {item}");
            }

            /*
             * Zoo zoo = new Zoo();
             * zoo.Add(new Dog());
             * zoo.Add(new Bird());
             * zoo.Add(new Fish());
             * zoo.MoveAll();
            */

            Console.ReadLine();

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
                    Animal an = new Dog(12, 23);
                    ((Dog)an).Jump(); // rzutowanie - doczytać!!!!
                    an.Move();
                    
                }
                else if (animal == "bird")
                {
                    Bird bird = new Bird();
                    bird.Age = 12;
                    bird.Size = 2;
                    bird.Move();

                }
                else if (animal == "fish")
                {
                    Fish fish = new Fish();
                    fish.Move();
                }
            }
        }
    }
}
