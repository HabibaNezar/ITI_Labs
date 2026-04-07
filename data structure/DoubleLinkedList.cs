using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class DoubleLinkedList
    {
        private Node head;
        private Node tail;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }

        // add node
        public void AddNode(int id, string name, decimal salary)
        {
            Node newNode = new Node(id, name, salary);
            if(head == null)
            {
                head = tail = newNode;
                return;
            }
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
           
        // search node
        public void SearchNodeByName(string targetName)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Emp.Name == targetName)
                {
                    Console.WriteLine($"Employee {current.Emp.Id} found: Name: {current.Emp.Name} | Salary: {current.Emp.Salary}");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Employee not found");

        }
    
        // count node => return total number of nodes
        public int CountNode()
        {
            int count = 0;
            Node current = head;

            while(current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        // print all nodes in the list
        public void PrintList()
        {
            Node current = head;
            
            while (current != null)
            {
                Console.WriteLine($"[{current.Emp.Id} | {current.Emp.Name} | {current.Emp.Salary}]");
                current = current.Next;
            }
        }

        // insert node depend on location
        public bool InsertNode(Employee e , int loc)
        {
            bool isInserted = false;
            // create new node
            Node newNode = new Node(e.Id, e.Name, e.Salary);
            if(loc < 0)
            {
                return false;
            }
            if (newNode != null)
            {
                //case 1 => head=null => list is empty
                if(head == null) 
                {
                    head = tail = newNode;
                }
                else 
                {
                    // case 2 insert in loc=0 => replace head
                    if (loc == 0)
                    {
                        newNode.Next = head;
                        head.Prev = newNode;
                        head = newNode;
                    }
                    // case 3 insert in the last loc => list.len-1
                    else
                    {
                        Node temp = head;
                        for(int i=0; temp.Next!=null && i < loc-1; i++) // search for loc & put the temp node in the prev location
                        {
                            temp = temp.Next;
                        }
                        if (temp.Next == null) // insert at end
                        {
                            newNode.Prev = tail;
                            tail.Next = newNode;
                            tail = newNode;
                        }
                        else // in a specific loc in midd
                        {
                            if (temp.Next != null)
                            {
                                temp.Next.Prev = newNode;
                            }
                            newNode.Next = temp.Next;
                            temp.Next = newNode;
                            newNode.Prev = temp;
                        }

                    }
                }
                
                isInserted = true;
            }

            return isInserted;
        }

        // delete node
        public bool DeleteNode( int loc)
        {
            if (loc < 0)
                return false;
            bool isDeleted = false;
            // create new node
            Node deletedNode = head;

           
            if(head != null)
            {
                if(loc == 0)
                {
                    if(head == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        head = head.Next;
                        head.Prev = null;
                    }
                    isDeleted = true;
                }
                else
                {
                    for(int i=0; deletedNode!=null && i<loc; i++)
                    {
                        deletedNode = deletedNode.Next;
                    }
                    if(deletedNode != null)
                    {
                        if (deletedNode == tail)
                        {
                            tail = tail.Prev;
                            if (tail != null)
                                tail.Next = null;
                        }
                        else
                        {
                            deletedNode.Prev.Next = deletedNode.Next;
                            deletedNode.Next.Prev = deletedNode.Prev;
                        }
                        isDeleted = true;
                    }
                    
                }
            }
            return isDeleted;
        }

    }
}
