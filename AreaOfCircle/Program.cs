using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaOfCircle();
        }

        public static void AreaOfCircle()
        {
            
            Console.WriteLine("What is the radius of a circle?");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * (radius * radius);

             Console.WriteLine(area);
        }
    }
}

