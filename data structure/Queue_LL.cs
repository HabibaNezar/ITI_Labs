using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class Queue_LL
    {
        SingleNode Head;
        SingleNode Tail;

        public Queue_LL()
        {
            Head = Tail = null;
        }

        public bool EnQueue(int data)
        {
            bool isEnQueu = false;
            SingleNode nd = new SingleNode(data);
            if(nd != null)
            {
                // 2cases
                if(Head == null) // no list
                {
                    Head = Tail = nd;
                }
                else // list is exist
                {
                    Tail.Next = nd;  
                    Tail = nd;
                }
                isEnQueu = true;
            }

            return isEnQueu;
        }

        public SingleNode DeQueue()
        {
            SingleNode nd = Head;
            if(Head != null)
            {
                Head = Head.Next;
                if(Head == null) // one node
                {
                    Tail = null;
                }
            }
            return nd;
        }
    
        public bool isEmpty()
        {
            return Head == null;
        }
    
        public void PrintQ()
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
