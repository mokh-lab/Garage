using System;
using System.Collections.Generic;

namespace Garage
{
    class Garage
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Welcome To Garage");
            //Break out to different place
            Console.WriteLine("Plase Enter The capacity of the garage");
            int capacity = int.Parse(Console.ReadLine());
           GarageHandler GH = new GarageHandler(capacity);

        
            UI ui = new UI(GH);
            //------Call User Interface
            ui.UserInterface();

           

         
        }
    }
}
