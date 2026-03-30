using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Subject() { }
        public Subject(int code, string name)
        {
            Code = code;    
            Name = name;
        }
    }
}
