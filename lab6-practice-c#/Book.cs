using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_practice_c_
{
    // user defined dekegate
    // delegate: 
    // must be in the namespace scope.
    // it take a book parameter type and return string
    // now what this shit delegate do now????

    public delegate string BookDelegate(Book B);

    public class Book
    {
        #region dynamic prop
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region constructors
        public Book(string _ISBN , string _Title ,  string[] _Authors , DateTime _PublicationDate ,  decimal _Price) 
        { 
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        #endregion

        #region methods
        public override string ToString()
        { 
            string authorList = Authors != null ? string.Join(",", Authors) : "unKnown";
            return $"ISBN = {ISBN}, Title = {Title}, Authors = {authorList}, PublicationDate = {PublicationDate}, Price = {Price}";
        }
        #endregion

    }
}
