using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
  
  public  class Vehicle 
    {
        public string RegNo { get ; set ; }
        public string Type { get; set; }

       
    }

    class Car : Vehicle
    {
      public string FuleType { get; set; }

        public Car(string regno,string type,string fuletype)
        {
             RegNo= regno;
             Type= type;
            FuleType = fuletype;
        }

        
    }

    class Bus : Vehicle
    {
        string Color { get; set; }
        public Bus(string regno, string type, string color)
        {
            RegNo = regno;
            Type = type;
            Color = color;
        }

    }

    class Boat : Vehicle
    {
        int Speed { get; set; }

        public Boat(string regno, string type, int speed)
        {
            RegNo = regno;
            Type = type;
            Speed = speed;
        }
    }

    class MotoCyckle : Vehicle
    {
        string Catagory  { get; set; }

        public MotoCyckle(string regno, string type,string catagory)
        {
            RegNo = regno;
            Type = type;
            Catagory = catagory;
        }
    }
}
