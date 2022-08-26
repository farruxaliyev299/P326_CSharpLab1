using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal interface IPrintableFile
    {
        public string FileName { get; set; }
        public void Print();
    }
}
