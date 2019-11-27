using System;
using Zoo.Lib;

namespace Zoo.Cons
{
    class Program
    {
        static void Main(string[] args)
        { 
            PublicZoo zoo = new PublicZoo(39M);
            Console.WriteLine("Hello Nightly tourist!\n");
            foreach (Lion lion in zoo.LionCage.Lions)
            {Console.WriteLine($"Grrrrr.... I am {lion.Name}, my sex is {lion.Sex}");


            }
           
        }
    }
}
