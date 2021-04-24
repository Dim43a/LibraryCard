using System;

namespace Dmitri_Zigulev_LibraryCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Jevgeny Onegin", "Aleksadr Sergeevich Pushkin", "Grand Fair", 1987, 400);
            Book book2 = new Book("Mjertvie Dushi", "Nikolaj Vasiljevich Gogol", "EKONOM", 1975, 352);
            Book book3 = new Book("Misery", "Stephen King", "Third wave", 2001, 200);
            Book book4 = new Book("Graf Monte Christo", "Aleksandr Djuma", "Best from us", 2010, 1344);
            Console.WriteLine(book1.ToString());
            Console.WriteLine();
            Console.WriteLine(book2.ToString());
            Console.WriteLine();
            Console.WriteLine(book3.ToString());
            Console.WriteLine();
            Console.WriteLine(book4.ToString());
            Console.WriteLine();
            Console.WriteLine(book1.Equals(book2)); // False
            Console.WriteLine(book1.Equals(book1));  //  True
            Console.WriteLine();

            LibraryCard card1 = new LibraryCard(book1, 10);

            Console.WriteLine(card1.ToString());
            card1.AddBook();                   
            Console.WriteLine();

            Console.WriteLine(card1.ToString());
            card1.TookBook();  
            Console.WriteLine();   

            card1.BookInfo();  

            Console.ReadKey();
        }
    }
}
