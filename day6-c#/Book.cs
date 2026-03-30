using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_c_
{
    // a. User Defined Delegate Datatype
    public delegate string BookDelegate(Book b);
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            string authorsList = Authors != null ? string.Join(", ", Authors) : "Unknown";
            return $"ISBN: {ISBN}, Title: {Title}, Authors: [{authorsList}], Published: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
    }
}
