using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class GarageList<T> : IEnumerable<T> where T : Vehicle
    {
        public T[] array;
        int capacity;
        int count;
        public int Capacity => capacity;
        public int Count => array.Count(count => count != null);
        public bool IsFull => capacity <= Count;

        //  private Vehicle[] VArr = new Vehicle[13];

            

        public GarageList(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            array = new T[capacity];           
        }

        public bool checkIsGarageFull()
        {
            bool IsFull = false;

            if (count == Capacity)
                IsFull = true;

            return IsFull;
        }

   
           
        

        public virtual bool Add(T Vehicle)
        {
            

            if (IsFull) return false;
           
            var a = array.ToList();
                a.Add(Vehicle);
            return true;
            
        }


        internal Array RemovAtt(int removeNr)
        {
            var V = new List<Vehicle>(array);
            V.RemoveAt(removeNr);
            return V.ToArray();
        }



        //++++++++++++++++++++++++++++++++++++++++++++++++++++

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T vehicle in array)
            {
                yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

       

        //************************************************************                      

    }
}