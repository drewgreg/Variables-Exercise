using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration syntax

            dogName = "Rex"; //Initialization syntax

            int dogAge = 5; //Declaration and Initialization syntax

            char firstInitial = 'R';

            bool isHungry = true;

            double dogWeight = 54.3;

            decimal dogHeight = 14.7m;

            Console.WriteLine($"My dog's name is {dogName}. " +
                $"He is {dogAge} years old, he weighs {dogWeight} lbs, " +
                $"and he is {dogHeight} inches tall.");
        }
    }
}

