using System;
using System.Collections.Generic;
using System.Linq;
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
            // Console.WriteLine(  garage.array.Length);
            /*
            List<string> feedback = new List<string>();

            IEnumerable<Vehicle> query = from s in garage.array
                  where s  != null
                  select s;

            foreach (var item in garage.array)
            {
                feedback.Add(item.ToString());
                Console.WriteLine(feedback.Count);
            }*/

           
            bool a=true;
            while ( a == true)
            {
                char input = ' ';
                Console.WriteLine("Plase Choose The type of the Vehicle");
                Console.WriteLine("Plase Choose 1 for Car");
                Console.WriteLine("Plase Choose 2 for Bus");
                Console.WriteLine("Plase Choose 3 for Boat");
                Console.WriteLine("Plase Choose 4 for ParkMotoCyckle");
                Console.WriteLine("Plase Choose 5 to go back");
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
                  
                        int c = i;
                        switch (input)
                        {
                            case '1':

                                ParkCar(c);
                            
                                break;

                            case '2':
                                ParkBus(c);
                                break;

                            case '3':
                                ParkBoat(c);
                                break;

                            case '4':
                                ParkMotoCyckle(c);
                                break;
                        case '5':
                            a = false;
                            break;
                            
                        }
                    
                }

            }
        }

        internal string FindAVehicle(string regno)
        {
            string feedback = "";

            IEnumerable<Vehicle> query = from s in garage.array
                                         where s.RegNo.ToUpper() == regno.ToUpper()
                                         select s;
            foreach (Vehicle s in query)
                feedback = s.ToString();

            if (feedback == "")
                feedback = "tyvärr så finns inte regnr: " + regno + " i garaget";
            return feedback;
        }

        internal void ListOfAllVehicle()
        {


            for (int i = 0; i < garage.Capacity; i++)
            {
                Console.WriteLine(garage.array[i]);
            }          
            
        }


        public int numberOfVehicle()
        {
            return garage.Count();
        }

        public void ParkCar(int index)
        {
            Console.WriteLine("PLease Enter RegNr");
            var regno = Console.ReadLine();
            Console.WriteLine("PLease Enter Type");
            var type = Console.ReadLine();
            Console.WriteLine("PLease Enter Fule Type");
            var fuletype = Console.ReadLine();
            Car car = new Car(regno, type, fuletype);
             garage.array[index]=(car);
             
          
        }
        public void ParkBus(int index)
        {
            Console.WriteLine();
            var regno = Console.ReadLine();
            var type = Console.ReadLine();
            var color = Console.ReadLine();
            Bus bus = new Bus(regno, type,  color);
            garage.array[index] = (bus);
        }

        public void ParkBoat(int index)
        {
            Console.WriteLine();
            var regno = Console.ReadLine();
            var type = Console.ReadLine();
            var speed = int.Parse(Console.ReadLine());
            Boat boat = new Boat(regno, type,  speed);
            garage.array[index] = (boat);
        }

        public void ParkMotoCyckle(int index)
        {
            Console.WriteLine();
            var regno = Console.ReadLine();
            var type = Console.ReadLine();
            var catagory = Console.ReadLine();
            MotoCyckle motocyckle = new MotoCyckle(regno, type,catagory  );
            garage.array[index] = (motocyckle);
        }

        /// Removing Vehicle from Garage
            public string UnPark(string regnr)
            {
                int i = 0;
                bool exisit = false;
                string answer = "";
                int removeNr = 0;

                foreach (Vehicle s in garage)
                {
                    if (regnr.ToUpper() == s.RegNo.ToUpper())
                    {
                        removeNr = i;
                        exisit = true;
                        answer = "Fordonet med registreringsnr " + regnr + " har lämnat garaget";
                    }
                    i++;
                }

                if (exisit == false)
                    answer = "Det finns inget fordon med det registreringnumret i garaget";
                else
                 garage.RemovAtt(removeNr);

                return answer;
            }
        
    }
}
