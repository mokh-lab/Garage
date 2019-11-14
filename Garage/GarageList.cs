using System;
using System.Collections;
using System.Collections.Generic;


namespace Garage
{
    public class GarageList<T> : IEnumerable<T> where T : Vehicle
    {
        public T[] array;
        int capacity;
        public int Capacity => capacity;
        public int Count => array.Length;
        public bool IsFull => capacity <= Count;

        //  private Vehicle[] VArr = new Vehicle[13];

        public GarageList(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            array = new T[capacity];
        }
      
      


       //++++++++++++++++++++++++++++++++++++++++++++++++++++

       public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        
       /* internal void Park( Car car)
        {


            for (int i = 0; i < Capacity; i++)
            {
                string a = car.RegNo;
                string b = car.Type;
                string c = car.FuleType;
                Console.WriteLine("Enter Regno");
                 a = Console.ReadLine();
                Console.WriteLine("Enter Vehicle Type");
                 b = Console.ReadLine();
                Console.WriteLine("Enter Fule Type");
                 c = Console.ReadLine();


                array[i] = car as T;
            }
        }*/
    }
}