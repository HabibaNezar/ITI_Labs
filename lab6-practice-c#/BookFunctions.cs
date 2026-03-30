using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_practice_c_
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return B.Authors != null ? string.Join(",", B.Authors) : "unknown";
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString("c"); // currency format
        }
    }
}
