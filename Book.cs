using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulLibrary
{
    public class Book
    {
        public int BookId { get; private set; }
        public string Title { get; private set; }

        public Book(int bookId, string title)
        {
            BookId = bookId;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
