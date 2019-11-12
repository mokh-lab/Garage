using System;
using System.Collections.Generic;

namespace Garage
{
    class Garage
    {
        static void Main(string[] args)
        {

            // Vehicle vehicle = new Vehicle();

            //public GarageList<Vehicle> GarageLst { get; set; }

            // Console.WriteLine("Welcome To Garage");

            //------Call User Interface

            GarageHandler g = new GarageHandler();

            g.UI();

           

         
        }
    }
}
