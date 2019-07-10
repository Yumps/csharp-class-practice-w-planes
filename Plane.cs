using System;

namespace csharp_planes
{
    public class Plane
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public void Fly()
        {
            Console.WriteLine($" This {Make} {Model} has {NumberOfSeats} seat(s).");
        }
    }
}