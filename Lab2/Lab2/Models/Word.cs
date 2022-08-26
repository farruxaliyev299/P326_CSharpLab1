using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    internal class Word:IPrintableFile
    {
        public string FileName { get; set; }
        public int WordCount { get; set; }

        public Word(int wordCount)
        {
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"File Name : {FileName}\nWord Count: {WordCount}"); ;
        }
    }
}
