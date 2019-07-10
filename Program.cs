using System;
using System.Collections.Generic;

namespace csharp_planes
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane boeing = new Plane()
            {
                Make = "Boeing",
                Model = "THE-YES-MOBILE",
                NumberOfSeats = 2
            };

            Plane flyingmachine = new Plane()
            {
                Make = "contraption",
                Model = "dern kids and them flyin machines1!1!!",
                NumberOfSeats = 1
            };
            boeing.Fly();
            flyingmachine.Fly();
        }
    }
}
