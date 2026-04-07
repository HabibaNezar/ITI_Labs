using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class SingleNode
    {
        public int Data { get; set; }
        public SingleNode Next { get; set; }

        public SingleNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
