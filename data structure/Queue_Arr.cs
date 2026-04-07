using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class Queue_Arr
    {
        int[] arr;
        int front;
        int rear;
        public Queue_Arr(int n)
        {
            arr = new int[n];
            front = 0;
            rear = -1;
        }

        public bool EnQueue(int n)
        {
            if (rear == arr.Length - 1)
                return false;

            rear++;
            arr[rear] = n;
            return true;
        }

        public int? DeQueue()
        {
            if (front > rear)
                return null;

            int value = arr[front];
            front++;
            return value;
        }

        public void PrintQArr()
        {
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public bool IsEmpty()
        {
            return front > rear;
        }

        public bool IsFull()
        {
            return rear == arr.Length - 1;
        }


    }
}
