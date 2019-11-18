using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class UI
    {
        private readonly GarageHandler GH;
       

        public UI(GarageHandler gh)
        {
            this.GH = gh;
        }
        public void UserInterface()
        {


           // string regno;
            //string type;
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Press 1 to Park A New Vehicle");
                Console.WriteLine("Press 2 to UnPark A New Vehicle");
                Console.WriteLine("Press 3 to show A list of all vehicles");
                Console.WriteLine("Press 4 to A find a certian vehicle");
                Console.WriteLine("Press q To Quit");

                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {

                    Console.Clear();
                    Console.WriteLine("Please Enter A Valid Value");
                }

                switch (input)
                {
                    case '1':
                        //Call Add Method     
                        
                        GH.Park();
                      
                        break;
                        
                    case '2':
                        // Call Remove Method
                        Console.WriteLine("Please Enter A regNr to delet a Vehicle");
                        string regno = Console.ReadLine();
                        GH.UnPark(regno);

                        string Rmsg = GH.UnPark(regno);
                        Console.WriteLine(Rmsg);


                        break;

                    case '3':
                        //Call Stats Method
                     
                        GH.ListOfAllVehicle();
                        break;

                    case '4':
                        Console.WriteLine("Please Enter A regNr to find a Vehicle");
                        string regno1 = Console.ReadLine();
                        GH.FindAVehicle(regno1);
                        string feedback = GH.FindAVehicle(regno1);
                        Console.WriteLine(feedback);
                        break;

                        

                    case 'q':
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
