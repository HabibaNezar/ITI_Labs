using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class StackLL
    {
        SingleNode Head;
        SingleNode Tail;

        public StackLL()
        {
            Head = Tail = null;
        }

        public bool Push(int data)
        {
            bool isAdded = false;
            SingleNode nd = new SingleNode(data);
            if (nd != null)
            {
                if (Head == null)
                {
                    Head = Tail = nd;
                }
                else
                {
                    nd.Next = Head;
                    Head = nd;
                }
                isAdded = true;
            }
            
            return isAdded;
        }

        public bool Pop()
        {
            bool isRemoved = false;
            
            if(Head != null)
            {
                Head = Head.Next;
                isRemoved = true;
            }
            return isRemoved;
        }

        public void PrintSLL()
        {
            SingleNode current = Head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

        }
    }
}
