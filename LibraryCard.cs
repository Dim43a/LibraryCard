using System;
using System.Collections.Generic;
using System.Text;

namespace Dmitri_Zigulev_LibraryCard
{
    class LibraryCard
    {
        protected Book book;
        protected int count;
        public LibraryCard(Book book, int count)
        {
            this.book = book;
            this.count = count;
        }
        public Book Book
        {
            get { return book; }
        }
        public void BookInfo() 
        {
            Console.WriteLine(this.book.ToString());
        }
        public void AddBook()  
        {
            this.count++;
            Console.WriteLine("Book was returned , Thank you!");
        }
        public void TookBook()  
        {
            this.count--;
            Console.WriteLine("Book was taken away , Thank you!");
        }
        public override string ToString()
        {
            return string.Format("Title : {0,3} . Author : {1,3} . Amount of books : {2,3}", book.Title, Book.Author, count);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            LibraryCard book = (LibraryCard)obj;
            return base.Equals(obj);
        }
    }
}
