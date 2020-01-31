using System;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            var motorcycle1 = new Motorcycle();

            car1.Drive();
            motorcycle1.Drive();
        }
    }
}
