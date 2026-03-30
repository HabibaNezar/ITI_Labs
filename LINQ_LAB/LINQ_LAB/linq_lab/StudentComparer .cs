using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return x.Age == y.Age;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Age.GetHashCode();
        }
    }
}
