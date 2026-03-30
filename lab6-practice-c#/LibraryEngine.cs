using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_practice_c_
{
    public class LibraryEngine
    {
        // this is a normal method accept 2 parameters 1- book list 2- deligate (any method have 1 parameter (Book) and return string)
        public static void ProcessBooks(List<Book> bList,BookDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // apply bredefined delegate(func) instead of user defined delegate ==> this is ex for over loading
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
