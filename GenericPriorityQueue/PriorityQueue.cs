using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericPriorityQueueDemo
{
    public class PriorityQueue<T>
    {
        // The items list and the corresponding priorities list:
        private List<T> valuesList = new List<T>();
        private List<int> prioritiesList = new List<int>();

        // Return the number of items in the queue.
        public int Count
        {
            get
            {
                return valuesList.Count();
            }
        }

        // Add an item to the queue.  The value and priority are
        // taken in as parameters and the method returns a bool
        // to indicate success or failure of the enqueue operation.
        // Duplicate values are allowed, but duplicate priorities
        // are NOT allowed (return false).
        public bool Enqueue(T newValue, int newPriority)
        {
            //check if value is empty
            if ((object.Equals(newValue, default(T))) || (newPriority <= 0))
            {
                return false;
            }

            // check for duplicates and return false if found
            for (int i = 0; i < prioritiesList.Count; i++)
            {
                if (prioritiesList[i] == newPriority)
                {
                    return false;
                }
            }

            // if not, add values to list
                valuesList.Add(newValue);
                prioritiesList.Add(newPriority);
                return true;           
            
        }

        // Remove the item with the highest priority
        public bool Dequeue(ref T valueDequeued, ref int priorityDequeued)
        {

            int highestQ = 0;
            int vIndex = 0;

            // find the highest number in the Queu
            for (int i = 0; i < prioritiesList.Count; i++)
            {
                if (prioritiesList[i] > highestQ)
                {
                    highestQ = prioritiesList[i];
                    vIndex = i;
                }
            }

            // make sure we found a value
            if (highestQ == 0)
            {
                return false;
            }
            else
            {
                // pass values into variables
                priorityDequeued = highestQ;
                valueDequeued = valuesList[vIndex];

                // remove values from list
                valuesList.Remove(valueDequeued);
                prioritiesList.Remove(priorityDequeued);

                return true;

            }

        }

        //Empty the values list and the priorities list.
        public void Clear()
        {
            valuesList.Clear();
            prioritiesList.Clear();
        }
    }
}
