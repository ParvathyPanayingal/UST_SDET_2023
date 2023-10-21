using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class BookType : Book

    {
        public string? Genre { get; set; }
        public BookType(string? title, string? author, int isbn, int price, string? availability, string? genre) : base(title, author, isbn, price, availability)
        {
            this.Genre = genre;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Book Title:{Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Isbn:{ISBN}");
            Console.WriteLine($"Price Of Book:{Price}");
            Console.WriteLine($"Availability:{Availability}");
            Console.WriteLine($"Book Type:{Genre}");
        }
    }

}
