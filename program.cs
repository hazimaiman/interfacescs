using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface = defines a contract that all the classes inheriting from should follow
            // An interface declatres what class should have
            // An inheriting class defines how it should do it

            // Benefits = security + multiple inheritance + plug and play

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            hawk.Hunt();
            fish.Hunt();

            Console.ReadKey();
        }
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {

        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The Rabbit run away");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk seacrh food");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("fish away");
            }
            public void Hunt()
            {
                Console.WriteLine("seach small fish");
            }
        }



    }
}



