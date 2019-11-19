using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class GarageList<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] array;
        int capacity;
        int count;
        public int Capacity => capacity;
        public int Count => array.Count(count => count != null);
        public bool IsFull => capacity <= Count;

        //  private Vehicle[] VArr = new Vehicle[13];

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

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

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = Vehicle;
                    return true;
                }
            }
            return false;
            
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
                if(vehicle != null)
                yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        internal bool Unpark(Vehicle vehicleToRemove)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == vehicleToRemove)
                {
                    array[i] = null;
                    return true;
                }
            }
            return false;
        }




        //************************************************************                      

    }
}