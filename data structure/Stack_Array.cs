using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class Stack_Array
    {
        // variables 
        int[] arr;
        int tos;
        
        //constructor
        public Stack_Array(int s)
        {
            arr = new int[s];
            tos = 0;
        }
        // operations
        public bool Push(int data)
        {
            bool isPushed = false;
            
            if(tos < arr.Length)
            {
                arr[tos] = data;
                tos++;
                isPushed = true;
            }
           
            return isPushed;
        }
        public int Pop()
        {
            int poped = -1;
            if(tos > 0)
            {
                tos--;
                poped = arr[tos];
            }
            return poped;
        }
        public int GetTos()
        {
            return tos;
        }
        public int GetSize()
        {
            return arr.Length;
        }
        public bool IsEmpty()
        {
            return (tos == 0); 
        }

        public void PrintStackArray()
        {
            for(int i = 0; i < tos ; i++)
            {
                if(arr[i] != 0)
                Console.WriteLine(arr[i]);
            }
        }
    }
}
