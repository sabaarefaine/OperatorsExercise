using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //explicity typing
            //string variableName = "hello"

            //inferred typing
            //var variableName = "hello"

            //exercise 1 division
            var a = 12;
            var b = 5;
            var division = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {division} with a remainder of {remainder}.");

            //exercise 2, area of a circle

            Console.WriteLine("What is the radius of your circle?");
            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);

            //calculate area
            var areaOfCircle = AreaOfCircle(realRadius);

            Console.WriteLine($"The area of your circle with a radius of {realRadius} is {areaOfCircle}");

      
        }


        //modifier, return type, name, parameter
        public static double AreaOfCircle(double radius)
        {
            //scope
            return Math.PI * (radius * radius);

        }
    }
}
