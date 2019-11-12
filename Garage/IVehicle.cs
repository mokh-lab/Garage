using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    interface IVehicle
    {
        String RegNo { get; set; }
        String Type { get; set; }

    }

    class Vehicle : IVehicle
    {
        public string RegNo { get ; set ; }
        public string Type { get; set; }
    }

    class Car : Vehicle
    {
       string FuleType { get; set; }
        
        
        
    }

    class Bus : Vehicle
    {
        string Color { get; set; }
    }

    class Boat : Vehicle
    {
        int Spped { get; set; }
    }

    class Moped : Vehicle
    {
        double Distance { get; set; }
    }

    class MotoCyckle : Vehicle
    {
        string Catagory  { get; set; }
    }
}
