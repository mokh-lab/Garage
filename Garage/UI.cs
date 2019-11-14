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
                Console.WriteLine("Press 1 To Park A New Vehicle");
                Console.WriteLine("Press 2 To UnPark A New Vehicle");
                Console.WriteLine("Press 3 To Show Stats Option A New Vehicle");
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

                        //Park(v.RegNo, v.Type);
                        break;
                        
                    case '2':
                        // Call Remove Method
                        string regno = Console.ReadLine();
                        //GH.UnPark(regno);
                        break;

                    case '3':
                        //Call Stats Method

                        break;

                    case 'q':
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
