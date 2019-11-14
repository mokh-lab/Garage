using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
   public class GarageHandler
    {
        
        private GarageList<Vehicle> garage;

      

        public GarageHandler(int capacity)
        {
            garage = new GarageList<Vehicle>(capacity);
        }




        public void Park()
        {
            while (true)
            {
                char input = ' ';
                Console.WriteLine("Plase Choose The type of the Vehicle");
                Console.WriteLine("Plase Choose 1 for Car");
                Console.WriteLine("Plase Choose 2 for Bus");
                Console.WriteLine("Plase Choose 3 for Boat");
                Console.WriteLine("Plase Choose 4 for ParkMotoCyckle");
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {

                    Console.Clear();
                    Console.WriteLine("Please Enter A Valid Value");
                }

              
                //No loop
                for (int i = 0; i < garage.Capacity; i++)
                {

                    do
                    {

                        switch (input)
                        {
                            case '1':

                                ParkCar();
                                break;

                            case '2':
                                ParkBus();
                                break;

                            case '3':
                                ParkBoat();
                                break;

                            case '4':
                                ParkMotoCyckle();
                                break;


                            default:
                                break;
                        }
                    } while (garage.Capacity > i);
                }

            }
        }

        public void ParkCar()
        {
            Car car = new Car();
             garage.Park(car);
                       
            


        }
        public void ParkBus()
        {
            Console.WriteLine();
            var regNo = Console.ReadLine();
            Bus bus = new Bus(regno, type,  color);
            
        }

        public void ParkBoat()
        {
            Boat boat = new Boat(regno, type,  speed);
        }

        public void ParkMotoCyckle()
        {
            MotoCyckle motocyckle = new MotoCyckle(regno, type,catagory  ); 
        }

        /*
            public string UnPark(string regnr)
            {
                int i = 0;
                bool finns = false;
                string answer = "";
                int removeNr = 0;

                foreach (Vehicle s in vehicle)
                {
                    if (regnr.ToUpper() == s.Regnr.ToUpper())
                    {
                        removeNr = i;
                        finns = true;
                        answer = "Fordonet med registreringsnr " + regnr + " har lämnat garaget";
                    }
                    i++;
                }

                if (finns == false)
                    answer = "Det finns inget fordon med det registreringnumret i garaget";
                else
                    vehicle.RemoveAt(removeNr);

                return answer;
            }*/
        
    }
}
