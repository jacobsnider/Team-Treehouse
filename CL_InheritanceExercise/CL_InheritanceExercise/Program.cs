using System;

namespace CL_InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnimal = new Platypus();
            Console.WriteLine(myAnimal.ReproductionMethod());
        }
    }
}
