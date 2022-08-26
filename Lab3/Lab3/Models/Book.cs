using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    public enum Genre
    {
        Action=1,
        Detective,
        Fantasy,
        Comedy

    }
    internal class Book
    {
        private static int _id { get; set; }

        public readonly int Id;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public float Price { get; set; }

        public Book()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nGenre: {Genre.ToString()}\nPrice: {Price}\n";
        }
    }
}
