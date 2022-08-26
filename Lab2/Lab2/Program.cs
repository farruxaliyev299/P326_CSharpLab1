using Lab2.Models;
using System;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word textFile = new Word(120);
            textFile.FileName = "Word";

            Pdf pageFile = new Pdf(90);


            Excel diagramFile = new Excel(50, 60);

            PrintFile printer = new PrintFile();

            printer.Print(textFile);
        }
    }
}
