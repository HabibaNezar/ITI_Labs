using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class Node
    {
        public Employee Emp { get; set; }
        public Node Next;
        public Node Prev;

        public Node(int id, string name, decimal salary)
        {
            Emp = new Employee(id, name, salary);
            Next = null;
            Prev = null;
        }
    }
}
