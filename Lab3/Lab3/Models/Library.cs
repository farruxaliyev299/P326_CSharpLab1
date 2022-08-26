using Lab3.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    internal class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        //public Library()
        //{
        //    Books = new List<Book>();
        //}

        public List<Book> FilterByPrice(float minPrice, float maxPrice)
        {
            return Books.FindAll(item => item.Price > minPrice && item.Price < maxPrice);
        }

        public List<Book> FilterByGenre(Genre genre)
        {
            List<Book> resultBooks = new List<Book> ();
            foreach (Book book in Books)
            {
                if(book.Genre == genre)
                {
                    resultBooks.Add(book);
                }
            }
            return resultBooks;
            //return Books.FindAll(book => book.Genre == genre);

        }

        public Book FindBookById(int id)
        {
            Book resultBook = Books.Find(book => book.Id == id);
            if (resultBook == null)
            {
                throw new NotFoundException("Your book was not found");
            }
            return Books.Find(book => book.Id == id);
        }
    }
}
