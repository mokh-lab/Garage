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
          
                bool a=true;
                int i = 0;
           
            while ( garage.Count < garage.Capacity)
            {
                char input = ' ';
                Console.WriteLine("Plase Choose The type of the Vehicle");
                Console.WriteLine("Plase Choose 1 for Car");
                Console.WriteLine("Plase Choose 2 for Bus");
                Console.WriteLine("Plase Choose 3 for Boat");
                Console.WriteLine("Plase Choose 4 for ParkMotoCyckle");
                Console.WriteLine("-----------------------------");               
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
                if (i < garage.Capacity)
                {
                    bool garageFull;


                    int c = i;
                    switch (input)
                    {
                        case '1':
                            garageFull = garage.checkIsGarageFull();

                            if (garageFull == true)
                                Console.WriteLine("Sorry the garage is  full ");
                            else
                            {


                                ParkCar(c);
                                Console.WriteLine("the Vehicle has been parked");
                            }

                            break;

                        case '2':
                            garageFull = garage.checkIsGarageFull();
                            if (garageFull == true)
                                Console.WriteLine("Sorry the garage is  full ");
                            else
                            {

                                ParkBus(c);
                                Console.WriteLine("the Vehicle has been parked");
                            }

                            break;

                        case '3':
                            garageFull = garage.checkIsGarageFull();
                            if (garageFull == true)
                                Console.WriteLine("Sorry the garage is  full ");
                            else
                            {

                                ParkBoat(c);
                                Console.WriteLine("the Vehicle has been parked");
                            }

                            break;

                        case '4':

                            garageFull = garage.checkIsGarageFull();
                            if (garageFull == true)
                                Console.WriteLine("Sorry the garage is  full ");
                            else
                            {

                                ParkMotoCyckle(c);
                                Console.WriteLine("the Vehicle has been parked");
                            }


                            break;

                        case '5':
                            a = false;
                            break;


                    }
                    i = i + 1;
                    
                }
                else 
                {
                    Console.WriteLine("The Garge is full");

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
                    feedback = "The Regnr Is: "+ s.RegNo +"  The Type Is: "+ s.Type;
            
           

                if (feedback == "")
                feedback = "Sorry No such match for regnr!!: " + regno + " in the garage";
            return feedback;
        }

        internal void ListOfAllVehicle()
        {


            /*  for (int i = 0; i < garage.Capacity; i++)
              {

                  garage.array[0].printInfo();


              }*/

            foreach (var item in garage.array)
            {
               string a=item.RegNo;
                string b = item.Type;
                Console.WriteLine($"The RegNr is:  { a}");
                Console.WriteLine($"The type  is:  { b}");
                Console.WriteLine("    ");
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
            var type = "Car";
            Console.WriteLine("PLease Enter Fule Type");
            var fuletype = Console.ReadLine();
            Car car = new Car(regno, type, fuletype);
             garage.array[index]=(car);
             
          
        }
        public void ParkBus(int index)
        {
            Console.WriteLine();
            Console.WriteLine("PLease Enter RegNr");
            var regno = Console.ReadLine();
            var btype = "Bus";
            Console.WriteLine("PLease Enter Color");
            var color = Console.ReadLine();
            Bus bus = new Bus(regno, btype,  color);
            garage.array[index] = (bus);
        }

        public void ParkBoat(int index)
        {
            Console.WriteLine();
            Console.WriteLine("PLease Enter RegNr");
            var regno = Console.ReadLine();
            var otype = "Boat";
            Console.WriteLine("PLease Enter Speed");
            var speed = int.Parse(Console.ReadLine());
            Boat boat = new Boat(regno, otype,  speed);
            garage.array[index] = (boat);
        }

        public void ParkMotoCyckle(int index)
        {
            Console.WriteLine();
            Console.WriteLine("PLease Enter RegNr");
            var regno = Console.ReadLine();
            var mtype = "MotoCyckle";
            Console.WriteLine("PLease Enter Catagory");
            var catagory = Console.ReadLine();
            MotoCyckle motocyckle = new MotoCyckle(regno, mtype,catagory  );
            garage.array[index] = (motocyckle);
        }

        /// ** Removing Vehicle from Garage **
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
                        answer = "The Vehicle with RegNr " + regnr + "has left the grage";
                    }
                    i++;
                }

                if (exisit == false)
                    answer = "Sorry No such match fro a RegNr";
                else
                 garage.RemovAtt(removeNr);

                return answer;
            }
        
    }
}
