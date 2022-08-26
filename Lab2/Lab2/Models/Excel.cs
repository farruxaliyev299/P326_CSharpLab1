using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    internal class Excel:IPrintableFile
    {
        public string FileName { get; set; }
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }

        public Excel(int columnCount , int rowCount)
        {
            ColumnCount = columnCount;
            RowCount = rowCount;
        }

        public void Print()
        {
            Console.WriteLine($"File Name: {FileName}\nColumn Count: {ColumnCount}\nRow Count: {RowCount}"); ;
        }
    }
}
