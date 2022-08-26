using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    internal class Pdf:IPrintableFile
    {
        public string FileName { get; set; }
        public int PageCount { get; set; }

        public Pdf(int pageCount)
        {
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"File Name: {FileName}\nPage Count: {PageCount}"); ;
        }
    }
}
