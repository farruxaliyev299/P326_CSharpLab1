
using Lab3.Models;
using System;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "exampleBook1";
            book1.Genre = Genre.Action;
            book1.Price = 20;

            Book book2 = new Book();
            book2.Name = "exampleBook2";
            book2.Genre = Genre.Comedy;
            book2.Price = 30;

            Book book3 = new Book();
            book3.Name = "exampleBook1";
            book3.Genre = Genre.Comedy;
            book3.Price = 40;

            Library library = new Library();

            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);

            library.FilterByGenre(Genre.Comedy).ForEach(item => Console.WriteLine(item));
            //library.FilterByPrice(10, 45).ForEach(item => Console.WriteLine(item));
            //Book resultBook = library.FindBookById(10);
            //Console.WriteLine(resultBook);
        }
    }
}
