using System;
namespace CL_InheritanceExercise
{
    public class Animal
    {
        public string Species { get; set; }
        public string AnimalType { get; set; }
        public string ReproductionMethod()
        {
            return "Platypus reproduce by laying eggs.";
        }
    }
}
