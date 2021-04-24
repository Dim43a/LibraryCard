using System;
using System.Collections.Generic;
using System.Text;

namespace Dmitri_Zigulev_LibraryCard

{
    class Book
    {
        protected string title;
        protected string author;
        protected string publisher;
        protected int pubyear;
        protected int pageamount;
        public Book(string title,string author,string publisher,int pubyear,int pageamount)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.pubyear = pubyear;
            this.pageamount = pageamount;
        }
        public string Publisher
        {
            get { return publisher; }
        }
        public string Author
        {
            get { return author; }
        }
        public string Title
        {
            get { return title; }
        }

        public int Pageamount
        {
            get { return pageamount; }
            set
            {
                if (value >0)
                {
                    pageamount = value;
                }
                else
                {
                    Console.WriteLine("Page amount can't be below than 0 .");
                }
            }
        }
        public int Pubyear
        {
            get { return pubyear; }
            set
            {
                if (value > 0)
                {
                    pubyear = value;
                }
                else
                {
                    Console.WriteLine("Publishing year can't be below than 0 .");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("" +
                "Title : {0,3}. " +
                "\nAuthor : {1,3}. " +
                "\nPublisher : {2,3}. " +
                "\nWas published in {3,3}. " +
                "\nAmount of pages : {4,3}.",
                title, author, publisher, pubyear, pageamount);
        }
        public override bool Equals(object obj) 
        {
            Book temp = (Book)obj;
            return base.Equals(obj);
        }
        public override int GetHashCode() 
        {
            return title.ToUpper().GetHashCode();
        }
    }
}
