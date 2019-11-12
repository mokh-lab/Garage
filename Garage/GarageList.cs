using System.Collections;
using System.Collections.Generic;

namespace Garage
{
    internal class GarageList<T> : IEnumerable<T> where T : Vehicle
    {
        public int Capacity { get; set; }
        public GarageList(int capacity) 
        {
           
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
    }
}